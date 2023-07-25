namespace KestenApp.Services
{
    using Microsoft.EntityFrameworkCore;

    using KestenApp.Data;
    using KestenApp.Data.Enums;
    using KestenApp.Data.Models;
    using KestenApp.Services.Contracts;
    using KestenApp.Services.Models;
    using KestenApp.Web.ViewModels.Varieties;

    public class VarietyService : IVarietyService
    {
        private readonly KestenDbContext _context;

        public VarietyService(KestenDbContext context)
        {
            _context = context;
        }

        #region List
        //List varieties - add paging
        public async Task<VarietyListModel> AllVarietiesAsync(
            string? name = null,
            VarietySortingType sorting = VarietySortingType.DateCreated,
            int currentPage = 1,
            int countPerPage = int.MaxValue)
        {
            VarietyServiceModel varietiesPage = await AllVarietiesServiceModelAsync(currentPage: currentPage);

            VarietyListModel listViewModel = GenerateListViewModel(varietiesPage.Varieties);

            return listViewModel;
        }


        private async Task<VarietyServiceModel> AllVarietiesServiceModelAsync(
            string? name = null,
            VarietySortingType sorting = VarietySortingType.DateCreated,
            int currentPage = 1,
            int countPerPage = int.MaxValue)
        {
            IQueryable<Variety> varietiesQuery = _context
                .Varieties
                .Include(v => v.Species)
                    .ThenInclude(fs => fs.Species)
                .Include(v => v.FruitSizes)
                    .ThenInclude(fs => fs.FruitSize)
                .Include(v => v.IsPollenizedBy)
                .Include(v => v.IsPollenizerFor)
                .Include(v => v.IsGraftedOn)
                .Include(v => v.IsRootstockFor);

            if (!string.IsNullOrWhiteSpace(name))
            {
                varietiesQuery = varietiesQuery
                    .Where(c => c.Name.ToLower().Contains(name.ToLower()));
            }

            varietiesQuery = sorting switch
            {
                VarietySortingType.VarietyName => varietiesQuery.OrderByDescending(c => c.Name),
                VarietySortingType.FruitSizes => varietiesQuery.OrderBy(c => c.FruitSizes).ThenBy(c => c.Name),
                VarietySortingType.DateCreated or _ => varietiesQuery.OrderBy(c => c.DateCreated)
            };

            int totalCount = varietiesQuery.Count();

            IEnumerable<Variety> varieties = await varietiesQuery
                .Skip((currentPage - 1) * countPerPage)
                .Take(countPerPage)
                .ToListAsync();

            return new VarietyServiceModel
            {
                TotalCount = totalCount,
                CurrentPage = currentPage,
                CountPerPage = countPerPage,
                Varieties = varieties
            };
        }


        private static VarietyListModel GenerateListViewModel(IEnumerable<Variety> allVarieties)
        {
            var varietiesViewModels = allVarieties
                .Select(v => ConstructVarietyModel(v));

            return new VarietyListModel(varietiesViewModels);
        }

        private static VarietyListDetailsModel ConstructVarietyModel(Variety v)
        {
            IEnumerable<string> species = v.Species
                .OrderBy(s => s.Species.ShortLatinName)
                .Select(s => s.Species.ShortLatinName)
                .ToList();

            IEnumerable<string> fruitSizes = v.FruitSizes
                .OrderBy(fs => fs.FruitSizeId)
                .Select(fs => fs.FruitSize.Name)
                .ToList();

            return new VarietyListDetailsModel
            {
                VarietyId = v.VarietyId,
                VarietyName = v.Name,


                //Tree

                Species = ServiceExtensions.JoinStrings(species),
                ChestnutBlightResistance = ServiceExtensions.GetStringValueOfNullableEnum(v.ChestnutBlightResistance),
                InkDiseaseResistance = ServiceExtensions.GetStringValueOfNullableEnum(v.InkDiseaseResistance),
                PollenFertility = ServiceExtensions.GetStringValueOfNullableEnum(v.PollenType),
                Vigor = ServiceExtensions.GetStringValueOfNullableEnum(v.Vigor),
                BuddingPeriod = ServiceExtensions.GetStringValueOfNullableEnum(v.BuddingPeriod),
                FloweringPeriod = ServiceExtensions.GetStringValueOfNullableEnum(v.FloweringPeriod),
                MaturityPeriod = ServiceExtensions.GetStringValueOfNullableEnum(v.MaturityPeriod),

                //Fruit

                //Taste
                FruitSizes = ServiceExtensions.JoinStrings(fruitSizes),
                IsMarron = ServiceExtensions.GetStringFromNullableBoolean(v.IsMarron),

                Peeling = ServiceExtensions.GetStringValueOfNullableEnum(v.Peeling),
                Conservation = ServiceExtensions.GetStringValueOfNullableEnum(v.Conservation),

                IsPollenizedBy = ServiceExtensions.JoinStrings(
                    v.IsPollenizedBy
                    .Select(p => p.PollenizerVariety.Name)
                    .OrderBy(n => n)),
                IsPollenizerFor = ServiceExtensions.JoinStrings(
                    v.IsPollenizerFor
                    .Select(p => p.PollenizerVariety.Name)
                    .OrderBy(n => n)),
                IsRootstockFor = ServiceExtensions.JoinStrings(
                    v.IsRootstockFor
                    .Select(p => p.GraftedVariety.Name)
                    .OrderBy(n => n)),
                IsGraftedOn = ServiceExtensions.JoinStrings(
                    v.IsGraftedOn
                    .Select(p => p.RootstockVariety.Name)
                    .OrderBy(n => n))
            };
        }
        #endregion

        //Details
        public async Task<Variety?> GetDetailsViewByIdAsync(Guid id)
        {
            Variety? variety = await _context
                .Varieties
                //Include more data
                .Include(v => v.VarietyImages)
                .Include(v => v.Species)
                    .ThenInclude(v => v.Species)
                .Include(v => v.FruitSizes)
                    .ThenInclude(v => v.FruitSize)
                .FirstOrDefaultAsync(p => p.VarietyId == id);

            return variety;
        }

        public async Task<Variety?> GetVarietyByNameAsync(string name)
        {
            Variety? variety = await _context
                .Varieties
                .FirstOrDefaultAsync(p => p.Name.ToLower() == name);

            return variety;
        }


        //Search - Must have filters!!!
        public async Task<IEnumerable<Variety>> SearchVarietiesAsync(string searchQuery)
        {
            return await _context
                .Varieties
                .Where(p => p.Name.Contains(searchQuery))
                .ToListAsync();
        }

        //Add
        public async Task<Guid> AddVarietyAsync(VarietyFormModel model)
        {
            int[] selectedSpeciesIds = model.SpeciesCheckboxes
                .Where(sp => sp.IsChecked)
                .Select(sp => sp.Id).ToArray();

            Variety variety = new Variety
            {
                Name = model.VarietyName,
                Species = _context.Species
                    .Where(s => selectedSpeciesIds.Contains(s.SpeciesId))
                    .Select(s => new VarietySpecies
                    {
                        SpeciesId = s.SpeciesId,
                    })
                    .ToList(),
                Description = model.Description,
                PollenType = model.PollenType
            };

            await _context.Varieties.AddAsync(variety);
            await _context.SaveChangesAsync();

            return variety.VarietyId;
        }

        //Update
        public async Task<Guid?> UpdateVarietyAsync(Guid id, VarietyFormModel model)
        {
            var variety = await _context.Varieties
                .Where(v => v.VarietyId == id)
                .Include(v => v.Species)
                .FirstOrDefaultAsync();

            if (variety == null)
            {
                return null;
            }

            variety.Name = model.VarietyName;
            variety.Description = model.Description;

            int[] selectedSpeciesIds = model.SpeciesCheckboxes
                .Where(sp => sp.IsChecked)
                .Select(sp => sp.Id).ToArray();
            variety.Species = _context.Species
                .Where(s => selectedSpeciesIds.Contains(s.SpeciesId))
                .Select(s => new VarietySpecies
                {
                    SpeciesId = s.SpeciesId,
                })
                .ToList();

            variety.PollenType = model.PollenType;

            await _context.SaveChangesAsync();

            return id;
        }

        //Remove





    }
}

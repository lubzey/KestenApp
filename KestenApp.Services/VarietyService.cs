namespace KestenApp.Services
{
    using Microsoft.EntityFrameworkCore;

    using KestenApp.Data;
    using KestenApp.Data.Enums;
    using KestenApp.Data.Models;
    using KestenApp.Services.Contracts;
    using KestenApp.Services.Models;
    using KestenApp.Web.ViewModels.Varieties;
    using KestenApp.Data.Enums.EnumHelpers;
    using KestenApp.Web.ViewModels;
    using KestenApp.Data.Migrations;

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
            int countPerPage = int.MaxValue,
            bool isPublished = true)
        {
            VarietyServiceModel varietiesPage = await AllVarietiesServiceModelAsync(currentPage: currentPage, isPublished: isPublished);

            VarietyListModel listViewModel = GenerateListViewModel(varietiesPage.Varieties);

            return listViewModel;
        }


        private async Task<VarietyServiceModel> AllVarietiesServiceModelAsync(
            string? name = null,
            VarietySortingType sorting = VarietySortingType.DateCreated,
            int currentPage = 1,
            int countPerPage = int.MaxValue,
            bool isPublished = true)
        {
            IQueryable<Variety> varietiesQuery = _context
                .Varieties
                .Include(v => v.Species)
                    .ThenInclude(fs => fs.Species)
                .Include(v => v.FruitSizes)
                    .ThenInclude(fs => fs.FruitSize)

                .Include(v => v.IsPollenizedBy.Where(v => v.PollenizerVariety.IsPublished == isPublished))
                .Include(v => v.IsPollenizerFor.Where(v => v.TargetVariety.IsPublished == isPublished))

                .Include(v => v.IsGraftedOn.Where(v => v.RootstockVariety.IsPublished == isPublished))
                .Include(v => v.IsRootstockFor.Where(v => v.GraftedVariety.IsPublished == isPublished))

                .Where(v => v.IsPublished == isPublished && v.IsActive);

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

            var query = varietiesQuery.ToString();

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
        public async Task<VarietyDetailsModel> GetDetailsViewByIdAsync(Guid id)
        {
            Variety variety = await GetVarietyByIdAsync(id);

            int[] varietySpecies = variety
                .Species
                .Select(vs => vs.SpeciesId)
                .ToArray();

            IList<CheckboxModel> speciesCheckboxes = await GenerateSpeciesCheckboxesAsync(varietySpecies);
            VarietyDetailsModel detailsModel = new VarietyDetailsModel(variety, speciesCheckboxes);

            return detailsModel;
        }

        public async Task<VarietyFormModel> GetFormViewByIdAsync(Guid id)
        {
            Variety variety = await GetVarietyByIdAsync(id);

            int[] varietySpeciesIds = variety
                .Species
                .Select(vs => vs.SpeciesId)
                .ToArray();

            VarietyFormModel formModel = new VarietyFormModel
            {
                //Details
                VarietyId = variety.VarietyId,
                VarietyName = variety.Name,
                Description = variety.Description,
                ThumbnailImagePath = variety.VarietyImages.Any() ?
                    $"/Images/Varieties/{variety.VarietyId}/{variety.VarietyImages.First().ImageId}.jpg" :
                    "/Images/no-image.jpg", //Move to constants

                //Tree
                SpeciesCheckboxes = await GenerateSpeciesCheckboxesAsync(varietySpeciesIds),
                
                BlightResistanceOptions = GenerateConditionOptions(),
                InkDiseaseResistanceOptions = GenerateConditionOptions(),

                PollenType = variety.PollenType,
                PollenOptions = GeneratePollenOptions(),

                Vigor = variety.Vigor,
                VigorOptions = GenerateVigorOptions(),

                BuddingPeriod = variety.BuddingPeriod,
                BuddingPeriodOptions = GeneratePeriodOptions(),

                FloweringPeriod = variety.FloweringPeriod,
                FloweringPeriodOptions = GeneratePeriodOptions(),

                MaturityPeriod = variety.MaturityPeriod,
                MaturityPeriodOptions = GeneratePeriodOptions(),

                //Fruit
                ChestnutBlightResistance = variety.ChestnutBlightResistance,
                InkDiseaseResistance = variety.InkDiseaseResistance
            };

            return formModel;
        }



        private async Task<Variety> GetVarietyByIdAsync(Guid id)
        {
            Variety variety = await _context
                .Varieties
                //Include more data
                .Include(v => v.VarietyImages)
                .Include(v => v.Species)
                    .ThenInclude(v => v.Species)
                .Include(v => v.FruitSizes)
                    .ThenInclude(v => v.FruitSize)
                .FirstAsync(p => p.VarietyId == id);

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
                PollenType = model.PollenType,
                ChestnutBlightResistance = model.ChestnutBlightResistance,
                InkDiseaseResistance = model.InkDiseaseResistance,
                Vigor = model.Vigor,
                BuddingPeriod = model.BuddingPeriod,
                FloweringPeriod = model.FloweringPeriod,
                MaturityPeriod = model.MaturityPeriod
            };

            await _context.Varieties.AddAsync(variety);
            await _context.SaveChangesAsync();

            return variety.VarietyId;
        }

        //Update
        public async Task<Guid?> UpdateVarietyAsync(Guid id, VarietyFormModel model)
        {
            var variety = await _context
                .Varieties
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
            variety.ChestnutBlightResistance = model.ChestnutBlightResistance;
            variety.InkDiseaseResistance = model.InkDiseaseResistance;
            variety.Vigor = model.Vigor;
            variety.BuddingPeriod = model.BuddingPeriod;
            variety.FloweringPeriod = model.FloweringPeriod;
            variety.MaturityPeriod = model.MaturityPeriod;


            await _context.SaveChangesAsync();

            return id;
        }

        public async Task ArchiveByIdAsync(Guid id, bool restore = false)
        {
            Variety variety = await this._context
                .Varieties
                .FirstAsync(h => h.VarietyId == id);

            if (restore)
            {
                variety.IsActive = true;
            }
            else
            {
                variety.IsActive = false;
                variety.IsPublished = false;
            }

            await this._context.SaveChangesAsync();
        }

        public async Task PublishVarietyAsync(Guid id, bool unpublish = false)
        {
            Variety variety = await this._context
                .Varieties
                .FirstAsync(h => h.VarietyId == id);

            variety.IsPublished = true;

            if (unpublish)
            {
                variety.IsPublished = false;
            }

            await this._context.SaveChangesAsync();
        }

        public IEnumerable<DropdownModel> GenerateConditionOptions()
        {
            return MapDropdown<ConditionType>();
        }

        public IEnumerable<DropdownModel> GeneratePollenOptions()
        {
            return MapDropdown<PollenType>();
        }

        public IEnumerable<DropdownModel> GenerateVigorOptions()
        {
            return MapDropdown<StrengthType>();
        }

        public IEnumerable<DropdownModel> GeneratePeriodOptions()
        {
            return MapDropdown<PeriodType>();
        }

        private IEnumerable<DropdownModel> MapDropdown<TEnum>()
        {
            return EnumExtensions
                .GetEnumValuesCollection<TEnum>()
                .Select(p => new DropdownModel
                {
                    Id = (int)(object)p,
                    Name = p.ToString()
                }).ToList();
        }

        public async Task<IList<CheckboxModel>> GenerateSpeciesCheckboxesAsync(IEnumerable<int>? varietySpecies = null)
        {
            if (varietySpecies == null)
            {
                varietySpecies = new int[0];
            }

            var allSpecies = await _context.Species
                .AsNoTracking()
                .ToArrayAsync();

            return allSpecies
                .Select(s => new CheckboxModel
                {
                    Id = s.SpeciesId,
                    LabelName = s.ShortLatinName,
                    IsChecked = varietySpecies.Contains(s.SpeciesId)
                })
                .ToList();
        }
    }
}

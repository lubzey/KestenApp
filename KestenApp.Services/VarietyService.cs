namespace KestenApp.Services
{
    using Microsoft.EntityFrameworkCore;

    using KestenApp.Data;
    using KestenApp.Data.Enums;
    using KestenApp.Data.Models;
    using KestenApp.Services.Contracts;
    using KestenApp.Data.Enums.EnumHelpers;
    using KestenApp.Web.ViewModels;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using KestenApp.Web.ViewModels.Variety;

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
            SortingType sorting = SortingType.DateCreated,
            int currentPage = 1,
            int countPerPage = int.MaxValue,
            bool isPublished = true)
        {
            VarietyListModel varietiesPage = await AllVarietiesServiceModelAsync(currentPage: currentPage, isPublished: isPublished);

            return varietiesPage;
        }

        private async Task<VarietyListModel> AllVarietiesServiceModelAsync(
            string? name = null,
            SortingType sorting = SortingType.DateCreated,
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
                SortingType.Name => varietiesQuery.OrderByDescending(c => c.Name),
                SortingType.FruitSizes => varietiesQuery.OrderBy(c => c.FruitSizes).ThenBy(c => c.Name),
                SortingType.DateCreated or _ => varietiesQuery.OrderBy(c => c.DateCreated)
            };

            int totalCount = varietiesQuery.Count();

            IEnumerable<Variety> varieties = await varietiesQuery
                .AsNoTracking()
                .Skip((currentPage - 1) * countPerPage)
                .Take(countPerPage)
                .ToListAsync();

            return new VarietyListModel
            {
                TotalCount = totalCount,
                CurrentPage = currentPage,
                CountPerPage = countPerPage,
                Varieties = varieties.Select(v => ConstructVarietyModel(v)).ToList()
            };
        }

        private VarietySummaryModel ConstructVarietyModel(Variety v)
        {
            IEnumerable<string> species = v.Species
                .OrderBy(s => s.Species.ShortLatinName)
                .Select(s => s.Species.ShortLatinName)
                .ToList();

            IEnumerable<string> fruitSizes = v.FruitSizes
                .OrderBy(fs => fs.FruitSizeId)
                .Select(fs => fs.FruitSize.Name)
                .ToList();

            return new VarietySummaryModel
            {
                VarietyId = v.VarietyId,
                VarietyName = v.Name,

                //Tree
                Species = ServiceExtensions.JoinStrings(species),
                ChestnutBlightResistance = EnumExtensions.GetStringFromEnumValue(v.ChestnutBlightResistance),
                InkDiseaseResistance = EnumExtensions.GetStringFromEnumValue(v.InkDiseaseResistance),
                PollenFertility = EnumExtensions.GetStringFromEnumValue(v.PollenType),
                Vigor = EnumExtensions.GetStringFromEnumValue(v.Vigor),
                BuddingPeriod = EnumExtensions.GetStringFromEnumValue(v.BuddingPeriod),
                FloweringPeriod = EnumExtensions.GetStringFromEnumValue(v.FloweringPeriod),
                MaturityPeriod = EnumExtensions.GetStringFromEnumValue(v.MaturityPeriod),

                //Fruit
                FruitSizes = ServiceExtensions.JoinStrings(fruitSizes),
                IsMarron = ServiceExtensions.GetStringFromNullableBoolean(v.IsMarron),

                Peeling = EnumExtensions.GetStringFromEnumValue(v.Peeling),
                Conservation = EnumExtensions.GetStringFromEnumValue(v.Conservation),

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

            int[] varietyFruitSizeIds = variety
                .FruitSizes
                .Select(vs => vs.FruitSizeId)
                .ToArray();

            VarietyFormModel formModel = new VarietyFormModel
            {
                //Load dynamics
                FormTexts = new FormTextsModel("Variety", true),

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

                Crop = variety.Crop,
                CropVolumeOptions = GenerateCropVolumeOptions(),

                //Fruit
                FruitSizeCheckboxes = await GenerateFruitSizeCheckboxesAsync(varietyFruitSizeIds),

                IsMarron = variety.IsMarron,
                IsMarronOptions = GenerateBooleanOptions(),

                Peeling = variety.Peeling,
                PeelingOptions = GenerateConditionOptions(),

                Conservation = variety.Conservation,
                ConservationOptions = GenerateConditionOptions(),

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
                .AsNoTracking()
                .FirstAsync(p => p.VarietyId == id);

            return variety;
        }

        public async Task<Variety?> GetVarietyByNameAsync(string name)
        {
            Variety? variety = await _context
                .Varieties
                .AsNoTracking()
                .FirstOrDefaultAsync(p => p.Name.ToLower() == name);

            return variety;
        }


        //Search - Must have filters!!!
        public async Task<IEnumerable<Variety>> SearchVarietiesAsync(string searchQuery)
        {
            return await _context
                .Varieties
                .Where(p => p.Name.Contains(searchQuery))
                .AsNoTracking()
                .ToListAsync();
        }

        //Add
        public async Task<Guid> AddVarietyAsync(VarietyFormModel model)
        {
            int[] selectedSpeciesIds = model.SpeciesCheckboxes
                .Where(sp => sp.IsChecked)
                .Select(sp => sp.Id).ToArray();

            int[] selectedFruitSizeIds = model.FruitSizeCheckboxes
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
                MaturityPeriod = model.MaturityPeriod,
                IsMarron = model.IsMarron,
                Crop = model.Crop,

                FruitSizes = _context.FruitSizes
                    .Where(s => selectedFruitSizeIds.Contains(s.FruitSizeId))
                    .Select(s => new VarietyFruitSize
                    {
                        FruitSizeId = s.FruitSizeId,
                    })
                    .ToList(),
                Peeling = model.Peeling,
                Conservation = model.Conservation,

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
                .Include(v => v.FruitSizes)
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
            variety.IsMarron = model.IsMarron;
            variety.Crop = model.Crop;

            int[] selectedFruitSizeIds = model.FruitSizeCheckboxes
               .Where(sp => sp.IsChecked)
               .Select(sp => sp.Id).ToArray();
            variety.FruitSizes = _context.FruitSizes
                    .Where(s => selectedFruitSizeIds.Contains(s.FruitSizeId))
                    .Select(s => new VarietyFruitSize
                    {
                        FruitSizeId = s.FruitSizeId,
                    })
                    .ToList();
            variety.Peeling = model.Peeling;
            variety.Conservation = model.Conservation;

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

        public IEnumerable<BooleanDropdownModel> GenerateBooleanOptions()
        {
            return new List<BooleanDropdownModel>
            {
                new BooleanDropdownModel
                {
                    Value = null,
                    DisplayName = ""
                },
                new BooleanDropdownModel
                {
                    Value = true,
                    DisplayName = "Yes"
                },
                new BooleanDropdownModel
                {
                    Value = false,
                    DisplayName = "No"
                },
            };
        }

        public IEnumerable<DropdownModel> GenerateConditionOptions()
        {
            return ServiceExtensions.MapDropdown<ConditionType>();
        }

        public IEnumerable<DropdownModel> GeneratePollenOptions()
        {
            return ServiceExtensions.MapDropdown<PollenType>();
        }

        public IEnumerable<DropdownModel> GenerateVigorOptions()
        {
            return ServiceExtensions.MapDropdown<StrengthType>();
        }

        public IEnumerable<DropdownModel> GeneratePeriodOptions()
        {
            return ServiceExtensions.MapDropdown<PeriodType>();
        }

        public IEnumerable<DropdownModel> GenerateCropVolumeOptions()
        {
            return ServiceExtensions.MapDropdown<VolumeType>();
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

        public async Task<IList<CheckboxModel>> GenerateFruitSizeCheckboxesAsync(
            IEnumerable<int>? varietyFruitSizes = null)
        {
            if (varietyFruitSizes == null)
            {
                varietyFruitSizes = new int[0];
            }

            var allSpecies = await _context.FruitSizes
                .AsNoTracking()
                .ToArrayAsync();

            return allSpecies
                .Select(s => new CheckboxModel
                {
                    Id = s.FruitSizeId,
                    LabelName = s.Name,
                    IsChecked = varietyFruitSizes.Contains(s.FruitSizeId)
                })
                .ToList();
        }

        public async Task<IEnumerable<SelectListItem>> GenerateSpecimenVarietyOptionsAsync(Guid? varietyId = null)
        {
            IEnumerable<Variety> varieties = await _context.Varieties.AsNoTracking().ToListAsync();

            IEnumerable<SelectListItem> varietiesList = varieties
                .OrderBy(v => v.Name)
                .Select(v => new SelectListItem
                {
                    Value = v.VarietyId.ToString(),
                    Text = v.Name,
                    Selected = v.VarietyId == varietyId
                });

            List<SelectListItem> dropdownList = new List<SelectListItem>()
            {
                new SelectListItem { Selected = varietyId == null }
            };

            dropdownList.AddRange(varietiesList);

            return dropdownList;
        }
    }
}

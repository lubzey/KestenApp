using KestenTestApp.Contracts;
using KestenTestApp.Models.Data;
using KestenTestApp.Models.Database;
using KestenTestApp.Models.View;
using Microsoft.EntityFrameworkCore;

namespace KestenTestApp.Services
{
    public class VarietyService : IVarietyService
    {
        private readonly KestenDbContext _context;

        public VarietyService(KestenDbContext context)
        {
            _context = context;
        }

        //List varieties - add paging
        public IEnumerable<VarietyListDetailsViewModel> AllVarieties()
        {
            return _context
                .Varieties
                .Select(v => new VarietyListDetailsViewModel
                {
                    VarietyId = v.VarietyId,
                    VarietyName = v.VarietyName,
                    Species = JoinStrings(
                        v.Species
                            .OrderBy(s => s.ShortLatinName)
                            .Select(s => s.ShortLatinName)
                            .ToList()),
                    FruitSizes = JoinStrings(
                        v.FruitSizes
                            .OrderBy(fs => fs.FruitSizeId)
                            .Select(fs => fs.Name)),
                    IsMarron = GetStringFromNullableBoolean(v.IsMarron),
                    ChestnutBlightResistance = GetStringValueOfNullableEnum(v.ChestnutBlightResistance),
                    InkDiseaseResistance = GetStringValueOfNullableEnum(v.InkDiseaseResistance),
                    Peeling = GetStringValueOfNullableEnum(v.Peeling),
                    PollenFertility = GetStringValueOfNullableEnum(v.PollenType),
                    MaturityPeriod = GetStringValueOfNullableEnum(v.MaturityPeriod),
                    IsPollenizedBy = JoinStrings(
                        v.IsPollenizedBy
                            .Select(p => p.PollenizerVariety.VarietyName)
                            .OrderBy(n => n)),
                    IsPollenizerFor = JoinStrings(
                        v.IsPollenizerFor
                            .Select(p => p.PollenizerVariety.VarietyName)
                            .OrderBy(n => n)),
                    IsRootstockFor = JoinStrings(
                        v.IsRootstockFor
                            .Select(p => p.GraftedVariety.VarietyName)
                            .OrderBy(n => n)),
                    IsGraftedOn = JoinStrings(
                        v.IsGraftedOn
                            .Select(p => p.RootstockVariety.VarietyName)
                            .OrderBy(n => n))
                });
        }

        //Details
        public VarietyDetailsViewModel? GetDetailsViewById(int id)
        {
            Variety? variety = _context
                .Varieties
                //Include more data
                .Include(v => v.Images)
                .Include(v => v.Species)
                .Include(v => v.FruitSizes)
                .FirstOrDefault(p => p.VarietyId == id);

            if (variety == null)
            {
                return null;
            }

            //Species
            int[] varietySpecies = variety
                .Species
                .Select(vs => vs.SpeciesId)
                .ToArray() ?? new int[0];

            IReadOnlyList<CheckboxViewModel> speciesCheckboxes = _context
                .Species
                .Select(s => new CheckboxViewModel
                {
                    Id = s.SpeciesId,
                    LabelName = s.ShortLatinName,
                    IsChecked = varietySpecies.Contains(s.SpeciesId)
                }).ToArray().AsReadOnly();

            return new VarietyDetailsViewModel(variety, speciesCheckboxes);
        }


        //Search - Must have filters!!!
        public IEnumerable<Variety> SearchVarieties(string searchQuery)
        {
            return _context
                .Varieties
                .Where(p => p.VarietyName.Contains(searchQuery));
        }

        //Add
        public async Task<int> AddVarietyAsync(VarietyAddViewModel model)
        {
            int[] selectedSpeciesIds = model.Species
                .Where(sp => sp.IsChecked)
                .Select(sp => sp.Id).ToArray();

            Variety variety = new Variety
            {
                VarietyName = model.VarietyName,
                Species = _context.Species
                    .Where(s => selectedSpeciesIds.Contains(s.SpeciesId))
                    .ToList(),
                Description = model.Description,
                PollenType = model.PollenTypeSelected
            };

            await _context.Varieties.AddAsync(variety);
            await _context.SaveChangesAsync();

            return variety.VarietyId;
        }

        //Edit Variety
        public async Task EditVarietyAsync(VarietyAddViewModel model, int id)
        {
            var variety = await _context.Varieties.FindAsync(id);

            int[] selectedSpeciesIds = model.Species
                .Where(sp => sp.IsChecked)
                .Select(sp => sp.Id).ToArray();

            if (variety != null)
            {
                variety.VarietyName = model.VarietyName;
                variety.Description = model.Description;
                variety.Species = _context.Species
                    .Where(s => selectedSpeciesIds.Contains(s.SpeciesId))
                    .ToList();

                await _context.SaveChangesAsync();
            }
        }

        //Remove




        //Help methods
        private static string GetStringValueOfNullableEnum<T>(T enumValue)
        {
            if (enumValue == null)
            {
                return "";
            }

            return Enum.GetName(typeof(T), enumValue) ?? "";
        }

        private static string JoinStrings(IEnumerable<string> names)
        {
            string separator = $",{Environment.NewLine}";
            return string.Join(separator, names);
        }

        private static string GetStringFromNullableBoolean(bool? isMarron)
        {
            return isMarron != null
                ? (bool)isMarron
                    ? "\u2713"
                    : "\u2717"
                : "";
        }
    }
}

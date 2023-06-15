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
                    PollenFertility = GetStringValueOfNullableEnum(v.PollenFertility),
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
        public VarietyDetailsViewModel? GetVarietyById(int pieId)
        {
            Variety? variety = _context
                .Varieties
                //Include more data
                .Include(v => v.Images)
                .FirstOrDefault(p => p.VarietyId == pieId);

            if (variety == null)
            {
                return null;
            }

            return new VarietyDetailsViewModel(variety);
        }


        //Search - Must have filters!!!
        public IEnumerable<Variety> SearchVarieties(string searchQuery)
        {
            return _context
                .Varieties
                .Where(p => p.VarietyName.Contains(searchQuery));
        }

        //Edit Variety

        //Add
        public async Task<VarietyAddViewModel> GetNewAddVarietyModelAsync()
        {
            var species = await _context.Species
                .Select(c => new Species
                {
                    SpeciesId = c.SpeciesId,
                    ShortLatinName = c.ShortLatinName
                }).ToListAsync();

            var model = new VarietyAddViewModel
            {
                Species = species
            };

            return model;
        }

        //public async Task AddBookAsync(VarietyAdd model)
        //{
        //    Variety variety = new Variety
        //    {
        //        VarietyName = model.VarietyName,
        //        Species = model.Species,
        //        Description = model.Description
        //    };

        //    await _context.Varieties.AddAsync(variety);
        //    await _context.SaveChangesAsync();
        //}

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

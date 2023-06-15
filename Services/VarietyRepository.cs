using KestenTestApp.Contracts;
using KestenTestApp.Models.Data;
using KestenTestApp.Models.Database;
using KestenTestApp.Models.View;
using Microsoft.EntityFrameworkCore;

namespace KestenTestApp.Services
{
    public class VarietyRepository : IVarietyRepository
    {
        private readonly KestenDbContext _context;

        public VarietyRepository(KestenDbContext context)
        {
            _context = context;
        }

        public IEnumerable<VarietyListDetailsViewModel> AllVarieties
        {
            get
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
        }

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

        public IEnumerable<Variety> SearchVarieties(string searchQuery)
        {
            return _context
                .Varieties
                .Where(p => p.VarietyName.Contains(searchQuery));
        }

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

using Kesten.Api.Data;
using Kesten.Api.Data.Models;
using Kesten.Shared.Enums;
using Kesten.Shared.Enums.EnumHelpers;
using Kesten.Shared.Models;
using Kesten.Shared.Extensions;
using Microsoft.EntityFrameworkCore;

namespace Kesten.Api.Services
{
    public class VarietyRepository : IVarietyRepository
    {
        private readonly KestenDbContext _context;

        public VarietyRepository(KestenDbContext context)
        {
            _context = context;
        }

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

                .Include(v => v.IsPollenizedBy.Where(v => v.PollenizerVariety.IsPublished == true))
                    .ThenInclude(v => v.PollenizerVariety)
                .Include(v => v.IsPollenizerFor.Where(v => v.TargetVariety.IsPublished == true))
                    .ThenInclude(v => v.TargetVariety)

                .Include(v => v.IsGraftedOn.Where(v => v.RootstockVariety.IsPublished == true))
                    .ThenInclude(v => v.RootstockVariety)
                .Include(v => v.IsRootstockFor.Where(v => v.GraftedVariety.IsPublished == true))
                    .ThenInclude(v => v.GraftedVariety)

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
    }
}

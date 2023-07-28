namespace KestenApp.Services
{
    using Microsoft.EntityFrameworkCore;

    using KestenApp.Data;
    using KestenApp.Data.Enums;
    using KestenApp.Data.Models;
    using KestenApp.Services.Contracts;
    using KestenApp.Web.ViewModels.Specimen;

    public class SpecimenService : ISpecimenService
    {
        private readonly KestenDbContext _context;

        public SpecimenService(KestenDbContext context)
        {
            _context = context;
        }

        public async Task<SpecimenListModel> AllSpecimenAsync(
            VarietySortingType sorting = VarietySortingType.DateCreated,
            int currentPage = 1,
            int countPerPage = int.MaxValue,
            bool isPublished = true)
        {
            IQueryable<Specimen> specimensQuery = _context
                .Specimens
                .Include(v => v.Garden)
                .Include(v => v.Variety)
                .Include(v => v.User)
                .Where(v => v.Garden == null || v.Garden.IsPublished == isPublished);

            specimensQuery = sorting switch
            {
                VarietySortingType.VarietyName => specimensQuery.OrderByDescending(c => c.Name),
                VarietySortingType.DateCreated or _ => specimensQuery.OrderBy(c => c.DateCreated)
            };

            int totalCount = specimensQuery.Count();

            IEnumerable<Specimen> specimens = await specimensQuery
                .Skip((currentPage - 1) * countPerPage)
                .Take(countPerPage)
                .ToListAsync();

            return new SpecimenListModel
            {
                TotalCount = totalCount,
                CurrentPage = currentPage,
                CountPerPage = countPerPage,
                Specimens = specimens.Select(v => ConstructSpecimenModel(v)).ToList()
            };
        }

        private static SpecimenSummaryModel ConstructSpecimenModel(Specimen v)
        {
            return new SpecimenSummaryModel
            {
                SpecimenId = v.SpecimenId,
                SpecimenName = v.Name,
                Year = v.PlantedOnDate != null 
                    ? v.PlantedOnDate.Value.Year 
                    : v.SowedOnDate != null
                        ? v.SowedOnDate.Value.Year
                        : null,
                Garden = v.Garden,
                Variety = v.Variety,
                User = v.User
            };
        }
    }
}

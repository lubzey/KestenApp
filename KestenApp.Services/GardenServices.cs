namespace KestenApp.Services
{
    using Microsoft.EntityFrameworkCore;

    using KestenApp.Data;
    using KestenApp.Data.Enums;
    using KestenApp.Data.Models;
    using KestenApp.Services.Contracts;
    using KestenApp.Web.ViewModels.Garden;

    public class GardenServices : IGardenServices
    {
        private readonly KestenDbContext _context;

        public GardenServices(KestenDbContext context)
        {
            _context = context;
        }

        public async Task<GardenListModel> AllGardensAsync(
            SortingType sorting = SortingType.DateCreated,
            int currentPage = 1,
            int countPerPage = int.MaxValue,
            bool isPublished = true)
        {
            IQueryable<Garden> specimensQuery = _context
                .Gardens
                .Include(g => g.Specimens)
                .Include(g => g.User)
                .Where(g => g.IsPublished == isPublished);

            specimensQuery = sorting switch
            {
                SortingType.Name => specimensQuery.OrderByDescending(c => c.Name),
                SortingType.DateCreated or _ => specimensQuery.OrderBy(c => c.DateCreated)
            };

            int totalCount = specimensQuery.Count();

            IEnumerable<Garden> gardens = await specimensQuery
                .Skip((currentPage - 1) * countPerPage)
                .Take(countPerPage)
                .ToListAsync();

            return new GardenListModel
            {
                TotalCount = totalCount,
                CurrentPage = currentPage,
                CountPerPage = countPerPage,
                Gardens = gardens.Select(v => ConstructGardenModel(v)).ToList()
            };
        }

        private static GardenSummaryModel ConstructGardenModel(Garden g)
        {
            return new GardenSummaryModel
            {
                Garden = g,
                Specimens = g.Specimens,
                User = g.User
            };
        }
    }
}

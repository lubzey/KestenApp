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
                    .ThenInclude(s => s.Variety)
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

        private GardenSummaryModel ConstructGardenModel(Garden g)
        {
            return new GardenSummaryModel
            {
                Garden = g,
                Specimens = g.Specimens,
                User = g.User
            };
        }

        public async Task<GardenDetailsModel> GetDetailsViewByIdAsync(Guid id)
        {
            Garden garden = await _context
                .Gardens
                .Include(g => g.Specimens.Where(s => s.IsActive))
                    .ThenInclude(s => s.Variety)
                .Include(g => g.User)
                .Where(g => g.IsPublished && g.GardenId == id)
                .AsNoTracking()
                .FirstAsync();

            return new GardenDetailsModel
            {
                GardenName = garden.Name,
                GardenId = garden.GardenId,
                UserName = garden.User.UserName,
                UserId = garden.User.Id,
                IsActive = garden.IsActive,
                IsPublished = garden.IsPublished,
                YearVarieties = garden.Specimens
                    .GroupBy(s => new { s.Year, s.Variety?.Name })
                    .Select(g => new YearSpecimens
                    {
                        Year = g.Key.Year,
                        VarietyName = g.Key.Name ?? "",
                        Count = g.Count()
                    }).ToList()
            };
        }
    }
}

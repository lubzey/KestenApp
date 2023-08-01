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
                    .ThenInclude(s => s.SpecimenPosition)
                .Include(g => g.Specimens.Where(s => s.IsActive))
                    .ThenInclude(s => s.Variety)
                .Include(g => g.User)
                .Where(g => g.IsPublished && g.GardenId == id)
                .AsNoTracking()
                .FirstAsync();

            int rows = garden.TotalRows != null && garden.TotalRows > 0
                ? (int)garden.TotalRows
                : garden.Specimens.Any(s => s.SpecimenPosition != null)
                    ? garden.Specimens.Where(s => s.SpecimenPosition != null).Select(s => s.SpecimenPosition).Max(sp => sp?.Row ?? 0)
                    : 0;

            int cols = garden.TotalColumns != null && garden.TotalColumns > 0
                ? (int)garden.TotalColumns
                : garden.Specimens.Any(s => s.SpecimenPosition != null)
                    ? garden.Specimens.Where(s => s.SpecimenPosition != null).Select(s => s.SpecimenPosition).Max(sp => sp?.Column ?? 0)
                    : 0;

            //List<GardenDetailsSchemaModel> specimens = garden.Specimens
            //    .Select(specimen => new GardenDetailsSchemaModel
            //    {
            //        Name = specimen.Variety != null
            //            ? specimen.Variety.Name
            //            : specimen.Name,
            //        Year = specimen.Year,
            //        Row = specimen.SpecimenPosition?.Row,
            //        Column = specimen.SpecimenPosition?.Column,
            //        SpecimenId = specimen.SpecimenId,
            //        PollenType = GetBackgroundColorByPollen(specimen.Variety?.PollenType)
            //    }).ToList();

            GardenDetailsSchemaModel[,] specimensSchema = new GardenDetailsSchemaModel[(int)rows, (int)cols];

            garden.Specimens
                //.Where(sp => sp.SpecimenPosition != null)
                .ToList()
                .ForEach(sp =>
                {
                    if (sp.SpecimenPosition == null)
                    {
                        return;
                    }

                    specimensSchema[sp.SpecimenPosition.Row - 1, sp.SpecimenPosition.Column - 1] = new GardenDetailsSchemaModel
                    {
                        Name = sp.Variety != null
                        ? sp.Variety.Name
                        : sp.Name,
                        Year = sp.Year,
                        SpecimenId = sp.SpecimenId,
                        BackgroundColor = GetBackgroundColorByPollen(sp.Variety?.PollenType)

                    };
                });


            return new GardenDetailsModel
            {
                GardenName = garden.Name,
                GardenId = garden.GardenId,
                UserName = garden.User.UserName,
                UserId = garden.User.Id,
                IsActive = garden.IsActive,
                IsPublished = garden.IsPublished,
                TotalRows = rows,
                TotalColumns = cols,
                YearVarieties = garden.Specimens
                    .GroupBy(s => new { s.Year, s.Variety?.Name })
                    .Select(g => new GardenDetailsYearSpecimens
                    {
                        Year = g.Key.Year,
                        VarietyName = g.Key.Name ?? "",
                        Count = g.Count()
                    }).ToList(),
                Specimens = specimensSchema
            };
        }

        private string GetBackgroundColorByPollen(PollenType? pollenType)
        {
            switch (pollenType)
            {
                case PollenType.NotSelected:
                    return "";

                case PollenType.Sterile:
                case null:
                    return "table-danger";

                case PollenType.Medium:
                    return "table-warning";

                case PollenType.Abundant:
                    return "table-success";

                default:
                    return "";
            }
        }
    }
}

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

        public async Task<SpecimenListModel> AllSpecimensAsync(
            SortingType sorting = SortingType.DateCreated,
            int currentPage = 1,
            int countPerPage = int.MaxValue,
            bool isPublished = true)
        {
            IQueryable<Specimen> specimensQuery = _context
                .Specimens
                .Include(s => s.Garden)
                .Include(s => s.Variety)
                .Include(s => s.User)
                .Where(s => s.IsActive);

            specimensQuery = sorting switch
            {
                SortingType.Name => specimensQuery.OrderByDescending(c => c.Name),
                SortingType.DateCreated or _ => specimensQuery.OrderBy(c => c.DateCreated)
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

        private SpecimenSummaryModel ConstructSpecimenModel(Specimen v)
        {
            return new SpecimenSummaryModel
            {
                SpecimenId = v.SpecimenId,
                SpecimenName = v.Name,
                Year = v.Year,
                Garden = v.Garden,
                Variety = v.Variety,
                User = v.User
            };
        }

        public async Task<SpecimenDetailsModel> GetDetailsViewByIdAsync(Guid id)
        {
            Specimen specimen = await _context
                .Specimens
                .Include(s => s.Garden)
                .Include(s => s.Variety)
                .AsNoTracking()
                .FirstAsync(s => s.SpecimenId == id);

            return new SpecimenDetailsModel(specimen);
        }

        public async Task ArchiveByIdAsync(Guid id, bool restore = false)
        {
            Specimen specimen = await this._context
                .Specimens
                .FirstAsync(h => h.SpecimenId == id);

            if (restore)
            {
                specimen.IsActive = true;
            }
            else
            {
                specimen.IsActive = false;
            }

            await this._context.SaveChangesAsync();
        }

        //Add
        public async Task<Guid> AddSpecimenAsync(DetailsFormModel model, Guid userId)
        {
            //var user = await _context.Users.SingleAsync(u => u.Id == userId);

            Specimen specimen = new Specimen
            {
                UserId = userId,
                VarietyId = model.VarietyId,

                GardenId = model.GardenId,                
                Row = model.Row,
                Column = model.Column,
                Name = model.SpecimenName,                
                Elevation = model.Elevation,
                PlantedOnDate = model.PlantedOnDate,
                SowedOnDate = model.SowedOnDate,
                GraftedOnDate = model.GraftedOnDate
            };

            await _context.Specimens.AddAsync(specimen);
            await _context.SaveChangesAsync();

            return specimen.SpecimenId;
        }
    }
}

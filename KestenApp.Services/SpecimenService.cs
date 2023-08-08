namespace KestenApp.Services
{
    using Microsoft.EntityFrameworkCore;

    using KestenApp.Data;
    using KestenApp.Data.Enums;
    using KestenApp.Data.Models;
    using KestenApp.Services.Contracts;
    using KestenApp.Web.ViewModels.Specimen;
    using KestenApp.Web.ViewModels.Varieties;
    using Microsoft.EntityFrameworkCore.Metadata.Internal;

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
                .Include(v => v.Garden)
                .Include(v => v.Variety)
                .Include(v => v.User)
                .Where(v => v.Garden == null || v.Garden.IsPublished == isPublished);

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
        public async Task<Guid> AddSpecimenAsync(SpecimenFormModel model)
        {
            Specimen specimen = new Specimen
            {
                Name = model.SpecimenName,
                Garden = (Garden)model.SelectedGarden!,
                Elevation = model.Elevation,
                //UserId = model.
            };

            await _context.Specimens.AddAsync(specimen);
            await _context.SaveChangesAsync();
            return specimen.SpecimenId;
        }
    }
}

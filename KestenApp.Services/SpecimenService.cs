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
            string userId,
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
                .Where(s => s.IsActive && s.UserId.ToString() == userId);

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
                Specimens = specimens
                    .Select(s => ConstructSpecimenModel(s)).ToList()
            };
        }

        public async Task<IEnumerable<SpecimenSummaryModel>> GetSpecimensOutOfRange(Guid gardenId, int row, int column)
        {
            IEnumerable<Specimen> specimensRaw = await _context.Specimens
                .Where(s => s.GardenId == gardenId
                    && s.IsActive
                    && (s.Column > column || s.Row > row))
                    .Include(s => s.Garden)
                .AsNoTracking()
                .ToArrayAsync();

            List<SpecimenSummaryModel> specimensModel = specimensRaw
                .Select(s => ConstructSpecimenModel(s)).ToList();

            return specimensModel;
        }

        private SpecimenSummaryModel ConstructSpecimenModel(Specimen s)
        {
            return new SpecimenSummaryModel
            {
                SpecimenId = s.SpecimenId,
                SpecimenName = s.Name,
                Year = s.Year,
                Garden = s.Garden,
                Row = s.Row,
                Column = s.Column,
                Variety = s.Variety
            };
        }

        public async Task<SpecimenDetailsModel> GetDetailsViewByIdAsync(Guid id, string userId)
        {
            Specimen? specimen = await _context
                .Specimens
                .Include(s => s.Garden)
                .Include(s => s.Variety)
                .AsNoTracking()
                .FirstOrDefaultAsync(s => s.SpecimenId == id && s.UserId.ToString() == userId);

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

        public async Task ArchiveByIdsAsync(IEnumerable<string> ids)
        {
            List<Specimen> specimens = await this._context
                .Specimens
                .Where(s => ids.Contains(s.SpecimenId.ToString()))
                .ToListAsync();

            specimens.ForEach(s => s.IsActive = false);

            //_context.UpdateRange(specimens);
            await this._context.SaveChangesAsync();
        }

        //Add
        public async Task<Guid> AddSpecimenAsync(DetailsFormModel model, Guid userId)
        {
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

        public async Task<bool> UpdateSpecimenAsync(Guid id, DetailsFormModel model)
        {
            Specimen specimen = await _context
                .Specimens
                .FirstAsync(h => h.SpecimenId == id);

            specimen.Name = model.SpecimenName;
            specimen.VarietyId = model.VarietyId;
            specimen.Elevation = model.Elevation;
            specimen.PlantedOnDate = model.PlantedOnDate;
            specimen.SowedOnDate = model.SowedOnDate;
            specimen.GraftedOnDate = model.GraftedOnDate;

            return await this._context.SaveChangesAsync() > 0;
        }
    }
}

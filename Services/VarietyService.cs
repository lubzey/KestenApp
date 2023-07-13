using KestenApp.Contracts;
using KestenApp.Data;
using KestenApp.Data.Models;
using KestenApp.Infrastructure.Enums;
using KestenApp.Models.Varieties;
using Microsoft.EntityFrameworkCore;

namespace KestenApp.Services
{
    public class VarietyService : IVarietyService
    {
        private readonly KestenDbContext _context;

        public VarietyService(KestenDbContext context)
        {
            _context = context;
        }

        //List varieties - add paging
        public VarietyServiceModel AllVarieties(
            string? name = null,
            VarietySorting sorting = VarietySorting.DateCreated,
            int currentPage = 1,
            int countPerPage = int.MaxValue)
        {
            IQueryable<Variety> varietiesQuery = _context
                .Varieties
                .Include(v => v.Species)
                .Include(v => v.FruitSizes);

            if (!string.IsNullOrWhiteSpace(name))
            {
                varietiesQuery = varietiesQuery
                    .Where(c => c.VarietyName.ToLower().Contains(name.ToLower()));
            }

            varietiesQuery = sorting switch
            {
                VarietySorting.VarietyName => varietiesQuery.OrderByDescending(c => c.VarietyName),
                VarietySorting.FruitSizes => varietiesQuery.OrderBy(c => c.FruitSizes).ThenBy(c => c.VarietyName),
                VarietySorting.DateCreated or _ => varietiesQuery.OrderByDescending(c => c.DateCreated)
            };

            int totalCount = varietiesQuery.Count();

            IEnumerable<Variety> varieties = varietiesQuery
                .Skip((currentPage - 1) * countPerPage)
                .Take(countPerPage)
                .ToList();

            return new VarietyServiceModel
            {
                TotalCount = totalCount,
                CurrentPage = currentPage,
                CountPerPage = countPerPage,
                Varieties = varieties
            };
        }

        //Details
        public Variety? GetDetailsViewById(int id)
        {
            Variety? variety = _context
                .Varieties
                //Include more data
                .Include(v => v.Images)
                .Include(v => v.Species)
                .Include(v => v.FruitSizes)
                .FirstOrDefault(p => p.VarietyId == id);

            return variety;
        }

        public Variety? GetVarietyByName(string name)
        {
            Variety? variety = _context
                .Varieties
                .FirstOrDefault(p => p.VarietyName.ToLower() == name);

            return variety;
        }


        //Search - Must have filters!!!
        public IEnumerable<Variety> SearchVarieties(string searchQuery)
        {
            return _context
                .Varieties
                .Where(p => p.VarietyName.Contains(searchQuery));
        }

        //Add
        public async Task<int> AddVarietyAsync(VarietyFormModel model)
        {
            int[] selectedSpeciesIds = model.SpeciesCheckboxes
                .Where(sp => sp.IsChecked)
                .Select(sp => sp.Id).ToArray();

            Variety variety = new Variety
            {
                VarietyName = model.VarietyName,
                Species = _context.Species
                    .Where(s => selectedSpeciesIds.Contains(s.SpeciesId))
                    .ToList(),
                Description = model.Description,
                PollenType = model.PollenType
            };

            await _context.Varieties.AddAsync(variety);
            await _context.SaveChangesAsync();

            return variety.VarietyId;
        }

        //Update
        public async Task<int?> UpdateVarietyAsync(int id, VarietyFormModel model)
        {
            var variety = await _context.Varieties
                .Where(v => v.VarietyId == id)
                .Include(v => v.Species)
                .FirstOrDefaultAsync();

            if (variety == null)
            {
                return null;
            }

            variety.VarietyName = model.VarietyName;
            variety.Description = model.Description;

            int[] selectedSpeciesIds = model.SpeciesCheckboxes
                .Where(sp => sp.IsChecked)
                .Select(sp => sp.Id).ToArray();
            variety.Species = _context.Species
                .Where(s => selectedSpeciesIds.Contains(s.SpeciesId))
                .ToList();

            variety.PollenType = model.PollenType;

            await _context.SaveChangesAsync();

            return id;
        }

        //Remove





    }
}

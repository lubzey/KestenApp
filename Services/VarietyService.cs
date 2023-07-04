using KestenApp.Contracts;
using KestenApp.Data;
using KestenApp.Data.Models;
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
        public IQueryable<Variety> AllVarieties()
        {
            return _context
                .Varieties
                .Include(v => v.Species)
                .Include(v => v.FruitSizes)
                .Include(v => v.IsGraftedOn)
                .Include(v => v.IsRootstockFor)
                .Include(v => v.IsPollenizedBy)
                .Include(v => v.IsPollenizerFor);
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

using KestenTestApp.Models.Database;
using Microsoft.EntityFrameworkCore;

namespace KestenTestApp.Models.Repositories
{
    public class VarietyRepository : IVarietyRepository
    {
        private readonly KestenDbContext _context;

        public VarietyRepository(KestenDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Variety> AllVarieties
        {
            get
            {
                return _context
                    .Varieties
                    .Include(v => v.Species)
                    .Include(v => v.FruitSizes)
                    .ToList();
            }
        }

        public Variety? GetVarietyById(int pieId)
        {
            return _context.Varieties
                .FirstOrDefault(p => p.VarietyId == pieId);
        }

        public IEnumerable<Variety> SearchVarieties(string searchQuery)
        {
            return _context
                .Varieties
                .Where(p => p.VarietyName.Contains(searchQuery));
        }
    }
}

using KestenTestApp.Models.Database;

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
                return _context.Varieties;
            }
        }

        public Variety? GetPieById(int pieId)
        {
            return _context.Varieties
                .FirstOrDefault(p => p.VarietyId == pieId);
        }

        public IEnumerable<Variety> SearchPies(string searchQuery)
        {
            throw new NotImplementedException();
        }
    }
}

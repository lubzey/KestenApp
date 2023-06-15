using KestenTestApp.Contracts;
using KestenTestApp.Models.Data;
using KestenTestApp.Models.Database;

namespace KestenTestApp.Services
{
    public class SpeciesService : ISpeciesService
    {
        private readonly KestenDbContext _context;

        public SpeciesService(KestenDbContext context)
        {
            _context = context;
        }

        //List varieties - add paging
        public IEnumerable<Species> AllSpecies()
        {
            return _context
                .Species
                .ToList();
        }
    }
}

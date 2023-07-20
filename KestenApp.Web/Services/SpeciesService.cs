using KestenApp.Contracts;
using KestenApp.Data;
using KestenApp.Data.Models;

namespace KestenApp.Services
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

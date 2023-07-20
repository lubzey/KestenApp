namespace KestenApp.Services
{
    using KestenApp.Data;
    using KestenApp.Data.Models;

    public class SpeciesService
    {
        private readonly KestenDbContext dbContext;

        public SpeciesService(KestenDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<Species> AllSpecies()
        {
            return dbContext
                .Species
                .ToList();
        }
    }
}
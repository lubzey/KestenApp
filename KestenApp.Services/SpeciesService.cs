namespace KestenApp.Services
{
    using KestenApp.Data;
    using KestenApp.Data.Models;
    using KestenApp.Services.Contracts;
    using Microsoft.EntityFrameworkCore;

    public class SpeciesService : ISpeciesService
    {
        private readonly KestenDbContext dbContext;

        public SpeciesService(KestenDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<Species>> AllSpecies()
        {
            return await this.dbContext
                .Species
                .ToArrayAsync();
        }
    }
}
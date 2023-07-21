using KestenApp.Data.Models;

namespace KestenApp.Services.Contracts
{
    public interface ISpeciesService
    {
        Task<IEnumerable<Species>> AllSpecies();
    }
}
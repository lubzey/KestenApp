using KestenApp.Data.Models;

namespace KestenApp.Services.Contracts
{
    public interface ISpeciesService
    {
        IEnumerable<Species> AllSpecies();
    }
}
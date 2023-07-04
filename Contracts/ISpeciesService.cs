using KestenApp.Data.Models;

namespace KestenApp.Contracts
{
    public interface ISpeciesService
    {
        IEnumerable<Species> AllSpecies();
    }
}
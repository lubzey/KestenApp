using KestenTestApp.Models.Data;

namespace KestenTestApp.Contracts
{
    public interface ISpeciesService
    {
        IEnumerable<Species> AllSpecies();
    }
}
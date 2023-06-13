using KestenTestApp.Models.Data;

namespace KestenTestApp.Models.Repositories
{
    public interface IVarietyRepository
    {
        IEnumerable<Variety> AllVarieties { get; }

        Variety? GetVarietyById(int pieId);
        IEnumerable<Variety> SearchVarieties(string searchQuery);
    }
}
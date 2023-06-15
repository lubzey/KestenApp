using KestenTestApp.Models.Data;
using KestenTestApp.Models.View;

namespace KestenTestApp.Contracts
{
    public interface IVarietyRepository
    {
        IEnumerable<VarietyListDetailsViewModel> AllVarieties { get; }

        VarietyDetailsViewModel? GetVarietyById(int pieId);
        IEnumerable<Variety> SearchVarieties(string searchQuery);
    }
}
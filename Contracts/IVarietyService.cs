using KestenTestApp.Models.Data;
using KestenTestApp.Models.View;

namespace KestenTestApp.Contracts
{
    public interface IVarietyService
    {
        Task<int> AddVarietyAsync(VarietyAddViewModel model);
        IEnumerable<VarietyListDetailsViewModel> AllVarieties();
        VarietyDetailsViewModel? GetVarietyById(int pieId);
        IEnumerable<Variety> SearchVarieties(string searchQuery);
    }
}
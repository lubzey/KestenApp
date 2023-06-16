using KestenTestApp.Models.Data;
using KestenTestApp.Models.View;

namespace KestenTestApp.Contracts
{
    public interface IVarietyService
    {
        IEnumerable<VarietyListDetailsViewModel> AllVarieties();
        VarietyDetailsViewModel? GetDetailsViewById(int id);
        IEnumerable<Variety> SearchVarieties(string searchQuery);
        Task<int> AddVarietyAsync(VarietyAddViewModel model);
        Task EditVarietyAsync(VarietyAddViewModel model, int id);
    }
}
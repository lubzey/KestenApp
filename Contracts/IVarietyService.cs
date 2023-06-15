using KestenTestApp.Models.Data;
using KestenTestApp.Models.View;

namespace KestenTestApp.Contracts
{
    public interface IVarietyService
    {
        IEnumerable<VarietyListDetailsViewModel> AllVarieties();
        Task<VarietyAddViewModel> GetNewAddVarietyModelAsync();
        VarietyDetailsViewModel? GetVarietyById(int pieId);
        IEnumerable<Variety> SearchVarieties(string searchQuery);
    }
}
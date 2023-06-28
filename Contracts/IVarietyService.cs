using KestenTestApp.Models.Data;
using KestenTestApp.Models.View;

namespace KestenTestApp.Contracts
{
    public interface IVarietyService
    {
        IEnumerable<Variety> AllVarieties();
        Variety? GetDetailsViewById(int id);
        IEnumerable<Variety> SearchVarieties(string searchQuery);
        Task<int> AddVarietyAsync(VarietyAddOrEditViewModel model);
        Task<int?> UpdateVarietyAsync(int id, VarietyAddOrEditViewModel model);
    }
}
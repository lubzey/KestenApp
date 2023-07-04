using KestenApp.Data.Models;
using KestenApp.Models.Varieties;

namespace KestenApp.Contracts
{
    public interface IVarietyService
    {
        IQueryable<Variety> AllVarieties();
        Variety? GetDetailsViewById(int id);
        IEnumerable<Variety> SearchVarieties(string searchQuery);
        Task<int> AddVarietyAsync(VarietyAddOrEditViewModel model);
        Task<int?> UpdateVarietyAsync(int id, VarietyAddOrEditViewModel model);
    }
}
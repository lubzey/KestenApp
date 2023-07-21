using KestenApp.Data.Enums;
using KestenApp.Data.Models;
using KestenApp.Web.Models.Varieties;

namespace KestenApp.Services.Contracts
{
    public interface IVarietyService
    {
        Task<VarietyListModel> AllVarietiesAsync(string? name = null, VarietySorting sorting = VarietySorting.DateCreated, int currentPage = 1, int countPerPage = int.MaxValue);
        Task<Variety?> GetDetailsViewByIdAsync(Guid id);
        Task<Variety?> GetVarietyByNameAsync(string name);
        Task<IEnumerable<Variety>> SearchVarietiesAsync(string searchQuery);
        Task<Guid> AddVarietyAsync(VarietyFormModel model);
        Task<Guid?> UpdateVarietyAsync(Guid id, VarietyFormModel model);
        
    }
}
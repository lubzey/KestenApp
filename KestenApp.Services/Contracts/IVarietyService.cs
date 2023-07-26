using KestenApp.Data.Enums;
using KestenApp.Data.Models;
using KestenApp.Web.ViewModels.Varieties;

namespace KestenApp.Services.Contracts
{
    public interface IVarietyService
    {
        Task<VarietyListModel> AllVarietiesAsync(string? name = null, VarietySortingType sorting = VarietySortingType.DateCreated, int currentPage = 1, int countPerPage = int.MaxValue, bool isActive = true);
        Task<Variety?> GetDetailsViewByIdAsync(Guid id);
        Task<Variety?> GetVarietyByNameAsync(string name);
        Task<IEnumerable<Variety>> SearchVarietiesAsync(string searchQuery);
        Task<Guid> AddVarietyAsync(VarietyFormModel model);
        Task<Guid?> UpdateVarietyAsync(Guid id, VarietyFormModel model);
        Task PublishVarietyAsync(Guid id, bool unpublish = false);
        Task ArchiveByIdAsync(Guid varietyId, bool restore = false);
    }
}
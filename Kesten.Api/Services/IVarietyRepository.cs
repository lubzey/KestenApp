using Kesten.Shared.Enums;
using Kesten.Shared.Models;

namespace Kesten.Api.Services
{
    public interface IVarietyRepository
    {
        Task<VarietyListModel> AllVarietiesAsync(string? name = null, SortingType sorting = SortingType.DateCreated, int currentPage = 1, int countPerPage = int.MaxValue, bool isPublished = true);
    }
}

using KestenApp.Data.Enums;
using KestenApp.Web.ViewModels.Garden;

namespace KestenApp.Services.Contracts
{
    public interface IGardenServices
    {
        Task<GardenListModel> AllGardensAsync(SortingType sorting = SortingType.DateCreated, int currentPage = 1, int countPerPage = int.MaxValue, bool isPublished = true);
        Task<GardenDetailsModel> GetDetailsViewByIdAsync(Guid id);
    }
}
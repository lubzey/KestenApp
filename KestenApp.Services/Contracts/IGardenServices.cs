namespace KestenApp.Services.Contracts
{
    using Microsoft.AspNetCore.Mvc.Rendering;

    using KestenApp.Data.Enums;
    using KestenApp.Web.ViewModels.Garden;

    public interface IGardenServices
    {
        Task<GardenListModel> AllGardensAsync(SortingType sorting = SortingType.DateCreated, int currentPage = 1, int countPerPage = int.MaxValue, bool isPublished = true);
        Task<GardenDetailsModel> GetDetailsViewByIdAsync(Guid id);
        Task<GardenDetailsModel> GetGardenWithUsedPositionsAsync(Guid gardenId);
        Task<IEnumerable<SelectListItem>> GetUserGardensAsync(string userId);
        Task<bool> IsPositionTakenAsync(Guid gardenId, int row, int column);
        Task<bool> IsPositionValidAsync(Guid gardenId, int row, int column);
        Task<bool> IsUserGardenValidAsync(Guid gardenId, string userId);
    }
}
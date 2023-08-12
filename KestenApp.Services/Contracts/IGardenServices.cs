namespace KestenApp.Services.Contracts
{
    using Microsoft.AspNetCore.Mvc.Rendering;

    using KestenApp.Data.Enums;
    using KestenApp.Web.ViewModels.Garden;

    public interface IGardenServices
    {
        Task<GardenListModel> AllGardensAsync(SortingType sorting = SortingType.DateCreated, int currentPage = 1, int countPerPage = int.MaxValue, bool isPublished = true);
        Task ArchiveByIdAsync(Guid id, bool restore = false);
        Task<Guid> CreateGardenAsync(string userId, FormModel model);
        Task<GardenDetailsModel> GetDetailsViewByIdAsync(Guid id, string userId);
        Task<GardenDetailsModel> GetGardenWithUsedPositionsAsync(Guid gardenId);
        Task<IEnumerable<SelectListItem>> GetUserGardensAsync(string userId);
        Task<bool> IsPositionTakenAsync(Guid gardenId, int row, int column);
        Task<bool> IsPositionValidAsync(Guid gardenId, int row, int column);
        Task<bool> IsUserGardenValidAsync(Guid gardenId, string userId);
        Task<bool> UpdateGardenAsync(Guid id, string userId, FormModel model);
    }
}
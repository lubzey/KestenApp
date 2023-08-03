using KestenApp.Data.Enums;
using KestenApp.Data.Models;
using KestenApp.Web.ViewModels.Garden;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace KestenApp.Services.Contracts
{
    public interface IGardenServices
    {
        Task<GardenListModel> AllGardensAsync(SortingType sorting = SortingType.DateCreated, int currentPage = 1, int countPerPage = int.MaxValue, bool isPublished = true);
        Task<IEnumerable<SelectListItem>> GenerateSpecimenGardenOptionsAsync(string userId, Guid? gardenId = null);
        Task<GardenDetailsModel> GetDetailsViewByIdAsync(Guid id);
        Task<IEnumerable<Garden>> GetUserGardensAsync(Guid userId);
        Task<bool> IsPositionTakenAsync(Guid gardenId, int row, int column);
    }
}
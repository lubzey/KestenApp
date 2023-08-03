using KestenApp.Data.Enums;
using KestenApp.Data.Models;
using KestenApp.Web.ViewModels.Specimen;

namespace KestenApp.Services.Contracts
{
    public interface ISpecimenService
    {
        Task<Guid> AddSpecimenAsync(SpecimenFormModel model);
        Task<SpecimenListModel> AllSpecimensAsync(SortingType sorting = SortingType.DateCreated, int currentPage = 1, int countPerPage = int.MaxValue, bool isPublished = true);
        Task ArchiveByIdAsync(Guid id, bool restore = false);
        Task<SpecimenDetailsModel> GetDetailsViewByIdAsync(Guid id);
    }
}
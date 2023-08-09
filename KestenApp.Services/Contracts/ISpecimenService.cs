namespace KestenApp.Services.Contracts
{
    using KestenApp.Data.Enums;
    using KestenApp.Web.ViewModels.Specimen;

    public interface ISpecimenService
    {
        Task<Guid> AddSpecimenAsync(DetailsFormModel model, Guid userId);
        Task<SpecimenListModel> AllSpecimensAsync(SortingType sorting = SortingType.DateCreated, int currentPage = 1, int countPerPage = int.MaxValue, bool isPublished = true);
        Task ArchiveByIdAsync(Guid id, bool restore = false);
        Task<SpecimenDetailsModel> GetDetailsViewByIdAsync(Guid id);
    }
}
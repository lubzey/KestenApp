namespace KestenApp.Services.Contracts
{
    using System.Collections.Generic;

    using KestenApp.Data.Enums;
    using KestenApp.Web.ViewModels.Specimen;

    public interface ISpecimenService
    {
        Task<Guid> AddSpecimenAsync(DetailsFormModel model, Guid userId);
        Task<SpecimenListModel> AllSpecimensAsync(SortingType sorting = SortingType.DateCreated, int currentPage = 1, int countPerPage = int.MaxValue, bool isPublished = true);
        Task ArchiveByIdAsync(Guid id, bool restore = false);
        Task ArchiveByIdsAsync(IEnumerable<string> ids);
        Task<SpecimenDetailsModel> GetDetailsViewByIdAsync(Guid id);
        Task<IEnumerable<SpecimenSummaryModel>> GetSpecimensOutOfRange(Guid id, int totalRows, int totalColumns);
        Task<bool> UpdateSpecimenAsync(Guid id, DetailsFormModel formModel);
    }
}
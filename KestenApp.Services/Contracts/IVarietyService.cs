namespace KestenApp.Services.Contracts
{
    using KestenApp.Data.Enums;
    using KestenApp.Data.Models;
    using KestenApp.Web.ViewModels;
    using KestenApp.Web.ViewModels.Varieties;

    public interface IVarietyService
    {
        Task<VarietyListModel> AllVarietiesAsync(string? name = null, VarietySortingType sorting = VarietySortingType.DateCreated, int currentPage = 1, int countPerPage = int.MaxValue, bool isActive = true);
        Task<VarietyDetailsModel> GetDetailsViewByIdAsync(Guid id);
        Task<Variety?> GetVarietyByNameAsync(string name);
        Task<IEnumerable<Variety>> SearchVarietiesAsync(string searchQuery);
        Task<Guid> AddVarietyAsync(VarietyFormModel model);
        Task<Guid?> UpdateVarietyAsync(Guid id, VarietyFormModel model);
        Task PublishVarietyAsync(Guid id, bool unpublish = false);
        Task ArchiveByIdAsync(Guid varietyId, bool restore = false);
        IEnumerable<DropdownModel> GenerateConditionOptions();
        IEnumerable<DropdownModel> GeneratePollenOptions();
        Task<IList<CheckboxModel>> GenerateSpeciesCheckboxesAsync(IEnumerable<int>? varietySpecies = null);
        Task<VarietyFormModel> GetFormViewByIdAsync(Guid id);
        IEnumerable<DropdownModel> GenerateVigorOptions();
        IEnumerable<DropdownModel> GeneratePeriodOptions();
        Task<IList<CheckboxModel>> GenerateFruitSizeCheckboxesAsync(IEnumerable<int>? varietyFruitSizes = null);
        IEnumerable<BooleanDropdownModel> GenerateBooleanOptions();
    }
}
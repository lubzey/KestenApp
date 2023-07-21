using KestenApp.Data.Enums;
using KestenApp.Data.Models;
using KestenApp.Services.Models;
using KestenApp.Web.Models.Varieties;

namespace KestenApp.Services.Contracts
{
    public interface IVarietyService
    {
        VarietyServiceModel AllVarieties(string? name = null, VarietySorting sorting = VarietySorting.DateCreated, int currentPage = 1, int countPerPage = int.MaxValue);
        Variety? GetDetailsViewById(Guid id);
        IEnumerable<Variety> SearchVarieties(string searchQuery);
        Task<Guid> AddVarietyAsync(VarietyFormModel model);
        Task<Guid?> UpdateVarietyAsync(Guid id, VarietyFormModel model);
        Variety? GetVarietyByName(string name);
    }
}
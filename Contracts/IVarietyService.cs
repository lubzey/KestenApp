using KestenApp.Data.Models;
using KestenApp.Infrastructure.Enums;
using KestenApp.Models.Varieties;
using KestenApp.Services;

namespace KestenApp.Contracts
{
    public interface IVarietyService
    {
        VarietyServiceModel AllVarieties(string? name = null, VarietySorting sorting = VarietySorting.DateCreated, int currentPage = 1, int countPerPage = int.MaxValue);
        Variety? GetDetailsViewById(int id);
        IEnumerable<Variety> SearchVarieties(string searchQuery);
        Task<int> AddVarietyAsync(VarietyFormModel model);
        Task<int?> UpdateVarietyAsync(int id, VarietyFormModel model);        
    }
}
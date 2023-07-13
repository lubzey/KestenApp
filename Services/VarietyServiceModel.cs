using KestenApp.Data.Models;

namespace KestenApp.Services
{
    public class VarietyServiceModel
    {
        public int TotalCount { get; internal set; }
        public int CurrentPage { get; internal set; }
        public int CountPerPage { get; internal set; }
        public IEnumerable<Variety> Varieties { get; internal set; }
    }
}
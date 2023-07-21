namespace KestenApp.Services.Models
{
    using KestenApp.Data.Models;

    public class VarietyServiceModel
    {
        public int TotalCount { get; set; }
        public int CurrentPage { get; set; }
        public int CountPerPage { get; set; }
        public IEnumerable<Variety> Varieties { get; set; } = null!;
    }
}
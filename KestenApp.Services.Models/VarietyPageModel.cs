namespace KestenApp.Services.Models
{
    public class VarietyPageModel
    {
        public int TotalCount { get; set; }
        public int CurrentPage { get; set; }
        public int CountPerPage { get; set; }
        public IEnumerable<VarietySummaryModel> Varieties { get; set; } = null!;
    }
}
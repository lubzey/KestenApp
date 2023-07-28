namespace KestenApp.Web.ViewModels.Garden
{
    using KestenApp.Data.Models;

    public class GardenSummaryModel
    {
        public Garden Garden { get; set; } = null!;
        public IEnumerable<Specimen> Specimens { get; set; } = Enumerable.Empty<Specimen>();
        public ApplicationUser User { get; set; } = null!;
    }
}

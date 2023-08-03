namespace KestenApp.Web.ViewModels.Specimen
{
    using KestenApp.Data.Models;

    public class SpecimenSummaryModel
    {
        public Guid SpecimenId { get; set; }
        public string? SpecimenName { get; set; } = null!;
        public int? Year { get; set; }
        public Variety? Variety { get; set; }
        public Garden Garden { get; set; } = null!;
        public ApplicationUser User { get; set; } = null!;
    }
}

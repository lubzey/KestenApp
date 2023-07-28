using KestenApp.Data.Models;

namespace KestenApp.Web.ViewModels.Specimen
{
    public class SpecimenSummaryModel
    {
        public Guid SpecimenId { get; set; }
        public string SpecimenName { get; set; } = null!;
        public int? Year { get; set; }
        public Variety? Variety { get; set; }
        public Garden? Garden { get; set; }
        public ApplicationUser User { get; set; } = null!;
    }
}

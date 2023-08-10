using KestenApp.Web.ViewModels.Specimen;

namespace KestenApp.Web.ViewModels.Garden
{
    public class ArchiveSpecimensModel
    {
        public Guid GardenId { get; set; }
        public IEnumerable<SpecimenSummaryModel> Specimens { get; set; } = null!;
        public IEnumerable<string> IdsToArchive { get; set; } = null!;

        public readonly List<string> HeaderTitles = new List<string>
        {
            "Name",
            "Variety",
            "Year",
            "Garden",
            "Row",
            "Column"
        };
    }
}

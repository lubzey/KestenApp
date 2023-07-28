namespace KestenApp.Web.ViewModels.Specimen
{
    using KestenApp.Data.Models;

    public class SpecimenListModel
    {
        public readonly List<string> HeaderTitles = new List<string>
            {
                "Name",
                "Year",
                "Garden",
                "Variety",
                "User"
            };

        public int TotalCount { get; set; }
        public int CurrentPage { get; set; }
        public int CountPerPage { get; set; }
        public IEnumerable<SpecimenSummaryModel> Specimens { get; set; } = Enumerable.Empty<SpecimenSummaryModel>();
    }
}

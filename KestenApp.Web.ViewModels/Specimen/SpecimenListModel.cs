namespace KestenApp.Web.ViewModels.Specimen
{
    public class SpecimenListModel
    {
        public readonly List<string> HeaderTitles = new List<string>
            {
                "Name",
                "Variety",
                "Year",
                "Garden",                
                "User"
            };

        public int TotalCount { get; set; }
        public int CurrentPage { get; set; }
        public int CountPerPage { get; set; }
        public IEnumerable<SpecimenSummaryModel> Specimens { get; set; } = Enumerable.Empty<SpecimenSummaryModel>();
    }
}

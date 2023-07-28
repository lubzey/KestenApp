namespace KestenApp.Web.ViewModels.Garden
{
    public class GardenListModel
    {
        public readonly List<string> HeaderTitles = new List<string>
            {
                "Name",
                "Specimens",
                "User"
            };

        public int TotalCount { get; set; }
        public int CurrentPage { get; set; }
        public int CountPerPage { get; set; }
        public IEnumerable<GardenSummaryModel> Gardens { get; set; } = Enumerable.Empty<GardenSummaryModel>();
    }
}

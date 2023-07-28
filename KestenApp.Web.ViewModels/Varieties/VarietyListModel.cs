namespace KestenApp.Web.ViewModels.Varieties
{
    public class VarietyListModel
    {
        public readonly List<string> HeaderTitles = new List<string>
            {
                "Name",
                "Species",
                "Fruit Size",
                "Is Marron",
                "Blight Resistance",
                "Ink Disease Resistance",
                "Peeling",
                "Pollen Type",
                "Maturity Period",
                "Pollenized By",
                "Pollenizer For",
                "Rootstock For",
                "Grafted On"
            };

        public int TotalCount { get; set; }
        public int CurrentPage { get; set; }
        public int CountPerPage { get; set; }
        public IEnumerable<VarietySummaryModel> Varieties { get; set; } = null!;
    }
}
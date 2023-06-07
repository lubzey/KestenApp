namespace KestenTestApp.Models.View
{
    public class VarietyListViewModel
    {
        public IEnumerable<Variety> Varieties;
        public string? CurrentVariety;
        public string Title;
        public string Separator;
        public List<string> HeaderTitles;

        public VarietyListViewModel(IEnumerable<Variety> varieties)
        {
            this.Title = "Variesties";
            this.Varieties = varieties;
            this.Separator = $",{Environment.NewLine}";
            this.HeaderTitles = new List<string>
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
        }
    }
}
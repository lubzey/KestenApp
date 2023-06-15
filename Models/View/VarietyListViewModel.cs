namespace KestenTestApp.Models.View
{
    public class VarietyListViewModel
    {
        public IEnumerable<VarietyListDetailsViewModel> Varieties;
        public List<string> HeaderTitles;

        public VarietyListViewModel(IEnumerable<VarietyListDetailsViewModel> varieties)
        {
            this.Varieties = varieties;
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
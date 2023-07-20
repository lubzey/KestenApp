namespace KestenApp.Web.Models.Varieties
{
    public class VarietyListModel
    {
        public IEnumerable<VarietyListDetailsModel> Varieties;
        public List<string> HeaderTitles;

        public VarietyListModel(IEnumerable<VarietyListDetailsModel> varieties)
        {
            Varieties = varieties;
            HeaderTitles = new List<string>
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
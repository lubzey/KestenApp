namespace KestenTestApp.Models.View
{
    public class VarietyListViewModel
    {
        public IEnumerable<Variety> Varieties;
        public string? CurrentVariety;
        public string Title;

        public VarietyListViewModel(IEnumerable<Variety> varieties)
        {
            this.Title = "Variesties";
            this.Varieties = varieties;
        }
    }
}
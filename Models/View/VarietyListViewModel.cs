namespace KestenTestApp.Models.View
{
    public class VarietyListViewModel
    {
        public IEnumerable<Variety> Varieties;
        public string? CurrentVariety;
        public string Title;
        public string Separator;

        public VarietyListViewModel(IEnumerable<Variety> varieties)
        {
            this.Title = "Variesties";
            this.Varieties = varieties;
            this.Separator = $",{Environment.NewLine}";
        }
    }
}
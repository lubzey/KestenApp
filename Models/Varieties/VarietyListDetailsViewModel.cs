namespace KestenApp.Models.Varieties
{
    public class VarietyListDetailsViewModel
    {
        public int VarietyId { get; set; } = default!;
        public string VarietyName { get; set; } = default!;
        public string Species { get; set; } = default!;
        public string FruitSizes { get; set; } = default!;
        public string IsMarron { get; set; } = default!;
        public string ChestnutBlightResistance { get; set; } = default!;
        public string InkDiseaseResistance { get; set; } = default!;
        public string Peeling { get; set; } = default!;
        public string PollenFertility { get; set; } = default!;
        public string MaturityPeriod { get; set; } = default!;
        public string IsPollenizedBy { get; set; } = default!;
        public string IsPollenizerFor { get; set; } = default!;
        public string IsRootstockFor { get; set; } = default!;
        public string IsGraftedOn { get; set; } = default!;
    }
}
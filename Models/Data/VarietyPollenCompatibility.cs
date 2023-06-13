namespace KestenTestApp.Models.Data
{
    public class VarietyPollenCompatibility
    {
        public int PollinizerVarietyId { get; set; }
        public Variety PollenizerVariety { get; set; } = default!;
        public int TargetVarietyId { get; set; }
        public Variety TargetVariety { get; set; } = default!;
    }
}

namespace KestenApp.Data.Models
{
    public class VarietyPollenCompatibility
    {
        public Guid PollenizerVarietyId { get; set; }
        public Variety PollenizerVariety { get; set; } = default!;
        public Guid TargetVarietyId { get; set; }
        public Variety TargetVariety { get; set; } = default!;
    }
}

namespace KestenTestApp.Models
{
    public class VarietyPollenizerCompatibility
    {
        public int PollinizerVarietyId { get; set; }
        public Variety PollenizerVariety { get; set; }
        public int TargetVarietyId { get; set; }
        public Variety TargetVariety { get; set; }
    }
}

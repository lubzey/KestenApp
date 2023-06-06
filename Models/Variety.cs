using KestenTestApp.Models.Enums;

namespace KestenTestApp.Models
{
    public class Variety
    {
        public int VarietyId { get; set; }
        public string VarietyName { get; set; } = string.Empty;
        public string? Description { get; set; }
        public List<Species> Species { get; set; } = new List<Species>();
        public List<FruitSize> FruitSizes { get; set; } = new List<FruitSize>();
        public List<PollenizerTarget> PollenizerTargets { get; set; } = new List<PollenizerTarget>();
        public List<PollenizerTarget> Pollenizers { get; set; } = new List<PollenizerTarget>();
        public ConditionEnum? ChestnutBlightResistance { get; set; }
        public ConditionEnum? InkDiseaseResistance { get; set; }
        public ConditionEnum? Peeling { get; set; }
        public PollenTypeEnum? PollenType { get; set; }

        public MaturingPeriodEnum? MaturingPeriod { get; set; }
        public bool? IsMarron { get; set; }
    }
}

namespace KestenApp.Data.Models
{
    using KestenApp.Data.Enums;
    using System.ComponentModel.DataAnnotations;
    using static KestenApp.Common.EntityValidationConstants.Variety;

    public class Variety
    {
        [Key]
        public Guid VarietyId { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; } = string.Empty;

        public ConditionType ChestnutBlightResistance { get; set; } = ConditionType.None;
        public ConditionType InkDiseaseResistance { get; set; } = ConditionType.None;
        public ConditionType Peeling { get; set; } = ConditionType.None;
        public ConditionType Conservation { get; set; } = ConditionType.None;
        public VolumeType Crop { get; set; } = VolumeType.None;
        public PollenType PollenType { get; set; } = PollenType.None;
        public PeriodType BuddingPeriod { get; set; } = PeriodType.None;
        public PeriodType FloweringPeriod { get; set; } = PeriodType.None;
        public PeriodType MaturityPeriod { get; set; } = PeriodType.None;
        public StrengthType Vigor { get; set; } = StrengthType.None;
        public bool? IsMarron { get; set; }
        public DateTime DateCreated { get; set; }

        public ICollection<VarietySpecies> Species { get; set; } = new List<VarietySpecies>();
        public ICollection<VarietyFruitSize> FruitSizes { get; set; } = new List<VarietyFruitSize>();
        public ICollection<VarietyImage> VarietyImages { get; set; } = new List<VarietyImage>();

        public ICollection<VarietyPollenCompatibility> IsPollenizerFor { get; set; } = new List<VarietyPollenCompatibility>();
        public ICollection<VarietyPollenCompatibility> IsPollenizedBy { get; set; } = new List<VarietyPollenCompatibility>();

        public ICollection<VarietyGraftingCompatibility> IsGraftedOn { get; set; } = new List<VarietyGraftingCompatibility>();
        public ICollection<VarietyGraftingCompatibility> IsRootstockFor { get; set; } = new List<VarietyGraftingCompatibility>();
    }
}

namespace Kesten.Server.Data.Models
{
    using Kesten.Server.Data.Enums;
    using System.ComponentModel.DataAnnotations;
    using static Kesten.Server.Data.EntityValidationConstants.VarietyConstants;

    public class Variety
    {
        [Key]
        public Guid VarietyId { get; set; }

        public bool IsActive { get; set; } = true;
        public bool IsPublished { get; set; } = true;

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; } = string.Empty;

        public ConditionType ChestnutBlightResistance { get; set; } = ConditionType.NotSelected;
        public ConditionType InkDiseaseResistance { get; set; } = ConditionType.NotSelected;
        public ConditionType Peeling { get; set; } = ConditionType.NotSelected;
        public ConditionType Conservation { get; set; } = ConditionType.NotSelected;
        public VolumeType Crop { get; set; } = VolumeType.NotSelected;
        public PollenType PollenType { get; set; } = PollenType.NotSelected;
        public PeriodType BuddingPeriod { get; set; } = PeriodType.NotSelected;
        public PeriodType FloweringPeriod { get; set; } = PeriodType.NotSelected;
        public PeriodType MaturityPeriod { get; set; } = PeriodType.NotSelected;
        public StrengthType Vigor { get; set; } = StrengthType.NotSelected;
        public bool? IsMarron { get; set; }
        public DateTime DateCreated { get; set; }

        public ICollection<VarietySpecies> Species { get; set; } = new List<VarietySpecies>();
        public ICollection<VarietyFruitSize> FruitSizes { get; set; } = new List<VarietyFruitSize>();
        public ICollection<VarietyImage> VarietyImages { get; set; } = new List<VarietyImage>();

        public ICollection<VarietyPollenCompatibility> IsPollenizerFor { get; set; } = new List<VarietyPollenCompatibility>();
        public ICollection<VarietyPollenCompatibility> IsPollenizedBy { get; set; } = new List<VarietyPollenCompatibility>();

        public ICollection<VarietyGraftingCompatibility> IsGraftedOn { get; set; } = new List<VarietyGraftingCompatibility>();
        public ICollection<VarietyGraftingCompatibility> IsRootstockFor { get; set; } = new List<VarietyGraftingCompatibility>();

        public ICollection<Specimen> Specimens { get; set; } = new List<Specimen>();
    }
}

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

        public ConditionTypeEnum ChestnutBlightResistance { get; set; } = ConditionTypeEnum.None;
        public ConditionTypeEnum InkDiseaseResistance { get; set; } = ConditionTypeEnum.None;
        public ConditionTypeEnum Peeling { get; set; } = ConditionTypeEnum.None;
        public PollenTypeEnum PollenType { get; set; } = PollenTypeEnum.None;
        public PeriodTypeEnum MaturityPeriod { get; set; } = PeriodTypeEnum.None;
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

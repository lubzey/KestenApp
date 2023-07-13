using KestenApp.Infrastructure.Enums;
using System.ComponentModel.DataAnnotations;
using static KestenApp.Data.DataConstants.Variety;

namespace KestenApp.Data.Models
{
    public class Variety
    {
        public int VarietyId { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string VarietyName { get; set; } = string.Empty;

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

        public List<Species> Species { get; set; } = new List<Species>();
        public List<FruitSize> FruitSizes { get; set; } = new List<FruitSize>();
        public List<Image> Images { get; set; } = new List<Image>();

        public List<VarietyPollenCompatibility> IsPollenizerFor { get; set; } = new List<VarietyPollenCompatibility>();
        public List<VarietyPollenCompatibility> IsPollenizedBy { get; set; } = new List<VarietyPollenCompatibility>();

        public List<VarietyGraftingCompatibility> IsGraftedOn { get; set; } = new List<VarietyGraftingCompatibility>();
        public List<VarietyGraftingCompatibility> IsRootstockFor { get; set; } = new List<VarietyGraftingCompatibility>();       
    }
}

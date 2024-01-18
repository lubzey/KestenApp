namespace Kesten.Api.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class FruitSize
    {
        [Key]
        public int FruitSizeId { get; set; }
        public string Name { get; set; } = null!;
        public int? FruitsPerKgMin { get; set; }
        public int? FruitsPerKgMax { get; set; }
        public int? FruitsWeightMin { get; set; }
        public int? FruitsWeightMax { get; set; }
        public List<VarietyFruitSize> Varieties { get; set; } = new List<VarietyFruitSize>();
    }
}

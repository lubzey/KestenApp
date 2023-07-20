namespace KestenApp.Data.Models
{
    public class FruitSize
    {
        public int FruitSizeId { get; set; }
        public string Name { get; set; } = string.Empty;
        public int? FruitsPerKgMin { get; set; }
        public int? FruitsPerKgMax { get; set; }
        public int? FruitsWeightMin { get; set; }
        public int? FruitsWeightMax { get; set; }
        public List<VarietyFruitSize> Varieties { get; set; } = new List<VarietyFruitSize>();
    }
}

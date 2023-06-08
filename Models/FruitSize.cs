namespace KestenTestApp.Models
{
    public class FruitSize
    {
        public int FruitSizeId { get; set; }
        public string Name { get; set; } = string.Empty;
        public int? FruitsPerKgMin { get; set; }
        public int? FruitsPerKgMax { get; set; }
        public int? FruitsWeightMin { get; set; }
        public int? FruitsWeightMax { get; set; }
        public List<Variety> Varieties { get; set; } = new List<Variety>();
    }
}

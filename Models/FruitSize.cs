namespace KestenTestApp.Models
{
    public class FruitSize
    {
        public int FruitSizeId { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<Variety> Varieties { get; set; } = new List<Variety>();
    }
}

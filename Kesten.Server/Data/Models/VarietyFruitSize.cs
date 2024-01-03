namespace Kesten.Server.Data.Models
{
    public class VarietyFruitSize
    {
        public int FruitSizeId { get; set; }
        public FruitSize FruitSize { get; set; } = null!;

        public Guid VarietyId { get; set; }
        public Variety Variety { get; set; } = null!;
    }
}

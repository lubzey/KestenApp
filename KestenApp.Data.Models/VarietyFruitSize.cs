namespace KestenApp.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class VarietyFruitSize
    {        
        //public int VarietyFruitSizeId { get; set; }

        public int FruitSizeId { get; set; }
        public FruitSize FruitSize { get; set; } = null!;

        public Guid VarietyId { get; set; }
        public Variety Variety { get; set; } = null!;
    }
}

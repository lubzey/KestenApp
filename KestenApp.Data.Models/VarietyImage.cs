namespace KestenApp.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class VarietyImage
    {
        [Key]
        public Guid ImageId { get; set; }
        public Guid VarietyId { get; set; }
        public Variety Variety { get; set; } = null!;
    }
}

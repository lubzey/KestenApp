namespace KestenApp.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using static KestenApp.Common.EntityValidationConstants.GardenConstants;

    public class Garden
    {
        public Guid GardenId { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        public Guid UserId { get; set; }
        public ApplicationUser User { get; set; } = null!;

        public ICollection<Specimen> Specimens { get; set; } = new HashSet<Specimen>();
    }
}
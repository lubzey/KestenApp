namespace KestenApp.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using static KestenApp.Common.EntityValidationConstants.GardenConstants;

    public class Garden
    {
        public Guid GardenId { get; set; }

        public Guid UserId { get; set; }

        public ApplicationUser User { get; set; } = null!;

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        public DateTime DateCreated { get; set; }

        public ICollection<Specimen> Specimens { get; set; } = new List<Specimen>();
    }
}
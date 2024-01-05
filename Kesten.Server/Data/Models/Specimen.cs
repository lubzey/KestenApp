namespace Kesten.Server.Data.Models
{
    using Microsoft.EntityFrameworkCore;
    using static Kesten.Server.Data.EntityValidationConstants.SpecimenConstants;

    public class Specimen
    {
        public Guid SpecimenId { get; set; }

        public string? Name { get; set; } = null!;

        public Guid? VarietyId { get; set; }

        public Variety? Variety { get; set; } = null!;

        public Guid GardenId { get; set; }

        public int Row { get; set; }

        public int Column { get; set; }

        public Garden Garden { get; set; } = null!;

        public Guid UserId { get; set; }

        public ApplicationUser User { get; set; } = null!;

        [Precision(LocationPrecision, LocationScale)]
        public int? Elevation { get; set; }

        public DateTime? PlantedOnDate { get; set; }

        public DateTime? SowedOnDate { get; set; }

        public DateTime? GraftedOnDate { get; set; }

        public DateTime DateCreated { get; set; }

        public bool IsActive { get; set; } = true;

        public int? Year => PlantedOnDate?.Year ?? SowedOnDate?.Year;
    }
}

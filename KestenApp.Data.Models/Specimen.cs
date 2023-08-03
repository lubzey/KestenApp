namespace KestenApp.Data.Models
{
    using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
    using Microsoft.EntityFrameworkCore;
    using static KestenApp.Common.EntityValidationConstants.SpecimenConstants;

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

        [ValidateNever]
        public int? Year
        {
            get
            {
                return PlantedOnDate != null
                        ? PlantedOnDate.Value.Year
                        : SowedOnDate != null
                            ? SowedOnDate.Value.Year
                            : null;
            }
        }
    }
}

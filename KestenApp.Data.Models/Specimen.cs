﻿namespace KestenApp.Data.Models
{
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;
    using static KestenApp.Common.EntityValidationConstants.Specimen;

    public class Specimen
    {
        public Guid SpecimenId { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        public Guid? VarietyId { get; set; }
        public Variety Variety { get; set; } = null!;        

        public Guid? GardenId { get; set; } = null!;
        public Garden? Garden { get; set; } = null!;

        public Guid UserId { get; set; }
        public ApplicationUser User { get; set; } = null!;

        [Precision(LocationPrecision, LocationScale)]
        public decimal? Latitude { get; set; }

        [Precision(LocationPrecision, LocationScale)]
        public decimal? Longitude { get; set; }

        [Precision(LocationPrecision, LocationScale)]
        public decimal? Altitude { get; set; }


        //Separate table SpecimenPositionInGarden
        //public decimal Row { get; set; }
        //public decimal Column { get; set; }
    }
}
namespace KestenApp.Web.ViewModels.Specimen
{
    using KestenApp.Web.ViewModels.Garden;
    using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using static KestenApp.Common.EntityValidationConstants;

    public class DetailsFormModel
    {
        public Guid GardenId { get; set; }

        [Range(GardenConstants.MinRowColumns, GardenConstants.MaxRowColumns)]
        public int Row { get; set; }

        [Range(GardenConstants.MinRowColumns, GardenConstants.MaxRowColumns)]
        public int Column { get; set; }

        //Details
        public string? SpecimenName { get; set; }
        public Guid? VarietyId { get; set; }

        [Range(GardenConstants.MinElevation, GardenConstants.MaxElevation)]
        public int? Elevation { get; set; }

        public DateTime? PlantedOnDate { get; set; }
        public DateTime? SowedOnDate { get; set; }
        public DateTime? GraftedOnDate { get; set; }

        //For data visualization
        [ValidateNever]
        public GardenDetailsModel Garden { get; set; } = null!;

        [ValidateNever]
        public FormTextsModel FormTexts { get; set; } = null!;

        [ValidateNever]
        public IEnumerable<SelectListItem> VarietyOptions { get; set; } = null!;

        public Guid? SpecimenId { get; set; }
    }
}

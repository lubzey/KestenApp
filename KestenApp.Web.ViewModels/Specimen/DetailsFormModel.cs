namespace KestenApp.Web.ViewModels.Specimen
{
    using KestenApp.Web.ViewModels.Garden;
    using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class DetailsFormModel
    {
        public Guid GardenId { get; set; }
        [Range(0, 1000)]
        public int Row { get; set; }
        [Range(0, 1000)]
        public int Column { get; set; }

        //Details
        public string? SpecimenName { get; set; }
        public Guid? VarietyId { get; set; }
        [Range(0, 5000)]
        public int? Elevation { get; set; }

        public DateTime? PlantedOnDate { get; set; } = DateTime.Now;
        public DateTime? SowedOnDate { get; set; }
        public DateTime? GraftedOnDate { get; set; }

        //For data visualization
        [ValidateNever]
        public GardenDetailsModel Garden { get; set; } = null!;

        [ValidateNever]
        public FormTextsModel FormTexts { get; set; } = null!;

        [ValidateNever]
        public IEnumerable<SelectListItem> VarietyOptions { get; set; } = null!;
    }
}

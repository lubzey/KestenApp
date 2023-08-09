namespace KestenApp.Web.ViewModels.Specimen
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using KestenApp.Data.Models;
    using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
    using Microsoft.AspNetCore.Mvc.Rendering;

    public class SpecimenFormModel
    {
        [ValidateNever]
        public Guid? SpecimenId { get; set; }

        public string? SpecimenName { get; set; } = string.Empty;

        [Range(1, int.MaxValue)]
        public int? Elevation { get; set; }

        public Guid? VarietyId { get; set; }

        [Required(ErrorMessage = "Please select user garden.")]
        public Guid? GardenId { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Please select a positive value.")]
        public int Row { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Please select a positive value.")]
        public int Column { get; set; }

        //Data visualizing
        [ValidateNever]
        public FormTextsModel FormTexts { get; set; } = null!;
        
        [ValidateNever]
        public IEnumerable<SelectListItem> VarietyOptions { get; set; } = Enumerable.Empty<SelectListItem>();
        
        [ValidateNever]
        public IEnumerable<SelectListItem> GardenOptions { get; set; } = Enumerable.Empty<SelectListItem>();

        [ValidateNever]
        public Garden? SelectedGarden { get; set; }
    }
}

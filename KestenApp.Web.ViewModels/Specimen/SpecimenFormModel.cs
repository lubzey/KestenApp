namespace KestenApp.Web.ViewModels.Specimen
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using KestenApp.Data.Models;
    using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
    using Microsoft.AspNetCore.Mvc.Rendering;

    public class SpecimenFormModel
    {
        public SpecimenFormModel()
        {
            
        }

        public SpecimenFormModel(Guid userId)
        {
            UserId = userId;            
        }

        [ValidateNever]
        public Guid? SpecimenId { get; set; }

        public string? SpecimenName { get; set; } = string.Empty;

        [Range(1, int.MaxValue)]
        public int? Elevation { get; set; }
        public Guid UserId { get; }

        //Text
        [ValidateNever]
        public FormTextsModel FormTexts { get; set; } = null!;

        public Guid? VarietyId { get; set; }

        [Required(ErrorMessage = "Please select user garden.")]
        public Guid? GardenId { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Please select a positive value.")]
        public int Row { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Please select a positive value.")]
        public int Column { get; set; }

        public IEnumerable<SelectListItem> VarietyOptions { get; set; } = Enumerable.Empty<SelectListItem>();
        public IEnumerable<SelectListItem> GardenOptions { get; set; } = Enumerable.Empty<SelectListItem>();
        public Garden? SelectedGarden { get; set; }
        public Guid? SelectedGardenId { get; set; }
    }
}

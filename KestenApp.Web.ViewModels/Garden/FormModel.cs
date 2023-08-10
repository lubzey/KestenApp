namespace KestenApp.Web.ViewModels.Garden
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

    public class FormModel
    {
        public Guid? GardenId { get; set; }

        [Required(ErrorMessage ="Garden name is required.")]
        [StringLength(maximumLength: 20, MinimumLength = 2, ErrorMessage = "Name must contain between {2} and {1} characters.")]
        public string GardenName { get; set; } = null!;

        [Required]
        [Range(1, 1000, ErrorMessage ="Enter a positive number up to 1000.")]
        public int TotalRows { get; set; }

        [Required]
        [Range(1, 1000, ErrorMessage = "Enter a positive number up to 1000.")]
        public int TotalColumns { get; set; }

        [ValidateNever]
        public FormTextsModel FormTexts { get; set; } = null!;
    }
}

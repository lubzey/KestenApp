namespace KestenApp.Web.ViewModels.Garden
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

    public class FormModel
    {
        public Guid? GardenId { get; set; }

        [Required]
        [StringLength(maximumLength: 20, MinimumLength = 2)]
        public string GardenName { get; set; } = null!;

        [Required]
        [Range(1, 1000)]
        public int TotalRows { get; set; }

        [Required]
        [Range(1, 1000)]
        public int TotalColumns { get; set; }

        [ValidateNever]
        public GardenDetailsModel Garden { get; set; } = null!;

        [ValidateNever]
        public FormTextsModel FormTexts { get; set; } = null!;
    }
}

﻿using KestenTestApp.Models.Data;
using KestenTestApp.Models.Enums;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace KestenTestApp.Models.View
{
    public class VarietyAddOrEditViewModel
    {
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string VarietyName { get; set; } = string.Empty;

        [Required]
        [StringLength(1000, MinimumLength = 5)]
        public string Description { get; set; } = string.Empty;

        [Required]
        public PollenTypeEnum PollenType { get; set; } = PollenTypeEnum.None;

        //Used to display data
        [ValidateNever]
        public IReadOnlyList<CheckboxViewModel> SpeciesCheckboxes { get; set; } = null!;

        [ValidateNever]
        public IReadOnlyList<SelectListItem> PollenOptions { get; set; } = null!;

        [ValidateNever]
        public string? ThumbnailImagePath { get; set; }

        [ValidateNever]
        public string? ConfirmButtonText { get; internal set; }
        
        [ValidateNever]
        public int? VarietyId { get; internal set; }
    }
}

using System.ComponentModel.DataAnnotations;

using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

using KestenApp.Data.Enums;
using static KestenApp.Common.EntityValidationConstants.VarietyConstants;

namespace KestenApp.Web.ViewModels.Varieties
{
    public class VarietyFormModel
    {
        [ValidateNever]
        public Guid? VarietyId { get; set; }

        [Required(ErrorMessage = "Please enter variety name.")]
        [StringLength(
            NameMaxLength,
            MinimumLength = NameMinLength,
            ErrorMessage = "The name must be a string with a minimum length of {2}.")]
        public string VarietyName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter variety description.")]
        [StringLength(
            DescriptionMaxLength,
            MinimumLength = DescriptionMinLength,
            ErrorMessage = "The description must be a string with a minimum length of {2}."
            )]
        public string Description { get; set; } = string.Empty;

        [Required]
        public PollenType PollenType { get; set; } = PollenType.None;

        [Required]
        public ConditionType ChestnutBlightResistance { get; set; } = ConditionType.None;

        [Required]
        public ConditionType InkDiseaseResistance { get; set; } = ConditionType.None;


        //Used to display data
        [ValidateNever]
        public string ThumbnailImagePath { get; set; } = null!;

        [ValidateNever]
        public IList<CheckboxModel> SpeciesCheckboxes { get; set; } = null!;

        [ValidateNever]
        public IEnumerable<DropdownModel> PollenOptions { get; set; } = null!;

        [ValidateNever]
        public IEnumerable<DropdownModel> BlightResistanceOptions { get; set; } = null!;
        
        //Text
        [ValidateNever]
        public string AspAction
        {
            get
            {
                return VarietyId != null ?
                    "Edit" :
                    "Add";
            }
        }

        [ValidateNever]
        public string AspActionRedirect
        {
            get
            {
                return VarietyId != null ?
                    "Details" :
                    "List";
            }
        }

        [ValidateNever]
        public string PageTitle
        {
            get
            {
                return VarietyId != null ?
                    "Edit Variety" :
                    "Create Variety";
            }
        }

        [ValidateNever]
        public string SubmitButtonText
        {
            get
            {
                return VarietyId != null ?
                    "Save" :
                    "Create";
            }
        }
    }
}

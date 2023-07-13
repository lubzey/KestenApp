using KestenApp.Infrastructure.Enums;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using static KestenApp.Data.DataConstants.Variety;

namespace KestenApp.Models.Varieties
{
    public class VarietyFormModel
    {
        [ValidateNever]
        public int? VarietyId { get; internal set; }

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
        public PollenTypeEnum PollenType { get; set; } = PollenTypeEnum.None;

        [Required]
        public ConditionTypeEnum ChestnutBlightResistance { get; set; } = ConditionTypeEnum.None;

        [Required]
        public ConditionTypeEnum InkDiseaseResistance { get; set; } = ConditionTypeEnum.None;


        //Used to display data
        [ValidateNever]
        public string ThumbnailImagePath { get; set; } = null!;

        [ValidateNever]
        public IList<CheckboxModel> SpeciesCheckboxes { get; set; } = null!;

        [ValidateNever]
        public IEnumerable<SelectListItem> PollenOptions { get; set; } = null!;


        //Text
        [ValidateNever]
        public string AspAction
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

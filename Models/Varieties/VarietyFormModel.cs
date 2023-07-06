using KestenApp.Infrastructure.Enums;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace KestenApp.Models.Varieties
{
    public class VarietyFormModel
    {
        [ValidateNever]
        public int? VarietyId { get; internal set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string VarietyName { get; set; } = string.Empty;

        [Required]
        [StringLength(1000, MinimumLength = 5)]
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

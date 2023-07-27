namespace KestenApp.Web.ViewModels.Varieties
{
    using System.ComponentModel.DataAnnotations;

    using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

    using KestenApp.Data.Enums;
    using static KestenApp.Common.EntityValidationConstants.VarietyConstants;

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

        [Required]
        public StrengthType Vigor { get; set; } = StrengthType.None;

        [Required]
        public PeriodType BuddingPeriod { get; set; } = PeriodType.None;

        [Required]
        public PeriodType FloweringPeriod { get; set; } = PeriodType.None;

        [Required]
        public PeriodType MaturityPeriod { get; set; } = PeriodType.None;

        [Required]
        public VolumeType Crop { get; set; } = VolumeType.None;

        [Required]
        public ConditionType Peeling { get; set; } = ConditionType.None;

        [Required]
        public ConditionType Conservation { get; set; } = ConditionType.None;


        //Used to display data
        [ValidateNever]
        public string ThumbnailImagePath { get; set; } = null!;

        [ValidateNever]
        public IList<CheckboxModel> SpeciesCheckboxes { get; set; } = null!;

        [ValidateNever]
        public IEnumerable<DropdownModel> BlightResistanceOptions { get; set; } = new DropdownModel[0];

        [ValidateNever]
        public IEnumerable<DropdownModel> InkDiseaseResistanceOptions { get; set; } = new DropdownModel[0];

        [ValidateNever]
        public IEnumerable<DropdownModel> PollenOptions { get; set; } = null!;

        [ValidateNever]
        public IEnumerable<DropdownModel> VigorOptions { get; set; } = null!;

        [ValidateNever]
        public IEnumerable<DropdownModel> BuddingPeriodOptions { get; set; } = null!;
        [ValidateNever]
        public IEnumerable<DropdownModel> FloweringPeriodOptions { get; set; } = null!;
        [ValidateNever]
        public IEnumerable<DropdownModel> MaturityPeriodOptions { get; set; } = null!;
        [ValidateNever]
        public IEnumerable<DropdownModel> CropVolumeOptions { get; set; } = null!;
        [ValidateNever]
        public IList<CheckboxModel> FruitSizeCheckboxes { get; set; } = null!;
        [ValidateNever]
        public IEnumerable<DropdownModel> PeelingOptions { get; set; } = null!;
        [ValidateNever]
        public IEnumerable<DropdownModel> ConservationOptions { get; set; } = null!;

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

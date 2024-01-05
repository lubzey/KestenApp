namespace Kesten.Server.Models.Variety
{
    using System.ComponentModel.DataAnnotations;
    using Kesten.Server.Data.Enums;
    using Kesten.Server.Models.Shared;
    using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
    using static Kesten.Server.Data.EntityValidationConstants;

    public class VarietyFormModel
    {
        public VarietyFormModel()
        {
            FormTexts = new FormTextsModel("Variety");
        }

        [ValidateNever]
        public Guid? VarietyId { get; set; }

        [Required(ErrorMessage = "Please enter variety name.")]
        [StringLength(
            VarietyConstants.NameMaxLength,
            MinimumLength = VarietyConstants.NameMinLength,
            ErrorMessage = "The name must be a string with a minimum length of {2}.")]
        public string VarietyName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter variety description.")]
        [StringLength(
            VarietyConstants.DescriptionMaxLength,
            MinimumLength = VarietyConstants.DescriptionMinLength,
            ErrorMessage = "The description must be a string with a minimum length of {2}."
            )]
        public string Description { get; set; } = string.Empty;

        [Required]
        public PollenType PollenType { get; set; } = PollenType.NotSelected;

        [Required]
        public ConditionType ChestnutBlightResistance { get; set; } = ConditionType.NotSelected;

        [Required]
        public ConditionType InkDiseaseResistance { get; set; } = ConditionType.NotSelected;

        [Required]
        public StrengthType Vigor { get; set; } = StrengthType.NotSelected;

        [Required]
        public PeriodType BuddingPeriod { get; set; } = PeriodType.NotSelected;

        [Required]
        public PeriodType FloweringPeriod { get; set; } = PeriodType.NotSelected;

        [Required]
        public PeriodType MaturityPeriod { get; set; } = PeriodType.NotSelected;

        [Required]
        public VolumeType Crop { get; set; } = VolumeType.NotSelected;

        public bool? IsMarron { get; set; } = null!;

        [Required]
        public ConditionType Peeling { get; set; } = ConditionType.NotSelected;

        [Required]
        public ConditionType Conservation { get; set; } = ConditionType.NotSelected;


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
        [ValidateNever]
        public IEnumerable<BooleanDropdownModel> IsMarronOptions { get; set; } = null!;

        //Text
        [ValidateNever]
        public FormTextsModel FormTexts { get; set; } = null!;
    }
}

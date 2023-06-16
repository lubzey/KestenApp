using KestenTestApp.Models.Enums;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace KestenTestApp.Models.View
{
    public class VarietyAddViewModel
    {
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string VarietyName { get; set; } = null!;

        [Required]
        [StringLength(500, MinimumLength = 5)]
        public string Description { get; set; } = null!;

        public IReadOnlyList<CheckboxViewModel> Species { get; set; } = null!;

        [ValidateNever]
        public IReadOnlyList<PollenTypeEnum> AllPollenTypes { get; set; } = null!;
        public PollenTypeEnum PollenTypeSelected { get; set; }

        public VarietyAddViewModel()
        {
        }
    }
}

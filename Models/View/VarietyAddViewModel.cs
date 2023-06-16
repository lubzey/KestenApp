using KestenTestApp.Models.Data;
using KestenTestApp.Models.Enums;
using Microsoft.AspNetCore.Mvc.Rendering;
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

        //Species
        public VarietyAddViewModel()
        {
        }
    }
}

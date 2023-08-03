namespace KestenApp.Web.ViewModels.Specimen
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using KestenApp.Data.Models;
    using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
    using Microsoft.AspNetCore.Mvc.Rendering;

    public class SpecimenFormModel
    {
        public SpecimenFormModel()
        {
            
        }

        public SpecimenFormModel(IEnumerable<Garden> userGardens, Guid? selectedGardenId)
        {
            //TODO add specimen/variety id
            FormTexts = new FormTextsModel("Specimen");
            UserGardens = userGardens;

            if (selectedGardenId != null && selectedGardenId != Guid.Empty)
            {
                GardenId = ((Guid)selectedGardenId).ToString();
                SelectedGarden = userGardens.FirstOrDefault(g => g.GardenId == selectedGardenId);
            }
        }

        [ValidateNever]
        public Guid? SpecimenId { get; set; }

        public string? SpecimenName { get; set; } = string.Empty;

        [Range(1, int.MaxValue)]
        public int? Elevation { get; set; }

        //Text
        [ValidateNever]
        public FormTextsModel FormTexts { get; set; } = null!;

        public Guid? VarietyId { get; set; }

        [Required(ErrorMessage = "Please select user garden.")]
        public string? GardenId { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Please select a positive value.")]
        public int Row { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Please select a positive value.")]
        public int Column { get; set; }

        public IEnumerable<SelectListItem> VarietyOptions { get; set; } = Enumerable.Empty<SelectListItem>();
        public IEnumerable<SelectListItem> GardenOptions { get; set; } = Enumerable.Empty<SelectListItem>();
        public IEnumerable<Garden> UserGardens { get; set; } = Enumerable.Empty<Garden>();
        public Garden? SelectedGarden { get; set; }
    }
}

namespace KestenApp.Web.ViewModels.Specimen
{
    using Microsoft.AspNetCore.Mvc.Rendering;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class SpecimenGardenSelectModel
    {
        private IEnumerable<SelectListItem> gardens;

        public SpecimenGardenSelectModel(IEnumerable<SelectListItem> gardens)
        {
            this.gardens = gardens;
        }

        public IEnumerable<SelectListItem> Gardens { get => gardens; }

        [Required(ErrorMessage = "Please select a garden.")]
        public Guid GardenId { get; set; }
    }
}

namespace KestenApp.Web.ViewModels.Specimen
{
    using KestenApp.Web.ViewModels.Garden;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using System;
    using System.Collections.Generic;

    public class DetailsFormModel
    {
        public Guid GardenId { get; set; }

        public int Row { get; set; }

        public int Column { get; set; }

        public GardenDetailsModel Garden { get; set; } = null!;
        public Guid UserId { get; set; }
        public FormTextsModel FormTexts { get; set; }
        public Guid? VarietyId { get; set; }
        public IEnumerable<SelectListItem> VarietyOptions { get; set; } = null!;
        public Guid SelectedGardenId { get; set; }
        public string? SpecimenName { get; set; }
        public int? Elevation { get; set; }
    }
}

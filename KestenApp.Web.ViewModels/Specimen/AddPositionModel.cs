namespace KestenApp.Web.ViewModels.Specimen
{
    using KestenApp.Web.ViewModels.Garden;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class AddPositionModel
    {
        public Guid GardenId { get; set; }
        public string GardenName { get; set; } = null!;
        public int TotalRows { get; set; }
        public int TotalColumns { get; set; }

        [Required]
        public int SelectedRow { get; set; }

        [Required]
        public int SelectedColumn { get; set; }

        public SpecimenSchemaCard[] Specimens { get; set; } = null!;
    }
}

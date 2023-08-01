namespace KestenApp.Web.ViewModels.Garden
{
    public class GardenDetailsSchemaModel
    {
        public string Name { get; set; } = null!;
        public int? Year { get; set; }
        public Guid SpecimenId { get; set; }
        public string BackgroundColor { get; set; } = null!;
        public int? Row { get; set; }
        public int? Column { get; set; }
    }
}

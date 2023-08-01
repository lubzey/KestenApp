namespace KestenApp.Data.Models
{
    public class SpecimenPosition
    {
        public Guid SpecimenId { get; set; }
        public Specimen Specimen { get; set; } = null!;
        public int Row { get; set; }
        public int Column { get; set; }
    }
}
namespace KestenTestApp.Models
{
    public class Species
    {
        public int SpeciesId { get; set; }
        public string CommonName { get; set; } = string.Empty;
        public string LatinName { get; set; } = string.Empty;
        public List<Variety> Varieties { get; set; } = new List<Variety>();
    }
}
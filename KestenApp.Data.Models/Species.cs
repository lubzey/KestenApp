namespace KestenApp.Data.Models
{
    public class Species
    {
        public int SpeciesId { get; set; }
        public string CommonName { get; set; } = string.Empty;
        public string LatinName { get; set; } = string.Empty;
        public string ShortLatinName { get; set; } = string.Empty;
        public List<VarietySpecies> Varieties { get; set; } = new List<VarietySpecies>();
    }
}
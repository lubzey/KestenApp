namespace Kesten.Server.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class VarietySpecies
    {
        public int SpeciesId { get; set; }
        public Species Species { get; set; } = null!;

        public Guid VarietyId { get; set; }
        public Variety Variety { get; set; } = null!;
    }
}

namespace KestenApp.Data.Models
{
    public class VarietyGraftingCompatibility
    {
        public Guid RootstockVarietyId { get; set; }
        public Variety RootstockVariety { get; set; } = null!;
        public Guid GraftedVarietyId { get; set; }
        public Variety GraftedVariety { get; set; } = null!;
    }
}

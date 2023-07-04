namespace KestenApp.Data.Models
{
    public class VarietyGraftingCompatibility
    {
        public int RootstockVarietyId { get; set; }
        public Variety RootstockVariety { get; set; }
        public int GraftedVarietyId { get; set; }
        public Variety GraftedVariety { get; set; }
    }
}

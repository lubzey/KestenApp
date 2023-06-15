using KestenTestApp.Models.Data;

namespace KestenTestApp.Models.View
{
    public class VarietyDetailsViewModel
    {
        public Variety Variety;
        public string ThumbnailImagePath;

        public VarietyDetailsViewModel(Variety variety)
        {
            this.Variety = variety;
            this.ThumbnailImagePath = variety.Images.Any()
                ? $"/Images/Varieties/{variety.VarietyId}/{variety.Images.First().FileName}.jpg"
                : $"/Images/no-image.jpg";
        }
    }
}

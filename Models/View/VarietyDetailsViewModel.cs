using KestenTestApp.Models.Data;

namespace KestenTestApp.Models.View
{
    public class VarietyDetailsViewModel
    {
        public Variety Variety;
        public IReadOnlyList<CheckboxViewModel> SpeciesCheckboxes;
        public string ThumbnailImagePath;

        public VarietyDetailsViewModel(Variety variety, IReadOnlyList<CheckboxViewModel> speciesCheckboxes)
        {
            this.Variety = variety;
            this.SpeciesCheckboxes = speciesCheckboxes;
            this.ThumbnailImagePath = variety.Images.Any()
                ? $"/Images/Varieties/{variety.VarietyId}/{variety.Images.First().FileName}.jpg"
                : $"/Images/no-image.jpg";
        }
    }
}

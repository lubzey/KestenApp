using KestenApp.Data.Models;
using KestenApp.Models.View;

namespace KestenApp.Models.Varieties
{
    public class VarietyDetailsViewModel
    {
        public Variety Variety;
        public IReadOnlyList<CheckboxViewModel> SpeciesCheckboxes;
        public string ThumbnailImagePath;

        public VarietyDetailsViewModel(Variety variety, IReadOnlyList<CheckboxViewModel> speciesCheckboxes)
        {
            Variety = variety;
            SpeciesCheckboxes = speciesCheckboxes;
            ThumbnailImagePath = variety.Images.Any()
                ? $"/Images/Varieties/{variety.VarietyId}/{variety.Images.First().FileName}.jpg"
                : $"/Images/no-image.jpg";
        }
    }
}

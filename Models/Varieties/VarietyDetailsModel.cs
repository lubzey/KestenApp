using KestenApp.Data.Models;

namespace KestenApp.Models.Varieties
{
    public class VarietyDetailsModel
    {
        public Variety Variety;
        public IReadOnlyList<CheckboxModel> SpeciesCheckboxes;
        public string ThumbnailImagePath;

        public VarietyDetailsModel(Variety variety, IReadOnlyList<CheckboxModel> speciesCheckboxes)
        {
            Variety = variety;
            SpeciesCheckboxes = speciesCheckboxes;
            ThumbnailImagePath = variety.Images.Any()
                ? $"/Images/Varieties/{variety.VarietyId}/{variety.Images.First().FileName}.jpg"
                : $"/Images/no-image.jpg";
        }
    }
}

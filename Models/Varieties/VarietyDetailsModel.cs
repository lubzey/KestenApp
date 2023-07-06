using KestenApp.Data.Models;
using System.Collections.ObjectModel;

namespace KestenApp.Models.Varieties
{
    public class VarietyDetailsModel
    {
        public int VarietyId;
        public string VarietyName;
        public string Description;
        //public Variety Variety;
        public IEnumerable<KeyValuePair<string, string>> Tree;
        public IList<CheckboxModel> SpeciesCheckboxes;
        public string ThumbnailImagePath;

        public VarietyDetailsModel(Variety variety, IList<CheckboxModel> speciesCheckboxes)
        {
            VarietyId = variety.VarietyId;
            VarietyName = variety.VarietyName;
            Description = variety.Description;

            //Variety = variety;
            Tree = new List<KeyValuePair<string, string?>>
            {
                new KeyValuePair<string, string?>("Pollen", variety.PollenType.ToString()),
                new KeyValuePair<string, string?>("Vigor", null),
                new KeyValuePair<string, string?>("Erect", null),
                new KeyValuePair<string, string?>("Blight Resistance", variety.ChestnutBlightResistance.ToString()),
                new KeyValuePair<string, string?>("Ink Disease Resistance", variety.InkDiseaseResistance.ToString()),
            }
                .Where(kvp => !string.IsNullOrEmpty(kvp.Value))
                .Select(kvp => new KeyValuePair<string, string>(kvp.Key, kvp.Value ?? ""))
                .ToList();


            SpeciesCheckboxes = speciesCheckboxes;
            ThumbnailImagePath = variety.Images.Any()
                ? $"/Images/Varieties/{variety.VarietyId}/{variety.Images.First().FileName}.jpg"
                : $"/Images/no-image.jpg";
        }
    }
}

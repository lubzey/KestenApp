using KestenApp.Data.Models;

namespace KestenApp.Models.Varieties
{
    public class VarietyDetailsModel
    {
        public int VarietyId;
        public string VarietyName;
        public string Description;
        public List<KeyValuePair<string, string>> Tree = new List<KeyValuePair<string, string>>();
        public List<KeyValuePair<string, string>> Fruit = new List<KeyValuePair<string, string>>();
        public IList<CheckboxModel> SpeciesCheckboxes;
        public string ThumbnailImagePath;

        public VarietyDetailsModel(Variety variety, IList<CheckboxModel> speciesCheckboxes)
        {
            VarietyId = variety.VarietyId;
            VarietyName = variety.VarietyName;
            Description = variety.Description;

            //Tree
            AddKeyValuePairToCollection(Tree, "Pollen", variety.PollenType.ToString());
            AddKeyValuePairToCollection(Tree, "Vigor", null);
            AddKeyValuePairToCollection(Tree, "Budding Period", null);
            AddKeyValuePairToCollection(Tree, "Flowering Period", null);
            AddKeyValuePairToCollection(Tree, "Maturity Period", null);
            AddKeyValuePairToCollection(Tree, "Blight Resistance", variety.ChestnutBlightResistance.ToString());
            AddKeyValuePairToCollection(Tree, "Ink Disease Resistance", variety.InkDiseaseResistance.ToString());
            AddKeyValuePairToCollection(Tree, "Gall Wasp Resistance", variety.InkDiseaseResistance.ToString());
            AddKeyValuePairToCollection(Tree, "Cold Hardiness", null);
            AddKeyValuePairToCollection(Tree, "Spring Frost Sensitivity", null);
            AddKeyValuePairToCollection(Tree, "Kernel Rot Susceptibility", null);
            AddKeyValuePairToCollection(Tree, "Catkins Type", null);
            AddKeyValuePairToCollection(Tree, "Crop Volume", null);

            //Rootstock and pollentation

            //Fruit
            AddKeyValuePairToCollection(Fruit, "Taste", "Good");
            AddKeyValuePairToCollection(Fruit, "Size", string.Join(", ", variety.FruitSizes.Select(s => s.Name)));
            AddKeyValuePairToCollection(Fruit, "Is Marron", GetStringFromNullableBoolean(variety.IsMarron)); //<12%
            AddKeyValuePairToCollection(Fruit, "Kernel Splitting", "None,some,many?");
            AddKeyValuePairToCollection(Fruit, "Kernel Intrusion", "Deep,Shallow,None");
            AddKeyValuePairToCollection(Fruit, "Shape", "Oval, Triangular, Irregular ???");
            AddKeyValuePairToCollection(Fruit, "Shell Color", "Dark brown, Brown, Red, Orange, Yellow ???");
            AddKeyValuePairToCollection(Fruit, "Kernel Color", "Milky White, Dark Yellow?");
            AddKeyValuePairToCollection(Fruit, "Peeling", variety.Peeling.ToString());
            AddKeyValuePairToCollection(Fruit, "Conservation", "Medium");
            AddKeyValuePairToCollection(Fruit, "Nuts per Bur", "3");
            AddKeyValuePairToCollection(Fruit, "Hilum Size", "Large");            
            AddKeyValuePairToCollection(Fruit, "Shell Type", "Fuzzy, Shiny?");

            SpeciesCheckboxes = speciesCheckboxes;
            ThumbnailImagePath = variety.Images.Any()
                ? $"/Images/Varieties/{variety.VarietyId}/{variety.Images.First().FileName}.jpg"
                : $"/Images/no-image.jpg";
        }

        private void AddKeyValuePairToCollection(List<KeyValuePair<string, string>> collection, string key, string? value)
        {
            //if (string.IsNullOrEmpty(value))
            //{
            //    return;
            //}

            collection.Add(new KeyValuePair<string, string>(key, value ?? "None"));
        }

        private static string GetStringFromNullableBoolean(bool? isMarron)
        {
            return isMarron != null
                ? (bool)isMarron
                    ? "\u2713"
                    : "\u2717"
                : "";
        }
    }
}

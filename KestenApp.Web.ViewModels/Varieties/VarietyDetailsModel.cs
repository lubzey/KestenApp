using KestenApp.Data.Models;

namespace KestenApp.Web.Models.Varieties
{
    public class VarietyDetailsModel
    {
        public Guid VarietyId;
        public string VarietyName;
        public string Description;
        public List<KeyValuePair<string, string>> Tree = new List<KeyValuePair<string, string>>();
        public List<KeyValuePair<string, string>> Fruit = new List<KeyValuePair<string, string>>();
        public IList<CheckboxModel> SpeciesCheckboxes;
        public string ThumbnailImagePath;

        public VarietyDetailsModel(Variety variety, IList<CheckboxModel> speciesCheckboxes)
        {
            VarietyId = variety.VarietyId;
            VarietyName = variety.Name;
            Description = variety.Description;

            //Tree
            AddKeyValuePairToCollection(Tree, "Pollen", variety.PollenType.ToString());
            AddKeyValuePairToCollection(Tree, "Vigor", variety.Vigor.ToString());
            AddKeyValuePairToCollection(Tree, "Erect", "Semi-Erect, Very Erect, Apical Dominance");
            AddKeyValuePairToCollection(Tree, "Budding Period", "VeryEarly, Early, SemiEarly, SemiLate, Late, VeryLate");
            AddKeyValuePairToCollection(Tree, "Flowering Period", "VeryEarly, Early, SemiEarly, SemiLate, Late, VeryLate");
            AddKeyValuePairToCollection(Tree, "Maturity Period", "VeryEarly, Early, SemiEarly, SemiLate, Late, VeryLate");
            AddKeyValuePairToCollection(Tree, "Blight Resistance", variety.ChestnutBlightResistance.ToString());
            AddKeyValuePairToCollection(Tree, "Ink Disease Resistance", variety.InkDiseaseResistance.ToString());
            AddKeyValuePairToCollection(Tree, "Gall Wasp Resistance", "Bad, Medium, Good");
            AddKeyValuePairToCollection(Tree, "Cold Hardiness", "Bad, Medium, Good");
            AddKeyValuePairToCollection(Tree, "Spring Frost Sensitivity", "True/False/None V/X/");
            AddKeyValuePairToCollection(Tree, "Kernel Rot Susceptibility", "True/False/None V/X/");
            AddKeyValuePairToCollection(Tree, "Catkins Type", "astamine, brachistamine, mesostamine, longistamine");
            AddKeyValuePairToCollection(Tree, "Crop Volume", "Poor, Medium, Abundant");

            //Rootstock and pollentation

            //Fruit
            AddKeyValuePairToCollection(Fruit, "Taste", "Bad, Medium, Good");
            AddKeyValuePairToCollection(Fruit, "Size", string.Join(", ", variety.FruitSizes.Select(s => s.FruitSize.Name)));
            AddKeyValuePairToCollection(Fruit, "Is Marron", GetStringFromNullableBoolean(variety.IsMarron)); //<12%
            AddKeyValuePairToCollection(Fruit, "Kernel Splitting", "None,Some,Many?");
            AddKeyValuePairToCollection(Fruit, "Kernel Intrusion", "Deep,Shallow,None");
            AddKeyValuePairToCollection(Fruit, "Shape", "Oval, Triangular, Irregular ???");
            AddKeyValuePairToCollection(Fruit, "Shell Color", "Dark brown, Brown, Red, Orange, Yellow ???");
            AddKeyValuePairToCollection(Fruit, "Kernel Color", "Milky White, Dark Yellow?");
            AddKeyValuePairToCollection(Fruit, "Peeling", variety.Peeling.ToString());
            AddKeyValuePairToCollection(Fruit, "Conservation", "Medium");
            AddKeyValuePairToCollection(Fruit, "Nuts per Bur", "3");
            AddKeyValuePairToCollection(Fruit, "Hilum Size", "Small, Medium, Large");
            AddKeyValuePairToCollection(Fruit, "Shell Type", "Fuzzy, Shiny?");

            SpeciesCheckboxes = speciesCheckboxes;
            ThumbnailImagePath = variety.VarietyImages.Any()
                ? $"/Images/Varieties/{variety.VarietyId}/{variety.VarietyImages.First().ImageId}.jpg"
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

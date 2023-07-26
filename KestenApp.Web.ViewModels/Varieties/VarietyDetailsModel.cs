﻿using KestenApp.Data.Enums;
using KestenApp.Data.Models;

namespace KestenApp.Web.ViewModels.Varieties
{
    public class VarietyDetailsModel
    {
        public Guid VarietyId { get; }
        public string VarietyName { get; }
        public string Description { get; }
        public bool HideArchiveButton { get; }
        public bool HideRestoreButton { get; }
        public bool HidePublishButton { get; }
        public bool HideUnpublishButton { get; }

        public List<KeyValuePair<string, string>> Tree = new List<KeyValuePair<string, string>>();
        public List<KeyValuePair<string, string>> Fruit = new List<KeyValuePair<string, string>>();
        public IList<CheckboxModel> SpeciesCheckboxes;
        public string ThumbnailImagePath;

        public VarietyDetailsModel(Variety variety, IList<CheckboxModel> speciesCheckboxes)
        {
            VarietyId = variety.VarietyId;
            VarietyName = variety.Name;
            Description = variety.Description;

            HideArchiveButton = !variety.IsActive;
            HideRestoreButton = !HideArchiveButton;
            HidePublishButton = variety.IsPublished || !variety.IsActive;
            HideUnpublishButton = !variety.IsPublished || !variety.IsActive;

            //Tree
            AddKeyValuePairToCollection(Tree, "Blight Resistance", GetStringFromEnum<ConditionType>((int)variety.ChestnutBlightResistance));
            AddKeyValuePairToCollection(Tree, "Ink Disease Resistance", GetStringFromEnum<ConditionType>((int)variety.InkDiseaseResistance));

            AddKeyValuePairToCollection(Tree, "Pollen", GetStringFromEnum<PollenType>((int)variety.PollenType));
            AddKeyValuePairToCollection(Tree, "Vigor", GetStringFromEnum<StrengthType>((int)variety.Vigor));
            //AddKeyValuePairToCollection(Tree, "Erect*", "Semi-Erect, Very Erect, Apical Dominance");

            AddKeyValuePairToCollection(Tree, "Budding Period", GetStringFromEnum<PeriodType>((int)variety.BuddingPeriod));
            AddKeyValuePairToCollection(Tree, "Flowering Period", GetStringFromEnum<PeriodType>((int)variety.FloweringPeriod));
            AddKeyValuePairToCollection(Tree, "Maturity Period", GetStringFromEnum<PeriodType>((int)variety.MaturityPeriod));

            //AddKeyValuePairToCollection(Tree, "Gall Wasp Resistance*", "Bad, Medium, Good");
            //AddKeyValuePairToCollection(Tree, "Cold Hardiness*", "Bad, Medium, Good");
            //AddKeyValuePairToCollection(Tree, "Spring Frost Sensitivity*", "True/False/None V/X/");
            //AddKeyValuePairToCollection(Tree, "Kernel Rot Susceptibility*", "True/False/None V/X/");
            //AddKeyValuePairToCollection(Tree, "Catkins Type*", "astamine, brachistamine, mesostamine, longistamine");
            AddKeyValuePairToCollection(Tree, "Crop Volume", GetStringFromEnum<VolumeType>((int)variety.Crop));

            //Rootstock and pollentation

            //Fruit
            //AddKeyValuePairToCollection(Fruit, "Taste*", "Bad, Medium, Good");
            AddKeyValuePairToCollection(Fruit, "Size", string.Join(", ", variety.FruitSizes.Select(s => s.FruitSize.Name)));
            AddKeyValuePairToCollection(Fruit, "Is Marron", GetStringFromNullableBoolean(variety.IsMarron)); //<12%
            //AddKeyValuePairToCollection(Fruit, "Kernel Splitting*", "None,Some,Many?");
            //AddKeyValuePairToCollection(Fruit, "Kernel Intrusion*", "Deep,Shallow,None");
            //AddKeyValuePairToCollection(Fruit, "Shape*", "Oval, Triangular, Irregular ???");
            //AddKeyValuePairToCollection(Fruit, "Shell Color*", "Dark brown, Brown, Red, Orange, Yellow ???");
            //AddKeyValuePairToCollection(Fruit, "Kernel Color*", "Milky White, Dark Yellow?");
            AddKeyValuePairToCollection(Fruit, "Peeling", GetStringFromEnum<ConditionType>((int)variety.Peeling));
            AddKeyValuePairToCollection(Fruit, "Conservation", GetStringFromEnum<ConditionType>((int)variety.Conservation));
            //AddKeyValuePairToCollection(Fruit, "Nuts per Bur*", "3");
            //AddKeyValuePairToCollection(Fruit, "Hilum Size*", "Small, Medium, Large");
            //AddKeyValuePairToCollection(Fruit, "Shell Type*", "Fuzzy, Shiny?");

            SpeciesCheckboxes = speciesCheckboxes;
            ThumbnailImagePath = variety.VarietyImages.Any()
                ? $"/Images/Varieties/{variety.VarietyId}/{variety.VarietyImages.First().ImageId}.jpg"
                : $"/Images/no-image.jpg";
        }

        private void AddKeyValuePairToCollection(List<KeyValuePair<string, string>> collection, string key, string? value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return;
            }

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

        public static string GetStringFromEnum<TEnum>(int value) where TEnum : Enum
        {
            if (value > 0 && Enum.IsDefined(typeof(TEnum), value))
            {
                return Enum.GetName(typeof(TEnum), value) ?? "";
            }

            return "";
        }
    }
}

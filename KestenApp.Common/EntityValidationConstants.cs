namespace KestenApp.Common
{
    public static class EntityValidationConstants
    {
        public static class Variety
        {
            public const int NameMinLength = 2;
            public const int NameMaxLength = 50;

            public const int DescriptionMinLength = 5;
            public const int DescriptionMaxLength = 1000;
        }

        public static class Specimen
        {
            public const int NameMinLength = 2;
            public const int NameMaxLength = 30;

            public const int LocationPrecision = 9;
            public const int LocationScale = 6;
        }

        public static class Garden
        {
            public const int NameMinLength = 2;
            public const int NameMaxLength = 30;
        }
    }
}
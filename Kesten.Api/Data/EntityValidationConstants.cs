namespace Kesten.Api.Data
{
    public static class EntityValidationConstants
    {
        public static class VarietyConstants
        {
            public const int NameMinLength = 2;
            public const int NameMaxLength = 50;

            public const int DescriptionMinLength = 5;
            public const int DescriptionMaxLength = 1000;
        }

        public static class SpecimenConstants
        {
            public const int NameMinLength = 2;
            public const int NameMaxLength = 30;

            public const int LocationPrecision = 9;
            public const int LocationScale = 6;
        }

        public static class GardenConstants
        {
            public const int NameMinLength = 2;
            public const int NameMaxLength = 30;

            public const int MinRowColumns = 0;
            public const int MaxRowColumns = 5;

            public const int MinElevation = 0;
            public const int MaxElevation = 5000;
        }

        public static class UserConstants
        {
            public const int NameMinLength = 2;
            public const int NameMaxLength = 20;

            public const int PasswordMinLength = 6;
            public const int PasswordMaxLength = 100;
        }
    }
}
namespace KestenApp.Data.Enums
{
    using System.ComponentModel;

    public enum StrengthType
    {
        None = 0,
        Weak = 1,
        Medium = 2,
        Strong = 3,
        [Description("Very Strong")]
        VeryStrong = 4
    }
}

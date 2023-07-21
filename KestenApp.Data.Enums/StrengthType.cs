using System.ComponentModel.DataAnnotations;

namespace KestenApp.Data.Enums
{
    public enum StrengthType
    {
        None = 0,
        Weak = 1,
        Medium = 2,
        Strong = 3,
        [Display(Name = "Very strong")]
        VeryStrong = 4
    }
}

using System.ComponentModel.DataAnnotations;

namespace KestenTestApp.Models.Enums
{
    public enum FruitSizeEnum
    {
        Varying = 0,
        [Range(0, 12)]
        Small = 1,
        [Range(12, 15)]
        Medium = 2,
        [Range(12, 18)]
        Large = 3,
        [Range(18, double.MaxValue)]
        XL = 4
    }
}
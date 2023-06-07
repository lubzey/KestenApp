using System.ComponentModel.DataAnnotations;

namespace KestenTestApp.Models.Enums
{
    public enum FruitSizeEnum
    {
        Varying = 1,
        [Range(0, 12)]
        Small = 2,
        [Range(12, 15)]
        Medium = 3,
        [Range(12, 18)]
        Large = 4,
        [Range(18, double.MaxValue)]
        XL = 5
    }
}
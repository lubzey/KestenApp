using KestenTestApp.Models.EnumHelpers;

namespace KestenTestApp.Models.Enums
{
    public enum FruitSizeEnum
    {
        Varying = 1,

        [RangeInt(84, 1000, IntRangeEnum.FruitsPerKg)]
        [RangeInt(1, 12, IntRangeEnum.FruitWeight)]
        Small = 2,

        [RangeInt(67, 83, IntRangeEnum.FruitsPerKg)]
        [RangeInt(13, 15, IntRangeEnum.FruitWeight)]
        Medium = 3,

        [RangeInt(56, 66, IntRangeEnum.FruitsPerKg)]
        [RangeInt(16, 18, IntRangeEnum.FruitWeight)]
        Large = 4,

        [RangeInt(15, 55, IntRangeEnum.FruitsPerKg)]
        [RangeInt(18, 100, IntRangeEnum.FruitWeight)]
        XL = 5
    }
}
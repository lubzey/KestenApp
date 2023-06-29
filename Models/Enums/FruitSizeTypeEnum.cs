using KestenTestApp.Models.Enums.EnumHelpers;

namespace KestenTestApp.Models.Enums
{
    public enum FruitSizeTypeEnum
    {
        Varying = 1,

        [RangeInt(84, 1000, IntRangeTypeEnum.FruitsPerKg)]
        [RangeInt(1, 12, IntRangeTypeEnum.FruitWeight)]
        Small = 2,

        [RangeInt(67, 83, IntRangeTypeEnum.FruitsPerKg)]
        [RangeInt(13, 15, IntRangeTypeEnum.FruitWeight)]
        Medium = 3,

        [RangeInt(56, 66, IntRangeTypeEnum.FruitsPerKg)]
        [RangeInt(16, 18, IntRangeTypeEnum.FruitWeight)]
        Large = 4,

        [RangeInt(15, 55, IntRangeTypeEnum.FruitsPerKg)]
        [RangeInt(18, 100, IntRangeTypeEnum.FruitWeight)]
        XL = 5
    }
}
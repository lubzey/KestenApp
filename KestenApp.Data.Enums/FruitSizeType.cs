namespace KestenApp.Data.Enums
{
    using KestenApp.Data.Enums.EnumHelpers;

    public enum FruitSizeType
    {
        Varying = 1,

        [RangeInt(84, 1000, IntRangeType.FruitsPerKg)]
        [RangeInt(1, 12, IntRangeType.FruitWeight)]
        Small = 2,

        [RangeInt(67, 83, IntRangeType.FruitsPerKg)]
        [RangeInt(13, 15, IntRangeType.FruitWeight)]
        Medium = 3,

        [RangeInt(56, 66, IntRangeType.FruitsPerKg)]
        [RangeInt(16, 18, IntRangeType.FruitWeight)]
        Large = 4,

        [RangeInt(15, 55, IntRangeType.FruitsPerKg)]
        [RangeInt(18, 100, IntRangeType.FruitWeight)]
        XL = 5
    }
}
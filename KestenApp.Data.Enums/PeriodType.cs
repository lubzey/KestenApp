namespace KestenApp.Data.Enums
{
    using System.ComponentModel;

    public enum PeriodType
    {
        None = 0,
        [Description("Very Early")]
        VeryEarly = 1,
        Early = 2,
        [Description("Semi Early")]
        SemiEarly = 3,
        [Description("Semi Late")]
        SemiLate = 4,
        Late = 5,
        [Description("Very Late")]
        VeryLate = 6
    }
}
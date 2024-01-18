namespace Kesten.Shared.Enums
{
    using System.ComponentModel;

    public enum ConditionType
    {
        [Description("Not Selected")]
        NotSelected = 0,
        Bad = 1,
        Medium = 2,
        Good = 3
    }
}
using System.ComponentModel;

namespace Kesten.Shared.Enums
{
    public enum VolumeType
    {
        [Description("Not Selected")]
        NotSelected = 0,
        Scarce = 1,
        Average = 2,
        Abundant = 3
    }
}

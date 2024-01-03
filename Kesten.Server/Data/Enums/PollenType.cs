﻿using System.ComponentModel;

namespace Kesten.Server.Data.Enums
{
    public enum PollenType
    {
        [Description("Not Selected")]
        NotSelected = 0,
        Sterile = 1,
        Medium = 2,
        Abundant = 3
    }
}

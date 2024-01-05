﻿using Kesten.Server.Data.Enums.EnumHelpers;
using Kesten.Server.Models.Shared;

namespace Kesten.Server.Common
{
    internal static class ServiceExtensions
    {
        internal static string JoinStrings(IEnumerable<string> names)
        {
            string separator = $",{Environment.NewLine}";
            return string.Join(separator, names);
        }

        internal static string GetStringFromNullableBoolean(bool? isMarron)
        {
            return isMarron != null
                ? (bool)isMarron
                    ? "\u2713"
                    : "\u2717"
                : "";
        }

        internal static IEnumerable<DropdownModel> MapDropdown<T>() where T : Enum
        {
            return EnumExtensions
                .GetEnumValuesCollection<T>()
                .Select(p => new DropdownModel
                {
                    Id = (int)(object)p,
                    Name = EnumExtensions.GetStringFromEnumValue<T>(p)
                }).ToList();
        }
    }
}

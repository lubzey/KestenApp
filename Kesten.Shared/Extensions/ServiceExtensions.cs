using Kesten.Shared.Enums.EnumHelpers;
using Kesten.Shared.Models.Shared;

namespace Kesten.Shared.Extensions
{
    public static class ServiceExtensions
    {
        public static string JoinStrings(IEnumerable<string> names)
        {
            string separator = $",{Environment.NewLine}";
            return string.Join(separator, names);
        }

        public static string GetStringFromNullableBoolean(bool? isMarron)
        {
            return isMarron != null
                ? (bool)isMarron
                    ? "\u2713"
                    : "\u2717"
                : "";
        }

        public static IEnumerable<DropdownModel> MapDropdown<T>() where T : Enum
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

using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace KestenTestApp.Models.Enums.EnumHelpers
{
    public static class EnumExtensions
    {
        public static string? GetDisplayName(this Enum enumValue)
        {
            return enumValue.GetType()
              .GetMember(enumValue.ToString())
              .First()
              .GetCustomAttribute<DisplayAttribute>()
              ?.GetName();
        }

        public static string? GetDescription(this Enum enumValue)
        {
            return enumValue.GetType()
              .GetMember(enumValue.ToString())
              .First()
              .GetCustomAttribute<DisplayAttribute>()
              ?.GetDescription();
        }

        public static RangeAttribute? GetRange(this Enum enumValue)
        {
            return enumValue.GetType()
              .GetMember(enumValue.ToString())
              .First()
              .GetCustomAttribute<RangeAttribute>();
        }

        public static List<TAttribute> GetAttributes<TAttribute>(this Enum value)
        where TAttribute : Attribute
        {
            var enumType = value.GetType();
            string name = Enum.GetName(enumType, value) ?? "";

            return enumType
                .GetField(name)
                ?.GetCustomAttributes(false)
                .OfType<TAttribute>()
                .ToList() ?? new List<TAttribute>();
        }

        public static IReadOnlyList<T> GetEnumValuesCollection<T>()
        {
            return Enum.GetValues(typeof(T)).Cast<T>().ToList();
        }
    }
}

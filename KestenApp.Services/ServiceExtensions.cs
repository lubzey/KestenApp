namespace KestenApp.Services
{
    internal static class ServiceExtensions
    {
        internal static string GetStringValueOfNullableEnum<T>(T enumValue)
        {
            if (enumValue == null
                || enumValue.ToString() == "None")
            {
                return "";
            }

            return Enum.GetName(typeof(T), enumValue) ?? "";
        }

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
    }
}

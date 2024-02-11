using System.Globalization;

namespace Vertr.Moex.Generators;
internal static class StringExtensions
{
    private static readonly TextInfo _textInfo = new CultureInfo("en-US", false).TextInfo;

    public static string ToTitleCase(this string source)
        => _textInfo.ToTitleCase(source);
}

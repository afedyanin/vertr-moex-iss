using System.Globalization;

namespace Vertr.Moex.Generators;

internal class EngineMeta
{
    private static readonly TextInfo _textInfo = new CultureInfo("en-US", false).TextInfo;

    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Title { get; set; } = string.Empty;

    public string PropertyName => _textInfo.ToTitleCase(Name);
}

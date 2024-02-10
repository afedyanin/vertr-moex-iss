using System.Globalization;
using System.Text.Json;

namespace Vertr.Moex.Generators;

internal class EngineMeta
{
    private static readonly TextInfo _textInfo = new CultureInfo("en-US", false).TextInfo;

    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Title { get; set; } = string.Empty;

    public string PropertyName => _textInfo.ToTitleCase(Name);

    public static EngineMeta[] LoadEngines(string json)
    {
        using var jdoc = JsonDocument.Parse(json);
        var enginesJson = jdoc.RootElement.GetProperty("engines");
        return MetaItemFactory.CreateEngines(enginesJson);
    }
}

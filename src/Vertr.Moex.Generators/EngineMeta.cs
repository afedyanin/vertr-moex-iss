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

    public static EngineMeta[] LoadEngines()
    {
        using var jdoc = JsonDocument.Parse(Resources.EnginesJson);
        var enginesJson = jdoc.RootElement.GetProperty("engines");
        var columns = enginesJson.GetProperty("columns").Deserialize<string[]>();

        var idxId = Array.IndexOf(columns!, "id");
        var idxName = Array.IndexOf(columns!, "name");
        var idxTitle = Array.IndexOf(columns!, "title");

        var engines = new List<EngineMeta>();

        foreach (var item in enginesJson.GetProperty("data").EnumerateArray())
        {
            engines.Add(new EngineMeta
            {
                Id = item[idxId].GetInt32(),
                Name = item[idxName].GetString()!,
                Title = item[idxTitle].GetString()!,
            });
        }

        return [.. engines];
    }
}

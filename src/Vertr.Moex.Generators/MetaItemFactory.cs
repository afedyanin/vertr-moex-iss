using System.Text.Json;

namespace Vertr.Moex.Generators;
internal class MetaItemFactory
{
    public EngineMeta[] Engines { get; } = new EngineMeta[0];

    public MetaItemFactory(string? json)
    {
        if (string.IsNullOrEmpty(json))
        {
            return;
        }

        var dict = CreateJsonDataDictionary(json!);
        Engines = CreateEngines(dict["engines"]);
    }

    private static EngineMeta[] CreateEngines(JsonElement enginesJson)
    {
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

    private static Dictionary<string, JsonElement> CreateJsonDataDictionary(string json)
    {
        var jDoc = JsonDocument.Parse(json);
        var root = jDoc.RootElement;

        var dict = new Dictionary<string, JsonElement>
        {
            { "engines", root.GetProperty("engines") },
            { "markets", root.GetProperty("markets") },
            { "boards", root.GetProperty("boards") },
            { "boardgroups", root.GetProperty("boardgroups") },
            { "durations", root.GetProperty("durations") },
            { "securitytypes", root.GetProperty("securitytypes") },
            { "securitygroups", root.GetProperty("securitygroups") },
            { "securitycollections", root.GetProperty("securitycollections") }
        };

        return dict;
    }
}

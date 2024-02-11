using System.Text.Json;

namespace Vertr.Moex.Generators.MetaItems.Factories;
internal static class EngineMetaFactory
{
    /*
        "metadata": {
            "id": {"type": "int32"},
            "name": {"type": "string", "bytes": 45, "max_size": 0},
            "title": {"type": "string", "bytes": 765, "max_size": 0}
        },
     */

    public static EngineMeta[] CreateEngines(JsonElement enginesJson)
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
}

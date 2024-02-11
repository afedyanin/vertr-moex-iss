using System.Text.Json;

namespace Vertr.Moex.Generators.MetaItems.Factories;
internal static class DurationMetaFactory
{
    /*
	"metadata": {
		"interval": {"type": "int32"},
		"duration": {"type": "int32"},
		"days": {"type": "int32"},
		"title": {"type": "string", "bytes": 765, "max_size": 0},
		"hint": {"type": "string", "bytes": 765, "max_size": 0}
	},
     */

    public static DurationMeta[] CreateDurations(JsonElement boardsJson)
    {
        var columns = boardsJson.GetProperty("columns").Deserialize<string[]>();

        var idxInterval = Array.IndexOf(columns!, "interval");
        var idxDuration = Array.IndexOf(columns!, "duration");
        var idxTitle = Array.IndexOf(columns!, "title");
        var idxHint = Array.IndexOf(columns!, "hint");

        var durations = new List<DurationMeta>();

        foreach (var item in boardsJson.GetProperty("data").EnumerateArray())
        {
            durations.Add(new DurationMeta
            {
                Interval = item[idxInterval].GetInt32(),
                Duration = item[idxDuration].GetInt32(),
                Title = item[idxTitle].GetString()!,
                Hint = item[idxHint].GetString()!,
            });
        }

        return [.. durations];
    }
}

using System.Text.Json;

namespace Vertr.Moex.Generators.MetaItems.Factories;

internal static class SecurityGroupMetaFactory
{
    /*
	"metadata": {
		"id": {"type": "int32"},
		"name": {"type": "string", "bytes": 93, "max_size": 0},
		"title": {"type": "string", "bytes": 765, "max_size": 0},
		"is_hidden": {"type": "int32"}
	},
     */

    public static SecurityGroupMeta[] CreateSecurityGroups(JsonElement securityGroupsJson)
    {
        var columns = securityGroupsJson.GetProperty("columns").Deserialize<string[]>();

        var idxId = Array.IndexOf(columns!, "id");
        var idxName = Array.IndexOf(columns!, "name");
        var idxTitle = Array.IndexOf(columns!, "title");
        var idxIsHidden = Array.IndexOf(columns!, "is_hidden");

        var securityGroups = new List<SecurityGroupMeta>();

        foreach (var item in securityGroupsJson.GetProperty("data").EnumerateArray())
        {
            securityGroups.Add(new SecurityGroupMeta
            {
                Id = item[idxId].GetInt32(),
                Name = item[idxName].GetString()!,
                Title = item[idxTitle].GetString()!,
                IsHidden = item[idxIsHidden].GetInt32() > 0,
            });
        }

        return [.. securityGroups];
    }
}

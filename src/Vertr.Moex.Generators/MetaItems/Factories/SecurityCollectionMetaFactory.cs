using System.Text.Json;

namespace Vertr.Moex.Generators.MetaItems.Factories;

internal static class SecurityCollectionMetaFactory
{
    /*
	"metadata": {
		"id": {"type": "int32"},
		"name": {"type": "string", "bytes": 96, "max_size": 0},
		"title": {"type": "string", "bytes": 765, "max_size": 0},
		"security_group_id": {"type": "int32"}
	},
     */

    public static SecurityCollectionMeta[] CreateSecurityCollections(JsonElement securityCollectionsJson)
    {
        var columns = securityCollectionsJson.GetProperty("columns").Deserialize<string[]>();

        var idxId = Array.IndexOf(columns!, "id");
        var idxName = Array.IndexOf(columns!, "name");
        var idxTitle = Array.IndexOf(columns!, "title");
        var idxSecurityGroupId = Array.IndexOf(columns!, "security_group_id");

        var securityCollections = new List<SecurityCollectionMeta>();

        foreach (var item in securityCollectionsJson.GetProperty("data").EnumerateArray())
        {
            securityCollections.Add(new SecurityCollectionMeta
            {
                Id = item[idxId].GetInt32(),
                Name = item[idxName].GetString()!,
                Title = item[idxTitle].GetString()!,
                SecurityGroupId = item[idxSecurityGroupId].GetInt32(),
            });
        }

        return [.. securityCollections];
    }
}

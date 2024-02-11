using System.Text.Json;

namespace Vertr.Moex.Generators.MetaItems.Factories;

internal static class SecurityTypeMetaFactory
{
    /*
	"metadata": {
		"id": {"type": "int32"},
		"trade_engine_id": {"type": "int32"},
		"trade_engine_name": {"type": "string", "bytes": 45, "max_size": 0},
		"trade_engine_title": {"type": "string", "bytes": 765, "max_size": 0},
		"security_type_name": {"type": "string", "bytes": 93, "max_size": 0},
		"security_type_title": {"type": "string", "bytes": 765, "max_size": 0},
		"security_group_name": {"type": "string", "bytes": 93, "max_size": 0},
		"stock_type": {"type": "string", "bytes": 3, "max_size": 0}
	},
     */

    public static SecurityTypeMeta[] CreateSecurityTypes(JsonElement securityTypesJson)
    {
        var columns = securityTypesJson.GetProperty("columns").Deserialize<string[]>();

        var idxId = Array.IndexOf(columns!, "id");
        var idxTradeEngineId = Array.IndexOf(columns!, "trade_engine_id");
        var idxName = Array.IndexOf(columns!, "security_type_name");
        var idxTitle = Array.IndexOf(columns!, "security_type_title");
        var idxGroupName = Array.IndexOf(columns!, "security_group_name");
        var idxStockType = Array.IndexOf(columns!, "stock_type");

        var securityTypes = new List<SecurityTypeMeta>();

        foreach (var item in securityTypesJson.GetProperty("data").EnumerateArray())
        {
            securityTypes.Add(new SecurityTypeMeta
            {
                Id = item[idxId].GetInt32(),
                EngineId = item[idxTradeEngineId].GetInt32(),
                Name = item[idxName].GetString()!,
                Title = item[idxTitle].GetString()!,
                GroupName = item[idxGroupName].GetString()!,
                StockType = item[idxStockType].GetString()!,
            });
        }

        return [.. securityTypes];
    }
}

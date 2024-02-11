using System.Text.Json;

namespace Vertr.Moex.Generators.MetaItems.Factories;
internal static class BoardGroupMetaFactory
{
    /*
	"metadata": {
		"id": {"type": "int32"},
		"trade_engine_id": {"type": "int32"},
		"trade_engine_name": {"type": "string", "bytes": 45, "max_size": 0},
		"trade_engine_title": {"type": "string", "bytes": 765, "max_size": 0},
		"market_id": {"type": "int32"},
		"market_name": {"type": "string", "bytes": 45, "max_size": 0},
		"name": {"type": "string", "bytes": 192, "max_size": 0},
		"title": {"type": "string", "bytes": 765, "max_size": 0},
		"is_default": {"type": "int32"},
		"board_group_id": {"type": "int32"},
		"is_traded": {"type": "int32"},
		"is_order_driven": {"type": "int32"},
		"category": {"type": "string", "bytes": 45, "max_size": 0}
	},
     */

    public static BoardGroupMeta[] CreateBoardGroups(JsonElement boardsJson)
    {
        var columns = boardsJson.GetProperty("columns").Deserialize<string[]>();

        var idxId = Array.IndexOf(columns!, "id");
        var idxEngineId = Array.IndexOf(columns!, "trade_engine_id");
        var idxMarketId = Array.IndexOf(columns!, "market_id");
        var idxName = Array.IndexOf(columns!, "name");
        var idxTitle = Array.IndexOf(columns!, "title");
        var idxIsDefault = Array.IndexOf(columns!, "is_default");
        var idxBoardGroupId = Array.IndexOf(columns!, "board_group_id");
        var idxIsTraded = Array.IndexOf(columns!, "is_traded");
        var idxIsOrderDriven = Array.IndexOf(columns!, "is_order_driven");
        var idxCategory = Array.IndexOf(columns!, "category");

        var boardGroups = new List<BoardGroupMeta>();

        foreach (var item in boardsJson.GetProperty("data").EnumerateArray())
        {
            boardGroups.Add(new BoardGroupMeta
            {
                Id = item[idxId].GetInt32(),
                EngineId = item[idxEngineId].GetInt32(),
                MarketId = item[idxMarketId].GetInt32(),
                Name = item[idxName].GetString()!,
                Title = item[idxTitle].GetString()!,
                IsDefault = item[idxIsDefault].GetInt32() > 0,
                BoardGroupId = item[idxBoardGroupId].GetInt32(),
                IsTraded = item[idxIsTraded].GetInt32() > 0,
                IsOrderDriven = item[idxIsOrderDriven].ValueKind != JsonValueKind.Null && item[idxIsOrderDriven].GetInt32() > 0,
                Category = item[idxCategory].GetString()!
            });
        }

        return [.. boardGroups];
    }
}

using System.Text.Json;

namespace Vertr.Moex.Generators.MetaItems.Factories;
internal static class BoardMetaFactory
{
    /*
        "metadata": {
            "id": {"type": "int32"},
            "board_group_id": {"type": "int32"},
            "engine_id": {"type": "int32"},
            "market_id": {"type": "int32"},
            "boardid": {"type": "string", "bytes": 12, "max_size": 0},
            "board_title": {"type": "string", "bytes": 381, "max_size": 0},
            "is_traded": {"type": "int32"},
            "has_candles": {"type": "int32"},
            "is_primary": {"type": "int32"}
        },
     */

    public static BoardMeta[] CreateBoards(JsonElement boardsJson)
    {
        var columns = boardsJson.GetProperty("columns").Deserialize<string[]>();

        var idxId = Array.IndexOf(columns!, "id");
        var idxBoardId = Array.IndexOf(columns!, "boardid");
        var idxTitle = Array.IndexOf(columns!, "board_title");
        var idxBoardGroupId = Array.IndexOf(columns!, "board_group_id");
        var idxEngineId = Array.IndexOf(columns!, "engine_id");
        var idxMarketId = Array.IndexOf(columns!, "market_id");
        var idxIsPrimary = Array.IndexOf(columns!, "is_primary");
        var idxHasCandles = Array.IndexOf(columns!, "has_candles");
        var idxIsTraded = Array.IndexOf(columns!, "is_traded");

        var boards = new List<BoardMeta>();

        foreach (var item in boardsJson.GetProperty("data").EnumerateArray())
        {
            boards.Add(new BoardMeta
            {
                Id = item[idxId].GetInt32(),
                BoardId = item[idxBoardId].GetString()!,
                Title = item[idxTitle].GetString()!,
                BoardGroupId = item[idxBoardGroupId].GetInt32(),
                EngineId = item[idxEngineId].GetInt32(),
                MarketId = item[idxMarketId].GetInt32(),
                IsPrimary = item[idxIsPrimary].GetInt32() > 0,
                HasCandles = item[idxHasCandles].GetInt32() > 0,
                IsTraded = item[idxIsTraded].GetInt32() > 0,
            });
        }

        return [.. boards];
    }
}

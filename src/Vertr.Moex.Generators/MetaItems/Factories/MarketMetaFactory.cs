using System.Text.Json;

namespace Vertr.Moex.Generators.MetaItems.Factories;

internal static class MarketMetaFactory
{
    /*
	"metadata": {
		"id": {"type": "int32"},
		"trade_engine_id": {"type": "int32"},
		"trade_engine_name": {"type": "string", "bytes": 45, "max_size": 0},
		"trade_engine_title": {"type": "string", "bytes": 765, "max_size": 0},
		"market_name": {"type": "string", "bytes": 45, "max_size": 0},
		"market_title": {"type": "string", "bytes": 765, "max_size": 0},
		"market_id": {"type": "int32"},
		"marketplace": {"type": "string", "bytes": 48, "max_size": 0},
		"is_otc": {"type": "int32"},
		"has_history_files": {"type": "int32"},
		"has_history_trades_files": {"type": "int32"},
		"has_trades": {"type": "int32"},
		"has_history": {"type": "int32"},
		"has_candles": {"type": "int32"},
		"has_orderbook": {"type": "int32"},
		"has_tradingsession": {"type": "int32"},
		"has_extra_yields": {"type": "int32"},
		"has_delay": {"type": "int32"}
	},
     */

    public static MarketMeta[] CreateMarkets(JsonElement marketsJson)
    {
        var columns = marketsJson.GetProperty("columns").Deserialize<string[]>();

        var idxId = Array.IndexOf(columns!, "id");
        var idxMarketId = Array.IndexOf(columns!, "market_id");
        var idxTradeEngineId = Array.IndexOf(columns!, "trade_engine_id");
        var idxName = Array.IndexOf(columns!, "market_name");
        var idxTitle = Array.IndexOf(columns!, "market_title");
        var idxPlace = Array.IndexOf(columns!, "marketplace");

        var markets = new List<MarketMeta>();

        foreach (var item in marketsJson.GetProperty("data").EnumerateArray())
        {
            markets.Add(new MarketMeta
            {
                Id = item[idxId].GetInt32(),
                Name = item[idxName].GetString()!,
                Title = item[idxTitle].GetString()!,
                MarketId = item[idxMarketId].GetInt32(),
                EngineId = item[idxTradeEngineId].GetInt32(),
                MarketPlace = item[idxPlace].GetString()!,
            });
        }

        return [.. markets];
    }
}

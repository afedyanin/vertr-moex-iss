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
        var idxTradeEngineName = Array.IndexOf(columns!, "trade_engine_name");
        var idxName = Array.IndexOf(columns!, "market_name");
        var idxTitle = Array.IndexOf(columns!, "market_title");
        var idxPlace = Array.IndexOf(columns!, "marketplace");
        var idxIsOtc = Array.IndexOf(columns!, "is_otc");
        var idxHasHistoryFiles = Array.IndexOf(columns!, "has_history_files");
        var idxHasHistoryTradesFiles = Array.IndexOf(columns!, "has_history_trades_files");
        var idxHasTrades = Array.IndexOf(columns!, "has_trades");
        var idxHasHistory = Array.IndexOf(columns!, "has_history");
        var idxHasCandles = Array.IndexOf(columns!, "has_candles");
        var idxHasOrderBook = Array.IndexOf(columns!, "has_orderbook");
        var idxHasTradingSession = Array.IndexOf(columns!, "has_tradingsession");
        var idxHasExtraYields = Array.IndexOf(columns!, "has_extra_yields");
        var idxHasDelay = Array.IndexOf(columns!, "has_delay");


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
                EngineName = item[idxTradeEngineName].GetString()!,
                MarketPlace = item[idxPlace].GetString()!,
                IsOtc = item[idxIsOtc].GetInt32() > 0,
                HasHistoryFiles = item[idxHasHistoryFiles].GetInt32() > 0,
                HasHistoryTradesFiles = item[idxHasHistoryTradesFiles].GetInt32() > 0,
                HasTrades = item[idxHasTrades].GetInt32() > 0,
                HasHistory = item[idxHasHistory].GetInt32() > 0,
                HasCandles = item[idxHasCandles].GetInt32() > 0,
                HasOrderBook = item[idxHasOrderBook].GetInt32() > 0,
                HasTradingSession = item[idxHasTradingSession].GetInt32() > 0,
                HasExtraYields = item[idxHasExtraYields].GetInt32() > 0,
                HasDelay = item[idxHasDelay].GetInt32() > 0,
            });
        }

        return [.. markets];
    }
}

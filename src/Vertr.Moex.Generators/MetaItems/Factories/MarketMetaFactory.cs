using System.Text.Json;

namespace Vertr.Moex.Generators.MetaItems.Factories;

internal static class MarketMetaFactory
{
    public static MarketMeta[] CreateMarkets(JsonElement marketsJson)
    {
        var columns = marketsJson.GetProperty("columns").Deserialize<string[]>();

        var idxId = Array.IndexOf(columns!, "id");
        var idxMarketId = Array.IndexOf(columns!, "market_id");
        var tradeEngineId = Array.IndexOf(columns!, "trade_engine_id");
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
                TradeEngineId = item[tradeEngineId].GetInt32(),
                MarketPlace = item[idxPlace].GetString()!,
            });
        }

        return [.. markets];
    }
}

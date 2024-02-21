using System.Text.Json;
using Microsoft.Data.Analysis;
using Vertr.Moex.Iss.Entities;
using Vertr.Moex.Iss.Extensions;

namespace Vertr.Moex.Iss;
public class MoexIssApi(string? baseUrl = null)
{
    private const string _defaulBaseUrl = "https://iss.moex.com/iss";

    private readonly string _baseUrl = baseUrl ?? _defaulBaseUrl;

    public async Task<DataFrame[]> Securities(
        Engine engine,
        Market market,
        InfoBlockKey[] blocks)
    {
        var url = new UrlBuilder(_baseUrl)
            .Engines(engine)
            .Markets(market)
            .Securities()
            .OnlyBlocks(blocks)
            .Build();

        return await FetchData(url, blocks);
    }

    public async Task<DataFrame[]> SecurityColumns(
        Engine engine,
        Market market,
        InfoBlockKey[] blocks)
    {
        var url = new UrlBuilder(_baseUrl)
            .Engines(engine)
            .Markets(market)
            .Securities()
            .Columns
            .OnlyBlocks(blocks)
            .Build();

        return await FetchData(url, blocks);
    }

    public async Task<DataFrame> Trades(
        Engine engine,
        Market market,
        string secId)
    {
        var blocks = new InfoBlockKey[] { InfoBlockKey.Trades };
        var url = new UrlBuilder(_baseUrl)
            .Engines(engine)
            .Markets(market)
            .Securities(secId)
            .Trades
            .OnlyBlocks(blocks)
            .Build();

        var frames = await FetchData(url, blocks);

        return frames.First();
    }

    private async Task<DataFrame[]> FetchData(string url, InfoBlockKey[] blocks)
    {
        // TODO: Use HttpClientFactory
        using var httpClient = new HttpClient();

        var json = await httpClient.GetStringAsync(url);
        var jDoc = JsonDocument.Parse(json);

        var res = new List<DataFrame>();

        foreach (var block in blocks)
        {
            if (!jDoc.ContainsRootProperty(block.Name))
            {
                continue;
            }
            var infoBlock = new InfoBlock(block, json);
            res.Add(infoBlock.ToDataFrame());
        }

        return [.. res];
    }
}

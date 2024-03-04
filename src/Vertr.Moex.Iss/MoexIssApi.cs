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
            .IssBlocks(blocks)
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
            .IssBlocks(blocks)
            .Build();

        return await FetchData(url, blocks);
    }

    public async Task<DataFrame> Trades(
        Engine engine,
        Market market,
        string secId,
        bool reversed = true)
    {
        var blocks = new InfoBlockKey[] { InfoBlockKey.Trades };
        var url = new UrlBuilder(_baseUrl)
            .Engines(engine)
            .Markets(market)
            .Securities(secId)
            .Trades
            .IssBlocks(blocks)
            .Reversed(reversed)
            .Build();

        var frames = await FetchData(url, blocks);

        return frames.First();
    }

    public async Task<DataFrame> Candles(
        Engine engine,
        Market market,
        Board? board,
        string secId,
        DateOnly from,
        DateOnly till,
        Duration interval,
        bool reversed = false)
    {
        var builder = new UrlBuilder()
            .Engines(engine)
            .Markets(market);

        if (board != null)
        {
            builder = builder.Boards(board);
        };

        builder = builder
            .Securities(secId)
            .Candles
            .IssReverse(true)
            .From(from)
            .To(till)
            .Interval(interval)
            .IssReverse(reversed);

        var pos = 0L;
        var df = await FetchCandleBatch(builder, pos);
        var count = df.Rows.Count;

        while (count > 0L)
        {
            pos += count;
            var batch = await FetchCandleBatch(builder, pos);
            count = batch.Rows.Count;
            df.Append(batch.Rows, true);
        }

        return df;
    }

    private async Task<DataFrame> FetchCandleBatch(UrlBuilder builder, long start = 0L)
    {
        var url = builder.Start(start).Build();
        // Console.WriteLine($"iss url={url}");

        var blocks = new InfoBlockKey[] { InfoBlockKey.Candles };
        var frames = await FetchData(url, blocks);
        var df = frames.First();

        return df;
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

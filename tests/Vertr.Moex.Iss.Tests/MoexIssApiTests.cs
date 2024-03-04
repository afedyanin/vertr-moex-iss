using System.Globalization;
using System.Text;
using Microsoft.Data.Analysis;
using Vertr.Moex.Iss.Entities;

namespace Vertr.Moex.Iss.Tests;

[TestFixture(Category = "Integration")]
public class MoexIssApiTests
{
    [Test]
    public async Task CanFetchSecurities()
    {
        var api = new MoexIssApi();

        var dfs = await api.Securities(
            Engine.Stock,
            Market.Stock_Bonds,
            [InfoBlockKey.Securities, InfoBlockKey.Marketdata]);

        Assert.That(dfs, Has.Length.EqualTo(2));

        Console.WriteLine(dfs[0]);
        Console.WriteLine("====================");
        Console.WriteLine(dfs[1]);
    }

    [Test]
    public async Task CanFetchSecurityColumns()
    {
        var api = new MoexIssApi();

        var dfs = await api.SecurityColumns(
            Engine.Stock,
            Market.Stock_Bonds,
            [InfoBlockKey.Securities, InfoBlockKey.Marketdata]);

        Assert.That(dfs, Has.Length.EqualTo(2));

        Console.WriteLine(dfs[0]);
        Console.WriteLine("====================");
        Console.WriteLine(dfs[1]);
    }

    [Test]
    public async Task CanFetchSecurityTrades()
    {
        var api = new MoexIssApi();

        var df = await api.Trades(
            Engine.Stock,
            Market.Stock_Shares,
            "GAZP");

        Assert.That(df, Is.Not.Null);

        Console.WriteLine(df);
    }

    [Test]
    public async Task CanValidateArrowColumns()
    {
        var api = new MoexIssApi();

        var dfs = await api.SecurityColumns(
            Engine.Stock,
            Market.Stock_Bonds,
            [InfoBlockKey.Securities]);

        foreach (var col in dfs[0].Columns)
        {
            Console.WriteLine($"name={col.Name} dataType={col.DataType.Name}");
        }
    }

    [Test]
    public async Task CanGetCandles()
    {
        var api = new MoexIssApi();

        var df = await api.Candles(
            Engine.Stock,
            Market.Stock_Shares,
            null,
            "SBER",
            new DateOnly(2024, 01, 01),
            new DateOnly(2024, 03, 01),
            Duration.H1);

        Assert.That(df, Is.Not.Null);

        df.PrettyPrint();
    }

    [Test]
    public async Task CanGetCandlesWithBoard()
    {
        var api = new MoexIssApi();

        var df = await api.Candles(
            Engine.Stock,
            Market.Stock_Shares,
            Board.TQBR,
            "SBER",
            new DateOnly(2024, 01, 01),
            new DateOnly(2024, 03, 01),
            Duration.H1);

        Assert.That(df, Is.Not.Null);

        df.PrettyPrint();
    }

    [Test]
    public async Task CanGetCandlesWithBatchRequests()
    {
        var api = new MoexIssApi();

        var df = await api.Candles(
            Engine.Stock,
            Market.Stock_Shares,
            Board.TQBR,
            "SBER",
            new DateOnly(2024, 01, 01),
            new DateOnly(2024, 03, 01),
            Duration.M1);

        Assert.That(df.Rows, Has.Count.GreaterThan(1000));
        // df.PrettyPrint();
    }

    [Test]
    public async Task CanSaveCandlesToCsvFile()
    {
        var file = "sample.csv";

        var api = new MoexIssApi();
        var df = await api.Candles(
            Engine.Stock,
            Market.Stock_Shares,
            Board.TQBR,
            "SBER",
            new DateOnly(2024, 01, 01),
            new DateOnly(2024, 03, 01),
            Duration.M1);

        var fs = File.Create(file);

        DataFrame.SaveCsv(df, fs, ';', true, Encoding.UTF8, CultureInfo.InvariantCulture);

        Assert.That(File.Exists(file));
    }
}

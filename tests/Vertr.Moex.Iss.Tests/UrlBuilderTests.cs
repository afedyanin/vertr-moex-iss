using Vertr.Moex.Iss.Entities;
using Vertr.Moex.Iss.UrlBuilderComponents;

namespace Vertr.Moex.Iss.Tests;

[TestFixture(Category = "Unit")]
public class UrlBuilderTests
{
    [Test]
    public void CanCreateSimpleUrl()
    {
        var url = new UrlBuilder()
            .Securities("SU26223RMFS6")
            .UsePrimaryBoard
            .UseFormat(OutFormat.Json)
            .UseLang(Language.Eng)
            .Build();

        Assert.That(url, Is.Not.Empty);
        Console.WriteLine($"url={url}");
    }

    [Test]
    public void CanBuildBondSecuritiesUrl()
    {
        var url = new UrlBuilder()
            .Engines(Engine.Stock)
            .Markets(Market.Stock_Bonds)
            .Securities()
            .IssMeta(false)
            .IssBlocks([InfoBlockKey.Securities])
            .Build();

        Assert.That(url, Is.Not.Empty);
        Console.WriteLine($"url={url}");
        Assert.That(url, Is.EqualTo("https://iss.moex.com/iss/engines/stock/markets/bonds/securities.json?iss.meta=off&iss.only=securities"));
    }

    [Test]
    public void CanBuildCandlesUrl()
    {
        var url = new UrlBuilder()
            .Engines(Engine.Stock)
            .Markets(Market.Stock_Shares)
            .Securities("SBER")
            .IssReverse(true)
            .IssMeta(true)
            .From(new DateOnly(2024, 02, 01))
            .To(new DateOnly(2024, 03, 01))
            .Interval(Duration.H1)
            .Start(0)
            .Candles
            .Build();

        Assert.That(url, Is.Not.Empty);
        Console.WriteLine($"url={url}");
        Assert.That(url, Is.EqualTo("https://iss.moex.com/iss/engines/stock/markets/shares/securities/SBER/candles.json?iss.reverse=true&iss.meta=on&from=2024-02-01&till=2024-03-01&interval=60&start=0"));
    }

    [Test]
    public void CanBuildCandlesUrlWithBoard()
    {
        var url = new UrlBuilder()
            .Engines(Engine.Stock)
            .Markets(Market.Stock_Shares)
            .Boards(Board.TQBR)
            .Securities("SBER")
            .IssReverse(true)
            .IssMeta(true)
            .From(new DateOnly(2024, 02, 01))
            .To(new DateOnly(2024, 03, 01))
            .Interval(Duration.H1)
            .Start(0)
            .Candles
            .Build();

        Assert.That(url, Is.Not.Empty);
        Console.WriteLine($"url={url}");
        Assert.That(url, Is.EqualTo("https://iss.moex.com/iss/engines/stock/markets/shares/boards/TQBR/securities/SBER/candles.json?iss.reverse=true&iss.meta=on&from=2024-02-01&till=2024-03-01&interval=60&start=0"));
    }

    [Test]
    public void CanReplaceQueryParams()
    {
        var builder = new UrlBuilder()
            .Engines(Engine.Stock)
            .Markets(Market.Stock_Shares)
            .Boards(Board.TQBR)
            .Securities("SBER")
            .IssReverse(true)
            .IssMeta(true)
            .From(new DateOnly(2024, 02, 01))
            .To(new DateOnly(2024, 03, 01))
            .Interval(Duration.H1);

        var url10 = builder.Start(10).Build();
        var url10new = builder.Start(10).Build();

        Console.WriteLine($"url10={url10}");
        Console.WriteLine($"url10new={url10new}");

        Assert.That(url10, Is.EqualTo(url10new));

        var url20 = builder.Start(20).Build();
        Console.WriteLine($"url20={url20}");
    }
}

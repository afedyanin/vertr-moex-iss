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
            .IncludeMeta(false)
            .OnlyBlocks([BlockNames.Securities])
            .Build();

        Assert.That(url, Is.Not.Empty);
        Console.WriteLine($"url={url}");
        Assert.That(url, Is.EqualTo("https://iss.moex.com/iss/engines/stock/markets/bonds/securities.json?iss.meta=off&iss.only=securities"));
    }

}

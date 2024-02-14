using Vertr.Moex.Iss.Entities;

namespace Vertr.Moex.Iss.Tests;

[TestFixture(Category = "Integration")]
public class DataFrameFactoryTests
{
    [Test]
    public async Task CanCreateDataFrameForBondSecurities()
    {
        var url = new UrlBuilder()
            .Engines(Engine.Stock)
            .Markets(Market.Stock_Bonds)
            .Securities()
            .IncludeMeta(false)
            .OnlyBlocks([BlockNames.Securities])
            .Build();

        using var http = new HttpClient();

        var res = await http.GetStringAsync(url, CancellationToken.None);
        Assert.That(res, Is.Not.Empty);

        Console.WriteLine(res);
    }
}

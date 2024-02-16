using System.Text.Json;
using Vertr.Moex.Iss.Entities;

namespace Vertr.Moex.Iss.Tests.Entities;

[TestFixture(Category = "Integration")]
public class InfoBlockTests
{
    [TestCase("JsonData/bonds.json")]
    [TestCase("JsonData/shares.json")]
    [TestCase("JsonData/bonds.columns.json")]
    [TestCase("JsonData/shares.columns.json")]
    public void CanCreateInfoBlockWithEmptyData(string fileName)
    {
        var json = File.ReadAllText(fileName);
        var jDoc = JsonDocument.Parse(json);

        var securitiesBlock = new InfoBlock("securities", jDoc);
        Assert.That(securitiesBlock, Is.Not.Null);
        Assert.That(securitiesBlock.Data.Columns, Is.Not.Empty);

        var marketDataBlock = new InfoBlock("marketdata", jDoc);
        Assert.That(marketDataBlock, Is.Not.Null);
        Assert.That(marketDataBlock.Data.Columns, Is.Not.Empty);

        var marketDataYieldsBlock = new InfoBlock("marketdata_yields", jDoc);
        Assert.That(marketDataYieldsBlock, Is.Not.Null);
        Assert.That(marketDataYieldsBlock.Data.Columns, Is.Not.Empty);
    }
}

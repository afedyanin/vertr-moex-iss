using System.Text.Json;
using Vertr.Moex.Iss.Entities;
using Vertr.Moex.Iss.Extensions;

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

        var securitiesBlock = new InfoBlock(InfoBlockKey.Securities, json);
        Assert.That(securitiesBlock, Is.Not.Null);

        var df = securitiesBlock.ToDataFrame();
        Assert.That(df.Columns, Is.Not.Empty);
    }

    [TestCase("JsonData/bonds.json")]
    [TestCase("JsonData/shares.json")]
    [TestCase("JsonData/bonds.columns.json")]
    [TestCase("JsonData/shares.columns.json")]
    public void CanFillDataFrameWithData(string fileName)
    {
        var json = File.ReadAllText(fileName);

        var block = new InfoBlock(InfoBlockKey.Marketdata, json);

        Assert.That(block, Is.Not.Null);

        var df = block.ToDataFrame();
        Assert.Multiple(() =>
        {
            Assert.That(df.Columns, Is.Not.Empty);
            Assert.That(df.Rows, Is.Not.Empty);
        });
    }

    [TestCase("JsonData/shares.columns.json")]
    public void CanParseRows(string fileName)
    {
        var json = File.ReadAllText(fileName);
        var jDoc = JsonDocument.Parse(json);
        var securitiesBlock = new InfoBlock(InfoBlockKey.Securities, jDoc);
        var jsonData = jDoc.RootElement.GetProperty("securities").GetProperty("data");

        var rows = securitiesBlock.ParseRows(jsonData);

        Assert.That(rows, Is.Not.Empty);
    }
}

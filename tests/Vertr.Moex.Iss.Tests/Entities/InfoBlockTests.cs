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

        var securitiesBlock = new InfoBlock(InfoBlockKey.Securities, json);
        Assert.That(securitiesBlock, Is.Not.Null);
        Assert.That(securitiesBlock.DataFrame.Columns, Is.Not.Empty);
    }

    [TestCase("JsonData/bonds.json")]
    [TestCase("JsonData/shares.json")]
    [TestCase("JsonData/bonds.columns.json")]
    [TestCase("JsonData/shares.columns.json")]
    public void CanFillDataFrameWithData(string fileName)
    {
        var json = File.ReadAllText(fileName);

        var block = new InfoBlock(InfoBlockKey.Marketdata, json, true);

        Assert.That(block, Is.Not.Null);
        Assert.Multiple(() =>
        {
            Assert.That(block.DataFrame.Columns, Is.Not.Empty);
            Assert.That(block.DataFrame.Rows, Is.Not.Empty);
        });
    }

    [TestCase("JsonData/shares.columns.json")]
    public void CanFillDataRows(string fileName)
    {
        var json = File.ReadAllText(fileName);
        var jDoc = JsonDocument.Parse(json);

        var securitiesBlock = new InfoBlock(InfoBlockKey.Securities, jDoc);
        var jsonData = jDoc.RootElement.GetProperty("securities").GetProperty("data");

        securitiesBlock.FillDataFrame(jsonData);
        var df = securitiesBlock.DataFrame;

        var table = df.ToString();
        Assert.That(table, Is.Not.Empty);
        Console.WriteLine(table);
    }
}

using System.Text.Json;
using Vertr.Moex.Iss.Entities;

namespace Vertr.Moex.Iss.Tests.Entities;

[TestFixture(Category = "Integration")]
public class InfoBlockTests
{
    [TestCase("JsonData/bonds.json", "securities")]
    [TestCase("JsonData/shares.json", "securities")]
    [TestCase("JsonData/bonds.columns.json", "securities")]
    [TestCase("JsonData/shares.columns.json", "securities")]
    [TestCase("JsonData/bonds.json", "marketdata")]
    [TestCase("JsonData/shares.json", "marketdata")]
    [TestCase("JsonData/bonds.columns.json", "marketdata")]
    [TestCase("JsonData/shares.columns.json", "marketdata")]
    [TestCase("JsonData/bonds.json", "marketdata_yields")]
    [TestCase("JsonData/shares.json", "marketdata_yields")]
    [TestCase("JsonData/bonds.columns.json", "marketdata_yields")]
    [TestCase("JsonData/shares.columns.json", "marketdata_yields")]
    public void CanCreateInfoBlockWithEmptyData(string fileName, string blockName)
    {
        var json = File.ReadAllText(fileName);

        var securitiesBlock = new InfoBlock(blockName, json);
        Assert.That(securitiesBlock, Is.Not.Null);
        Assert.That(securitiesBlock.Data.Columns, Is.Not.Empty);
    }

    [TestCase("JsonData/bonds.json", "securities")]
    [TestCase("JsonData/shares.json", "securities")]
    [TestCase("JsonData/bonds.columns.json", "securities")]
    [TestCase("JsonData/shares.columns.json", "securities")]
    [TestCase("JsonData/bonds.json", "marketdata")]
    [TestCase("JsonData/shares.json", "marketdata")]
    [TestCase("JsonData/bonds.columns.json", "marketdata")]
    [TestCase("JsonData/shares.columns.json", "marketdata")]
    [TestCase("JsonData/bonds.json", "marketdata_yields")]
    [TestCase("JsonData/shares.json", "marketdata_yields")]
    [TestCase("JsonData/bonds.columns.json", "marketdata_yields")]
    [TestCase("JsonData/shares.columns.json", "marketdata_yields")]
    public void CanFillDataFrameWithData(string fileName, string blockName)
    {
        var json = File.ReadAllText(fileName);

        var block = new InfoBlock(blockName, json, true);

        Assert.That(block, Is.Not.Null);
        Assert.Multiple(() =>
        {
            Assert.That(block.Data.Columns, Is.Not.Empty);
            Assert.That(block.Data.Rows, Is.Not.Empty);
        });
    }

    [TestCase("JsonData/shares.columns.json")]
    public void CanFillDataRows(string fileName)
    {
        var json = File.ReadAllText(fileName);
        var jDoc = JsonDocument.Parse(json);

        var securitiesBlock = new InfoBlock("securities", jDoc);
        var jsonData = jDoc.RootElement.GetProperty("securities").GetProperty("data");

        securitiesBlock.FillDataFrame(jsonData);
        var df = securitiesBlock.Data;

        var table = df.ToString();
        Assert.That(table, Is.Not.Empty);
        Console.WriteLine(table);
    }
}

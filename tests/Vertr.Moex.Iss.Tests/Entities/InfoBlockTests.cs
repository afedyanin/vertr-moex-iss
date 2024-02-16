using System.Text.Json;
using Vertr.Moex.Iss.Entities;

namespace Vertr.Moex.Iss.Tests.Entities;

[TestFixture(Category = "Integration")]
public class InfoBlockTests
{
    [TestCase("JsonData/bonds.json", InfoBlockKeys.Securities)]
    [TestCase("JsonData/shares.json", InfoBlockKeys.Securities)]
    [TestCase("JsonData/bonds.columns.json", InfoBlockKeys.Securities)]
    [TestCase("JsonData/shares.columns.json", InfoBlockKeys.Securities)]
    [TestCase("JsonData/bonds.json", InfoBlockKeys.Marketdata)]
    [TestCase("JsonData/shares.json", InfoBlockKeys.Marketdata)]
    [TestCase("JsonData/bonds.columns.json", InfoBlockKeys.Marketdata)]
    [TestCase("JsonData/shares.columns.json", InfoBlockKeys.Marketdata)]
    [TestCase("JsonData/bonds.json", InfoBlockKeys.MarketdataYields)]
    [TestCase("JsonData/shares.json", InfoBlockKeys.MarketdataYields)]
    [TestCase("JsonData/bonds.columns.json", InfoBlockKeys.MarketdataYields)]
    [TestCase("JsonData/shares.columns.json", InfoBlockKeys.MarketdataYields)]
    public void CanCreateInfoBlockWithEmptyData(string fileName, string blockName)
    {
        var json = File.ReadAllText(fileName);

        var securitiesBlock = new InfoBlock(blockName, json);
        Assert.That(securitiesBlock, Is.Not.Null);
        Assert.That(securitiesBlock.Data.Columns, Is.Not.Empty);
    }

    [TestCase("JsonData/bonds.json", InfoBlockKeys.Securities)]
    [TestCase("JsonData/shares.json", InfoBlockKeys.Securities)]
    [TestCase("JsonData/bonds.columns.json", InfoBlockKeys.Securities)]
    [TestCase("JsonData/shares.columns.json", InfoBlockKeys.Securities)]
    [TestCase("JsonData/bonds.json", InfoBlockKeys.Marketdata)]
    [TestCase("JsonData/shares.json", InfoBlockKeys.Marketdata)]
    [TestCase("JsonData/bonds.columns.json", InfoBlockKeys.Marketdata)]
    [TestCase("JsonData/shares.columns.json", InfoBlockKeys.Marketdata)]
    [TestCase("JsonData/bonds.json", InfoBlockKeys.MarketdataYields)]
    [TestCase("JsonData/shares.json", InfoBlockKeys.MarketdataYields)]
    [TestCase("JsonData/bonds.columns.json", InfoBlockKeys.MarketdataYields)]
    [TestCase("JsonData/shares.columns.json", InfoBlockKeys.MarketdataYields)]
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

        var securitiesBlock = new InfoBlock(InfoBlockKeys.Securities, jDoc);
        var jsonData = jDoc.RootElement.GetProperty(InfoBlockKeys.Securities).GetProperty("data");

        securitiesBlock.FillDataFrame(jsonData);
        var df = securitiesBlock.Data;

        var table = df.ToString();
        Assert.That(table, Is.Not.Empty);
        Console.WriteLine(table);
    }
}

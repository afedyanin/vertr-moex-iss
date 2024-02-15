using System.Text.Json;
using Vertr.Moex.Iss.Converters;
using Vertr.Moex.Iss.Entities;

namespace Vertr.Moex.Iss.Tests.Converters;

[TestFixture(Category = "Integration")]
public class ColumnConverterTests
{
    [TestCase("JsonData/bonds.columns.json")]
    [TestCase("JsonData/shares.columns.json")]
    public void CanCreateColumnsFomJsonColumnsFile(string jsonFile)
    {
        var json = File.ReadAllText(jsonFile);
        var jDoc = JsonDocument.Parse(json);
        Assert.That(jDoc, Is.Not.Null);

        var dict = new Dictionary<string, JsonElement>();

        dict.TryAdd("securities", jDoc.RootElement.GetProperty("securities"));
        dict.TryAdd("marketdata", jDoc.RootElement.GetProperty("marketdata"));
        dict.TryAdd("marketdata_yields", jDoc.RootElement.GetProperty("marketdata_yields"));

        var securitiesColumns = JsonColumnConverter.CreateColumns(dict["securities"]);
        Assert.That(securitiesColumns, Is.Not.Empty);
        DumpColumns(nameof(securitiesColumns), securitiesColumns.Values);

        var marketDataColumns = JsonColumnConverter.CreateColumns(dict["marketdata"]);
        Assert.That(marketDataColumns, Is.Not.Empty);
        DumpColumns(nameof(marketDataColumns), marketDataColumns.Values);

        var marketDataYieldColumns = JsonColumnConverter.CreateColumns(dict["marketdata_yields"]);
        Assert.That(marketDataYieldColumns, Is.Not.Null);
        DumpColumns(nameof(marketDataYieldColumns), marketDataYieldColumns.Values);
    }

    [TestCase("JsonData/bonds.columns.json", "JsonData/bonds.json")]
    [TestCase("JsonData/shares.columns.json", "JsonData/shares.json")]
    public void CanCreateEmptyDataFrame(string columnsFile, string dataFile)
    {
        var columnsJson = File.ReadAllText(columnsFile);
        var columns = CreateColumns(columnsJson);

        var dataJson = File.ReadAllText(dataFile);
        var jDoc = JsonDocument.Parse(dataJson);
        Assert.That(jDoc, Is.Not.Null);

        var securitiesColArray = jDoc.RootElement.GetProperty("securities").GetProperty("columns").Deserialize<string[]>();
        var marketDataColArray = jDoc.RootElement.GetProperty("marketdata").GetProperty("columns").Deserialize<string[]>();
        var marketDataYieldsColArray = jDoc.RootElement.GetProperty("marketdata_yields").GetProperty("columns").Deserialize<string[]>();

        var securitiesDf = JsonColumnConverter.CreateEmptyDataFarme(columns["securities"], securitiesColArray);
        var marketDataDf = JsonColumnConverter.CreateEmptyDataFarme(columns["marketdata"], marketDataColArray);
        var marketDataYieldsDf = JsonColumnConverter.CreateEmptyDataFarme(columns["marketdata_yields"], marketDataYieldsColArray, true);

        Assert.Multiple(() =>
        {
            Assert.That(securitiesDf.Columns, Is.Not.Empty);
            Assert.That(marketDataDf.Columns, Is.Not.Empty);
            Assert.That(marketDataYieldsDf.Columns, Is.Not.Null);
        });
    }

    private static Dictionary<string, IReadOnlyDictionary<string, Column>> CreateColumns(string columnsJson)
    {
        var jDoc = JsonDocument.Parse(columnsJson);
        var res = new Dictionary<string, IReadOnlyDictionary<string, Column>>
        {
            { "securities", JsonColumnConverter.CreateColumns(jDoc.RootElement.GetProperty("securities")) },
            { "marketdata", JsonColumnConverter.CreateColumns(jDoc.RootElement.GetProperty("marketdata")) },
            { "marketdata_yields", JsonColumnConverter.CreateColumns(jDoc.RootElement.GetProperty("marketdata_yields")) }
        };

        return res;
    }

    private static void DumpColumns(string name, IEnumerable<Column> columns)
    {
        Console.WriteLine($"Columns: {name}");
        foreach (var column in columns)
        {
            Console.WriteLine(column);
        }
    }
}

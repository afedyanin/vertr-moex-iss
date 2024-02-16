using System.Text.Json;
using Microsoft.Data.Analysis;

namespace Vertr.Moex.Iss.Entities;
public class InfoBlock
{
    private readonly JsonElement _jsonElement;

    public string Key { get; private set; }

    public DataFrame Data { get; private set; }

    public string[] Columns { get; private set; }

    public IReadOnlyDictionary<string, MetadataItem> Metadata { get; private set; }

    public InfoBlock(string key, JsonDocument jsonDocument)
    {
        if (!jsonDocument.RootElement.TryGetProperty(key, out var jsonElement))
        {
            throw new ArgumentException($"key={key} is not found in {nameof(JsonDocument)}");
        }

        _jsonElement = jsonElement;

        Key = key;
        Columns = _jsonElement.GetProperty("columns").Deserialize<string[]>() ?? [];
        Metadata = _jsonElement.GetProperty("metadata").Deserialize<Dictionary<string, MetadataItem>>() ?? [];
        Data = new DataFrame(Columns.Select(CreateColumn));
    }

    private DataFrameColumn CreateColumn(string colName)
    {
        if (!Metadata.TryGetValue(colName, out var metaItem))
        {
            throw new InvalidOperationException($"Unknown column name: {colName}");
        }

        return metaItem.Type switch
        {
            "string" => new StringDataFrameColumn(colName),
            "undefined" => new StringDataFrameColumn(colName),
            "double" => new PrimitiveDataFrameColumn<decimal>(colName),
            "int32" => new PrimitiveDataFrameColumn<int>(colName),
            "int64" => new PrimitiveDataFrameColumn<long>(colName),
            "date" => new PrimitiveDataFrameColumn<DateOnly>(colName),
            "time" => new PrimitiveDataFrameColumn<TimeOnly>(colName),
            "datetime" => new PrimitiveDataFrameColumn<DateTime>(colName),
            _ => throw new InvalidOperationException($"Unsupported column type: {metaItem.Type}")
        };
    }
}

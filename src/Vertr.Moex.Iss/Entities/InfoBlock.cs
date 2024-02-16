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

    public InfoBlock(string key, string json, bool fillData = false) :
        this(key, JsonDocument.Parse(json), fillData)
    {
    }

    public InfoBlock(string key, JsonDocument jsonDocument, bool fillData = false) :
        this(key, GetPropertyOrThrow(jsonDocument.RootElement, key), fillData)
    {
    }

    public InfoBlock(string key, JsonElement jsonElement, bool fillData = false)
    {
        _jsonElement = jsonElement;
        Key = key;
        Columns = GetPropertyOrThrow(_jsonElement, "columns").Deserialize<string[]>() ?? [];
        Metadata = GetPropertyOrThrow(_jsonElement, "metadata").Deserialize<Dictionary<string, MetadataItem>>() ?? [];
        Data = new DataFrame(Columns.Select(CreateColumn));

        if (fillData)
        {
            FillDataFrame(GetPropertyOrThrow(_jsonElement, "data"));
        }
    }

    public void FillDataFrame(JsonElement jsonDataElement)
    {
        foreach (var jsonRow in jsonDataElement.EnumerateArray())
        {
            Data.Append(CreateDataRow(jsonRow), true);
        }
    }

    private List<object?> CreateDataRow(JsonElement jsonRow)
    {
        var res = new List<object?>();

        for (int i = 0; i < Columns.Length; i++)
        {
            res.Add(ConvertToCell(jsonRow[i], Metadata[Columns[i]].Type));
        }

        return res;
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

    private static object? ConvertToCell(JsonElement jsonCell, string columnType)
    {
        if (jsonCell.ValueKind is
            JsonValueKind.Null or
            JsonValueKind.Undefined or
            JsonValueKind.Array) // unsupported
        {
            return null;
        }

        return columnType switch
        {
            "string" => jsonCell.GetString() ?? string.Empty,
            "double" => jsonCell.GetDecimal(),
            "int32" => jsonCell.GetInt32(),
            "int64" => jsonCell.GetInt64(),
            "date" => GetDateOnly(jsonCell.GetString()),
            "time" => GetTimeOnly(jsonCell.GetString()),
            "datetime" => GetDateTime(jsonCell.GetString()),
            "undefined" => null,
            "unknown" => null,
            _ => throw new ArgumentException($"Unsupported column type: {columnType}"),
        };
    }

    private static DateOnly? GetDateOnly(string? value)
    {
        if (!DateOnly.TryParse(value, out var res))
        {
            return null;
        }

        return res;
    }

    private static TimeOnly? GetTimeOnly(string? value)
    {
        if (!TimeOnly.TryParse(value, out var res))
        {
            return null;
        }

        return res;
    }

    private static DateTime? GetDateTime(string? value)
    {
        if (!DateTime.TryParse(value, out var res))
        {
            return null;
        }

        return res;
    }

    private static JsonElement GetPropertyOrThrow(JsonElement jsonElement, string name)
    {
        if (!jsonElement.TryGetProperty(name, out var found))
        {
            throw new ArgumentException($"Json property={name} is not found.");
        }

        return found;
    }
}

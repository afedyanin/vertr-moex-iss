using System.Text.Json;
using Vertr.Moex.Iss.Extensions;

namespace Vertr.Moex.Iss.Entities;
public class InfoBlock
{
    private readonly JsonElement _jsonElement;

    public InfoBlockKey Key { get; private set; }

    public string[] ColumnNames { get; private set; }

    public IReadOnlyDictionary<string, MetadataItem> ColumnMetadata { get; private set; }

    public IEnumerable<DataRow> Rows { get; private set; }

    public InfoBlock(InfoBlockKey key, string json) :
        this(key, JsonDocument.Parse(json))
    {
    }

    public InfoBlock(InfoBlockKey key, JsonDocument jsonDocument) :
        this(key, jsonDocument.RootElement.GetPropertyOrThrow(key.Name))
    {
    }

    public InfoBlock(InfoBlockKey key, JsonElement jsonElement)
    {
        _jsonElement = jsonElement;

        Key = key;
        ColumnNames = _jsonElement.GetPropertyOrThrow("columns").Deserialize<string[]>() ?? [];
        ColumnMetadata = _jsonElement.GetPropertyOrThrow("metadata").Deserialize<Dictionary<string, MetadataItem>>() ?? [];
        Rows = ParseRows(_jsonElement.GetPropertyOrThrow("data"));
    }

    public List<DataRow> ParseRows(JsonElement jsonTable)
    {
        var res = new List<DataRow>();
        var index = 0;

        foreach (var jsonRow in jsonTable.EnumerateArray())
        {
            res.Add(BuildDataRow(jsonRow, index++));
        }

        return res;
    }

    private DataRow BuildDataRow(JsonElement jsonRow, long index)
    {
        var objArray = new object?[ColumnNames.Length];

        for (var i = 0; i < ColumnNames.Length; i++)
        {
            objArray[i] = ConvertToCell(jsonRow[i], ColumnMetadata[ColumnNames[i]].Type);
        }

        return new DataRow(index, objArray);
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
            "double" => jsonCell.GetDouble(),
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

    private static DateTime? GetDateOnly(string? value)
    {
        if (!DateOnly.TryParse(value, out var res))
        {
            return null;
        }

        // Fix Arrow NotImplemented Exception
        var dt = res.ToDateTime(TimeOnly.MinValue);
        return dt;
    }

    private static string? GetTimeOnly(string? value)
    {
        if (!TimeOnly.TryParse(value, out var res))
        {
            return null;
        }

        // Fix Arrow NotImplemented Exception
        return res.ToLongTimeString();
    }

    private static DateTime? GetDateTime(string? value)
    {
        if (!DateTime.TryParse(value, out var res))
        {
            return null;
        }

        return res;
    }
}

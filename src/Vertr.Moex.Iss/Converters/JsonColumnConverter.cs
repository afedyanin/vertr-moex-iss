using System.Text.Json;
using Microsoft.Data.Analysis;
using Vertr.Moex.Iss.Entities;

namespace Vertr.Moex.Iss.Converters;

internal static class JsonColumnConverter
{
    public static IReadOnlyDictionary<string, Column> CreateColumns(JsonElement json)
    {
        var columns = json.GetProperty("columns").Deserialize<string[]>();

        if (columns == null || columns.Length == 0)
        {
            return new Dictionary<string, Column>(StringComparer.OrdinalIgnoreCase);
        }

        var idxId = Array.IndexOf(columns, "id");
        var idxName = Array.IndexOf(columns, "name");
        var idxShortTitle = Array.IndexOf(columns, "short_title");
        var idxTitle = Array.IndexOf(columns, "title");
        var idxType = Array.IndexOf(columns, "type");
        var idxPrecision = Array.IndexOf(columns, "precision");

        var res = new Dictionary<string, Column>(StringComparer.OrdinalIgnoreCase);

        foreach (var item in json.GetProperty("data").EnumerateArray())
        {
            res.TryAdd(
            item[idxName].GetString()!,
            new Column
            {
                Id = item[idxId].GetInt32(),
                Name = item[idxName].GetString()!,
                ShortTitle = item[idxShortTitle].GetString()!,
                Title = item[idxTitle].GetString()!,
                Type = item[idxType].GetString()!,
                Precision = item[idxPrecision].ValueKind != JsonValueKind.Null ? item[idxPrecision].GetInt32() : null,
            });
        }

        return res;
    }

    public static DataFrame CreateEmptyDataFarme(Column[] columns)
    {
        if (columns == null || columns.Length == 0)
        {
            return new DataFrame();
        }

        return new DataFrame(columns.Select(col => col.ToDataFrameColumn()));
    }

    public static IEnumerable<object?> CreateDataRow(Column[] columns, JsonElement jsonRowData)
    {
        var res = new List<object?>();

        for (int i = 0; i <= columns.Length; i++)
        {
            res.Add(ConvertToItem(jsonRowData[i], columns[i].Type));
        }
        return res;
    }

    public static Column[] ColNamesToColumns(IReadOnlyDictionary<string, Column> colDict, string[]? colNames)
    {
        if (colNames == null || colNames.Length == 0)
        {
            return [];
        }

        var res = new List<Column>(colNames.Length);

        foreach (var colName in colNames)
        {
            if (!colDict.TryGetValue(colName, out var col))
            {
                // to fit columns array size with data array
                col = Column.Unknown;
            }

            res.Add(col);
        }

        return [.. res];
    }

    private static DataFrameColumn ToDataFrameColumn(this Column column)
        => column.Type switch
        {
            "string" => new StringDataFrameColumn(column.Name),
            "number" => new PrimitiveDataFrameColumn<decimal>(column.Name),
            "date" => new PrimitiveDataFrameColumn<DateOnly>(column.Name),
            "time" => new PrimitiveDataFrameColumn<TimeOnly>(column.Name),
            "datetime" => new PrimitiveDataFrameColumn<DateTime>(column.Name),
            "unknown" => new StringDataFrameColumn(column.Name),
            _ => throw new ArgumentException($"Invalid column type: {column.Type}")
        };

    private static object? ConvertToItem(JsonElement jsonColData, string columnType)
    {
        if (jsonColData.ValueKind is
            JsonValueKind.Null or
            JsonValueKind.Undefined or
            JsonValueKind.Array) // unsupported
        {
            return null;
        }

        return columnType switch
        {
            "string" => jsonColData.GetString() ?? string.Empty,
            "number" => jsonColData.GetDecimal(),
            "date" => jsonColData.GetDateTime(),
            "time" => jsonColData.GetDateTime(),
            "datetime" => jsonColData.GetDateTime(),
            "unknown" => null,
            _ => throw new ArgumentException($"Invalid column type: {columnType}"),
        };
    }
}

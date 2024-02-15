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

    public static DataFrame CreateEmptyDataFarme(IReadOnlyDictionary<string, Column> colDict, string[]? colNames, bool skipNotFoundColumns = false)
    {
        var dfColumns = new List<DataFrameColumn>();

        if (colNames == null || colNames.Length == 0)
        {
            return new DataFrame();
        }

        foreach (var colName in colNames)
        {
            if (!colDict.TryGetValue(colName, out var col))
            {
                if (skipNotFoundColumns)
                {
                    continue;
                }

                throw new InvalidOperationException($"Column with name={colName} is not found in columns metadata.");
            }

            dfColumns.Add(col.ToDataFrameColumn());
        }

        var df = new DataFrame(dfColumns);

        return df;
    }

    private static DataFrameColumn ToDataFrameColumn(this Column column)
        => column.Type switch
        {
            "string" => new StringDataFrameColumn(column.Name),
            "number" => new PrimitiveDataFrameColumn<decimal>(column.Name),
            "date" => new PrimitiveDataFrameColumn<DateOnly>(column.Name),
            "time" => new PrimitiveDataFrameColumn<TimeOnly>(column.Name),
            "datetime" => new PrimitiveDataFrameColumn<DateTime>(column.Name),
            _ => throw new ArgumentException($"Unknown column type: {column.Type}")
        };
}

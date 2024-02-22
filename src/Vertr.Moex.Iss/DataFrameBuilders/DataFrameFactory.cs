using Microsoft.Data.Analysis;
using Vertr.Moex.Iss.Entities;

namespace Vertr.Moex.Iss.DataFrameBuilders;
internal class DataFrameFactory
{
    private readonly string[] _columns;
    private readonly IReadOnlyDictionary<string, MetadataItem> _columnMetadata;
    private readonly ColumnBuilder[] _columnBuilders;

    public DataFrameFactory(
        string[] columns,
        IReadOnlyDictionary<string, MetadataItem> columnMetadata)
    {
        _columns = columns;
        _columnMetadata = columnMetadata;
        _columnBuilders = InitColumnBuilders();
    }

    public DataFrame Create(IEnumerable<DataRow> rows)
    {
        FillRows(rows);
        var columns = CreateColumns();
        var df = new DataFrame(columns);
        return df;
    }

    private ColumnBuilder[] InitColumnBuilders()
    {
        var res = new ColumnBuilder[_columns.Length];

        for (var i = 0; i < _columns.Length; i++)
        {
            var name = _columns[i];
            res[i] = CreateColumnBuilder(_columnMetadata[name].Type, name);
        }

        return res;
    }
    private IEnumerable<DataFrameColumn> CreateColumns()
        => _columnBuilders.Select(cb => cb.Build());

    private void FillRows(IEnumerable<DataRow> rows)
    {
        foreach (var row in rows)
        {
            for (var i = 0; i < _columnBuilders.Length; i++)
            {
                _columnBuilders[i].Append(row.Cells[i]);
            }
        }
    }

    private ColumnBuilder CreateColumnBuilder(string colType, string colName)
    {
        return colType switch
        {
            "string" => new ArrowStringColumnBuilder(colName),
            "undefined" => new ArrowStringColumnBuilder(colName),
            "double" => new PrimitiveTypeColumnBuilder<double>(colName),
            "int32" => new PrimitiveTypeColumnBuilder<int>(colName),
            "int64" => new PrimitiveTypeColumnBuilder<long>(colName),
            "date" => new PrimitiveTypeColumnBuilder<DateTime>(colName),
            "time" => new ArrowStringColumnBuilder(colName),
            "datetime" => new PrimitiveTypeColumnBuilder<DateTime>(colName),
            _ => throw new InvalidOperationException($"Unsupported column type: {colName}")
        };
    }
}

using Microsoft.Data.Analysis;
using Vertr.Moex.Iss.Entities;

namespace Vertr.Moex.Iss.Extensions;
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

    public DataFrame Create(DataRow[] rows)
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
            res[i] = new ColumnBuilder(name, _columnMetadata[name].Type);
        }

        return res;
    }

    private void FillRows(DataRow[] rows)
    {
        foreach (var row in rows)
        {
            for (var i = 0; i < _columnBuilders.Length; i++)
            {
                _columnBuilders[i].Append(row.Cells[i]);
            }
        }
    }

    private IEnumerable<DataFrameColumn> CreateColumns()
        => _columnBuilders.Select(ToDataFrameColumn);

    public DataFrameColumn ToDataFrameColumn(ColumnBuilder cb)
    {
        return cb.ColumnType switch
        {
            "string" => new ArrowStringDataFrameColumn(cb.ColumnName),
            "undefined" => new StringDataFrameColumn(cb.ColumnName),
            "double" => new PrimitiveDataFrameColumn<decimal>(cb.ColumnName),
            "int32" => new PrimitiveDataFrameColumn<int>(cb.ColumnName),
            "int64" => new PrimitiveDataFrameColumn<long>(cb.ColumnName),
            "date" => new PrimitiveDataFrameColumn<DateOnly>(cb.ColumnName),
            "time" => new PrimitiveDataFrameColumn<TimeOnly>(cb.ColumnName),
            "datetime" => new PrimitiveDataFrameColumn<DateTime>(cb.ColumnName),
            _ => throw new InvalidOperationException($"Unsupported column type: {cb.ColumnName}")
        };
    }

}

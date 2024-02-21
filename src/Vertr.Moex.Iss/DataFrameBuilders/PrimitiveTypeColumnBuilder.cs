using Microsoft.Data.Analysis;

namespace Vertr.Moex.Iss.DataFrameBuilders;

internal class PrimitiveTypeColumnBuilder<T>(string columnName)
    : ColumnBuilder(columnName) where T : unmanaged
{
    private readonly List<T> _columnValues = [];

    public override void Append(object? value)
    {
        if (value == null)
        {
            _columnValues.Add(default);
        }
        else
        {
            _columnValues.Add((T)value);
        }
    }

    public override DataFrameColumn Build()
        => new PrimitiveDataFrameColumn<T>(ColumnName, _columnValues);
}

using Microsoft.Data.Analysis;

namespace Vertr.Moex.Iss.DataFrameBuilders;

internal class StringColumnBuilder(string columnName) : ColumnBuilder(columnName)
{
    private readonly List<string?> _columnValues = [];

    public override void Append(object? value)
    {
        _columnValues.Add(value as string);
    }

    public override DataFrameColumn Build()
        => new StringDataFrameColumn(ColumnName, _columnValues);
}

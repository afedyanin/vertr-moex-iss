using Microsoft.Data.Analysis;

namespace Vertr.Moex.Iss.DataFrameBuilders;

internal abstract class ColumnBuilder(string columnName)
{
    public string ColumnName { get; private set; } = columnName;

    public abstract void Append(object? value);

    public abstract DataFrameColumn Build();
}

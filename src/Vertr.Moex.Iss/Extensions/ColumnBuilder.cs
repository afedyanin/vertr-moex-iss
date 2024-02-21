namespace Vertr.Moex.Iss.Extensions;

internal class ColumnBuilder(string columnName, string columnType)
{
    private readonly List<object?> _columnValues = [];

    public string ColumnName { get; private set; } = columnName;

    public string ColumnType { get; private set; } = columnType;

    public IEnumerable<object?> Values => _columnValues;

    public void Append(object? cell)
        => _columnValues.Add(cell);
}

using Apache.Arrow;
using Microsoft.Data.Analysis;

namespace Vertr.Moex.Iss.DataFrameBuilders;

internal class ArrowStringColumnBuilder(string columnName) : ColumnBuilder(columnName)
{
    private readonly List<string?> _columnValues = [];

    public override void Append(object? value)
    {
        _columnValues.Add(value as string);
    }

    public override DataFrameColumn Build()
        => CreateStringColumn(ColumnName, _columnValues);

    private static ArrowStringDataFrameColumn CreateStringColumn(string name, IEnumerable<string?> values)
    {
        var strArrayBuilder = new StringArray.Builder();

        foreach (var value in values)
        {
            if (value == null)
            {
                strArrayBuilder.AppendNull();
                continue;
            }

            strArrayBuilder.Append(value);
        }

        var strArray = strArrayBuilder.Build();

        var stringColumn = new ArrowStringDataFrameColumn(
            name,
            strArray.ValueBuffer.Memory,
            strArray.ValueOffsetsBuffer.Memory,
            strArray.NullBitmapBuffer.Memory,
            strArray.Length,
            strArray.NullCount);

        return stringColumn;
    }
}

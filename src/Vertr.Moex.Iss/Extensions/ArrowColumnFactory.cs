using Apache.Arrow;
using Microsoft.Data.Analysis;

namespace Vertr.Moex.Iss.Extensions;

internal class ArrowColumnFactory
{
    public static ArrowStringDataFrameColumn CreateStringColumn(string name, string?[] values)
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

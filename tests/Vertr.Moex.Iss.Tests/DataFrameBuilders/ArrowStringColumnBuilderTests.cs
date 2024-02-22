using Apache.Arrow;
using Microsoft.Data.Analysis;
using Vertr.Moex.Iss.DataFrameBuilders;

namespace Vertr.Moex.Iss.Tests.DataFrameBuilders;

[TestFixture(Category = "Unit")]
public class ArrowStringColumnBuilderTests
{
    [Test]
    public void CanBuildStringColumn()
    {
        var strArray = new StringArray.Builder().Append("foo").Append("bar").Build();

        var stringColumn = new ArrowStringDataFrameColumn(
            "String",
            strArray.ValueBuffer.Memory,
            strArray.ValueOffsetsBuffer.Memory,
            strArray.NullBitmapBuffer.Memory,
            strArray.Length,
            strArray.NullCount);

        for (var i = 0; i < stringColumn.Length; i++)
        {
            Console.WriteLine($"i={i} val={stringColumn[i]}");
        }

        var clone = stringColumn.Clone(numberOfNullsToAppend: 5);

        Assert.That(clone, Is.Not.Null);
    }

    [Test]
    public void CanCreateStringColumnByFactory()
    {
        var items = new string?[] { "aaa", "bbb", null, "ccc" };

        var cb = new ArrowStringColumnBuilder("test");

        foreach (var item in items)
        {
            cb.Append(item);
        }

        var col = cb.Build();
        Assert.That(col, Is.Not.Null);

        for (var i = 0; i < col.Length; i++)
        {
            Console.WriteLine($"i={i} val={col[i]}");
        }
    }
}

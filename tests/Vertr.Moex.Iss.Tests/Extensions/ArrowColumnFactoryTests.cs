using Apache.Arrow;
using Microsoft.Data.Analysis;
using Vertr.Moex.Iss.Extensions;

namespace Vertr.Moex.Iss.Tests.Extensions;


[TestFixture(Category = "Unit")]
public class ArrowColumnFactoryTests
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

        var col = ArrowColumnFactory.CreateStringColumn("test", items);
        Assert.That(col, Is.Not.Null);

        for (var i = 0; i < col.Length; i++)
        {
            Console.WriteLine($"i={i} val={col[i]}");
        }
    }

}

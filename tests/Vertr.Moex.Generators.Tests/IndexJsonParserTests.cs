using System.Text.Json;

namespace Vertr.Moex.Generators.Tests;

[TestFixture(Category = "Integration")]
public class IndexJsonParserTests
{
    [Test]
    public void CanParseIndexJson()
    {
        var json = File.ReadAllText("Metadata/index.json");
        var jDoc = JsonDocument.Parse(json);

        // TODO: Parse doc by keys

        Assert.That(jDoc, Is.Not.Null);
    }
}

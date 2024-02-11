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
        Assert.That(jDoc, Is.Not.Null);

        var dict = new Dictionary<string, JsonElement>();

        dict.TryAdd("engines", jDoc.RootElement.GetProperty("engines"));
        dict.TryAdd("markets", jDoc.RootElement.GetProperty("markets"));
        dict.TryAdd("boards", jDoc.RootElement.GetProperty("boards"));
        dict.TryAdd("boardgroups", jDoc.RootElement.GetProperty("boardgroups"));
        dict.TryAdd("durations", jDoc.RootElement.GetProperty("durations"));
        dict.TryAdd("securitytypes", jDoc.RootElement.GetProperty("securitytypes"));
        dict.TryAdd("securitygroups", jDoc.RootElement.GetProperty("securitygroups"));
        dict.TryAdd("securitycollections", jDoc.RootElement.GetProperty("securitycollections"));

        Assert.Multiple(() =>
        {
            Assert.That(dict["engines"].ValueKind, Is.EqualTo(JsonValueKind.Object));
            Assert.That(dict["markets"].ValueKind, Is.EqualTo(JsonValueKind.Object));
            Assert.That(dict["boards"].ValueKind, Is.EqualTo(JsonValueKind.Object));
            Assert.That(dict["boardgroups"].ValueKind, Is.EqualTo(JsonValueKind.Object));
            Assert.That(dict["durations"].ValueKind, Is.EqualTo(JsonValueKind.Object));
            Assert.That(dict["securitytypes"].ValueKind, Is.EqualTo(JsonValueKind.Object));
            Assert.That(dict["securitygroups"].ValueKind, Is.EqualTo(JsonValueKind.Object));
            Assert.That(dict["securitycollections"].ValueKind, Is.EqualTo(JsonValueKind.Object));
        });
    }

    [Test]
    public void CanParseEngines()
    {
        var json = File.ReadAllText("Metadata/index.json");
        var factory = new MetaItemsProvider(json);
        Assert.That(factory.Engines, Is.Not.Empty);
    }
}

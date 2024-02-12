using System.Text.Json;
using Vertr.Moex.Generators.MetaItems;

namespace Vertr.Moex.Generators.Tests;

[TestFixture(Category = "Integration")]
public class IndexJsonParserTests
{
    private static readonly string _enginesFile = "JsonData/engines.json";
    private static readonly string _indexFile = "JsonData/index.json";

    [Test]
    public void CanParseIndexJson()
    {
        var json = File.ReadAllText(_indexFile);
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
    public void CanParseIndex()
    {
        var json = File.ReadAllText(_indexFile);
        var factory = new MetaItemsProvider(json);
        Assert.Multiple(() =>
        {
            Assert.That(factory.Engines, Is.Not.Empty);
            Assert.That(factory.Markets, Is.Not.Empty);
            Assert.That(factory.Boards, Is.Not.Empty);
            Assert.That(factory.BoardGroups, Is.Not.Empty);
            Assert.That(factory.Durations, Is.Not.Empty);
            Assert.That(factory.SecurityGroups, Is.Not.Empty);
            Assert.That(factory.SecurityTypes, Is.Not.Empty);
            Assert.That(factory.SecurityCollections, Is.Not.Empty);
        });
    }

    [Test]
    public void CanParseEnginesMetadata()
    {
        var json = File.ReadAllText(_enginesFile);

        using var jdoc = JsonDocument.Parse(json);
        var enginesJson = jdoc.RootElement.GetProperty("engines");
        var columns = enginesJson.GetProperty("columns").Deserialize<string[]>();

        var idxId = Array.IndexOf(columns!, "id");
        var idxName = Array.IndexOf(columns!, "name");
        var idxTitle = Array.IndexOf(columns!, "title");

        var engines = new List<EngineMeta>();

        foreach (var item in enginesJson.GetProperty("data").EnumerateArray())
        {
            engines.Add(new EngineMeta
            {
                Id = item[idxId].GetInt32(),
                Name = item[idxName].GetString()!,
                Title = item[idxTitle].GetString()!,
            });
        }

        Assert.That(engines, Is.Not.Empty);
    }

}

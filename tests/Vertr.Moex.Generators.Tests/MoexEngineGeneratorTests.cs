using System.Text.Json;

namespace Vertr.Moex.Generators.Tests;

[TestFixture(Category = "Integration")]
public class MoexEngineGeneratorTests
{
    [Test]
    public void CanLoadMoexEngineMetadata()
    {
        var json = File.ReadAllText("Metadata/engines.json");

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

using System.Collections.Immutable;
using System.Text;
using Microsoft.CodeAnalysis;

namespace Vertr.Moex.Generators;

[Generator]
public sealed class MoexEngineGenerator : IIncrementalGenerator
{
    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        var jsonFiles = context.AdditionalTextsProvider
            .Where(text => text.Path.EndsWith(".json", StringComparison.OrdinalIgnoreCase))
            .Select((text, token) => (
                name: Path.GetFileNameWithoutExtension(text.Path),
                content: text.GetText(token)?.ToString()))
            .Where(text => text.content is not null);

        context.RegisterPostInitializationOutput(ctx => ctx.AddSource(
            "Engine.Engines.g.cs", GenerateStub("TestStub")));
        /*
                context.RegisterSourceOutput(jsonFiles, (ctx, nameAndContent) =>
                {
                    ctx.AddSource(
                        $"{nameAndContent.name}.g.cs",
                        Generate(nameAndContent.name, nameAndContent.content));
                });
        */
    }
    private string GenerateStub(string stubName)
    {
        return $@"
namespace Vertr.Moex.Iss.UrlBuilderComponents
{{
  public partial class {stubName}
  {{
  }}
}}";
    }

    /*
    private string Generate(string fileName, string? jsonContent)
    {
        return GenerateMoexEngine(jsonContent!);
    }

    private string GenerateMoexEngine(string jsonSource)
    {
        return $@"
namespace Vertr.Moex.Iss.UrlBuilderComponents
{{
  public partial class Engine
  {{
    {GenerateItem(jsonSource)}
  }}
}}";
    }

    private string GenerateItem(string json)
    {
        var sb = new StringBuilder();

        foreach (var meta in EngineMeta.LoadEngines(json))
        {
            sb.AppendLine($@"
        public static readonly Engine {meta.PropertyName} = new Engine {{ Id = {meta.Id}, Name = ""{meta.Name}"", Title = ""{meta.Title}"" }};");
        }

        return sb.ToString();
    }
    */
}


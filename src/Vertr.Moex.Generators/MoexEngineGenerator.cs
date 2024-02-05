using System.Text;
using Microsoft.CodeAnalysis;

namespace Vertr.Moex.Generators;

// https://habr.com/ru/companies/jugru/articles/690040/
[Generator]
public class MoexEngineGenerator : ISourceGenerator
{
    public void Initialize(GeneratorInitializationContext context)
    {
    }

    public void Execute(GeneratorExecutionContext context)
    {
        var compilation = context.Compilation;
        var engineClass = compilation.GetTypeByMetadataName("Vertr.Moex.Iss.UrlBuilderComponents.Engine");
        var source = GenerateMoexEngine(engineClass!);
        context.AddSource($"{engineClass!.Name}.Engines.cs", source);
    }

    private string GenerateMoexEngine(INamedTypeSymbol typeSymbol)
    {
        return $@"
using System.ComponentModel;
namespace {typeSymbol.ContainingNamespace}
{{
  public partial class {typeSymbol.Name}
  {{
    {GenerateItem()}
  }}
}}";
    }

    private static string GenerateItem()
    {
        var sb = new StringBuilder();

        foreach (var meta in EngineMeta.LoadEngines())
        {
            sb.AppendLine($@"
public static readonly Engine {meta.PropertyName} = new Engine {{ Id = {meta.Id}, Name = ""{meta.Name}"", Title = ""{meta.Title}"" }};");
        }

        return sb.ToString();
    }
}


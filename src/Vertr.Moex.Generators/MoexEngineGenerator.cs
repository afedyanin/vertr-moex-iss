using System.Text;
using Microsoft.CodeAnalysis;

namespace Vertr.Moex.Generators;

[Generator]
public sealed class MoexEngineGenerator : IIncrementalGenerator
{
    public void Initialize(IncrementalGeneratorInitializationContext context)
    {

        context.RegisterPostInitializationOutput(static ctx => ctx.AddSource(
            "Engine.Engines.g.cs", GenerateMoexEngine()));
    }

    private static string GenerateMoexEngine()
    {
        return $@"
namespace Vertr.Moex.Iss.UrlBuilderComponents
{{
  public partial class Engine
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


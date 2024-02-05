using System.Collections.Immutable;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Vertr.Moex.Generators;

// https://habr.com/ru/companies/jugru/articles/690040/
// https://www.thinktecture.com/en/net/roslyn-source-generators-introduction/
[Generator]
public sealed class MoexEngineGenerator : IIncrementalGenerator
{
    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        IncrementalValueProvider<ImmutableArray<SyntaxToken>> pipeline =
            context.SyntaxProvider.CreateSyntaxProvider( // A
                (node, _) => node is ClassDeclarationSyntax, // B
                (syntax, _) => ((ClassDeclarationSyntax)syntax.Node).Identifier) // C
                .Collect(); // D

        context.RegisterImplementationSourceOutput(pipeline, Build); // E
    }

    private void Build(
    SourceProductionContext context,
    ImmutableArray<SyntaxToken> source)
    {
        var sourceCode = GenerateMoexEngine();
        context.AddSource($"Engine.Engines.g.cs", sourceCode);
    }

    private string GenerateMoexEngine()
    {
        return $@"
using System.ComponentModel;
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


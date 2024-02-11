using Microsoft.CodeAnalysis;
using Vertr.Moex.Generators.MetaItems.Extensions;

namespace Vertr.Moex.Generators;

// to clear generator cache use command:
// dotnet build-server shutdown
[Generator]
public sealed class SourceCodeGenerator : IIncrementalGenerator
{
    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        var jsonFiles = context.AdditionalTextsProvider
            .Where(text => text.Path.EndsWith(".json", StringComparison.OrdinalIgnoreCase))
            .Select((text, token) => (
                name: Path.GetFileNameWithoutExtension(text.Path),
                content: text.GetText(token)?.ToString()))
            .Where(text => text.content is not null);

        context.RegisterImplementationSourceOutput(jsonFiles, (ctx, nameAndContent) =>
        {
            if (nameAndContent.name.Equals("index", StringComparison.OrdinalIgnoreCase))
            {
                var metaItems = new MetaItemsProvider(nameAndContent.content);
                ctx.AddSource(SourceCodeGeneratorConsts.EngineGeneratedFileName, metaItems.Engines.ToSourceCode());
                ctx.AddSource(SourceCodeGeneratorConsts.MarketGeneratedFileName, metaItems.Markets.ToSourceCode());
            }
        });
    }
}


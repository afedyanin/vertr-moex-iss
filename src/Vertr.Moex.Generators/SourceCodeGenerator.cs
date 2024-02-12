using Microsoft.CodeAnalysis;
using Vertr.Moex.Generators.MetaItems.SourceCodeProviders;

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
                ctx.AddSource(SourceCodeGeneratorConsts.BoardGeneratedFileName, metaItems.Boards.ToSourceCode());
                ctx.AddSource(SourceCodeGeneratorConsts.BoardGroupGeneratedFileName, metaItems.BoardGroups.ToSourceCode());
                ctx.AddSource(SourceCodeGeneratorConsts.SecurityCollectionGeneratedFileName, metaItems.SecurityCollections.ToSourceCode());
                ctx.AddSource(SourceCodeGeneratorConsts.SecurityGroupGeneratedFileName, metaItems.SecurityGroups.ToSourceCode());
                ctx.AddSource(SourceCodeGeneratorConsts.SecurityTypeGeneratedFileName, metaItems.SecurityTypes.ToSourceCode());
                ctx.AddSource(SourceCodeGeneratorConsts.DurationGeneratedFileName, metaItems.Durations.ToSourceCode());
            }
        });
    }
}


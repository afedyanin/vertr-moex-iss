using Microsoft.CodeAnalysis;

namespace Vertr.Moex.Generators;

[Generator]
public sealed class MoexEngineGenerator : IIncrementalGenerator
{
    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        var jsonFiles = context.AdditionalTextsProvider
            .Where(text => text.Path.EndsWith("index.json", StringComparison.OrdinalIgnoreCase))
            .Select((text, token) => (
                name: Path.GetFileNameWithoutExtension(text.Path),
                content: text.GetText(token)?.ToString()))
            .Where(text => text.content is not null);

        // context.RegisterPostInitializationOutput(ctx => ctx.AddSource("Engine.Engines.g.cs", GenerateStub("TestStub")));

        context.RegisterImplementationSourceOutput(jsonFiles, (ctx, nameAndContent) =>
        {
            var factory = new MetaItemFactory(nameAndContent.content);
            ctx.AddSource($"Engine.g.cs", factory.Engines.ToSourceCode());
        });
    }
}


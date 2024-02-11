using System.Text;

namespace Vertr.Moex.Generators.MetaItems.Extensions;

internal static class BoardGroupSourceCodeProvider
{
    public static string ToSourceCode(this BoardGroupMeta[] items)
    {
        return $@"namespace {SourceCodeGeneratorConsts.EntitiesNamespace}
{{
    public partial class BoardGroup
    {{
    {GenerateStaticProperties(items)}
    {GenerateAllProperty(items)}
    }}
}}";
    }

    private static string GenerateStaticProperties(BoardGroupMeta[] items)
    {
        var sb = new StringBuilder();

        foreach (var meta in items)
        {
            sb.AppendLine($@"
        /// <summary>
        /// {meta.Title}
        /// </summary>
        public static readonly BoardGroup {meta.PropertyName} = new BoardGroup
        {{
            Id = {meta.Id},
            Title = ""{meta.Title}"",
            Name = ""{meta.Name}"",
            BoardGroupId = {meta.BoardGroupId},
            EngineId = {meta.EngineId},
            MarketId = {meta.MarketId},
            IsTraded = {meta.IsTraded.ToString().ToLower()},
            IsDefault = {meta.IsDefault.ToString().ToLower()},
            IsOrderDriven = {meta.IsOrderDriven.ToString().ToLower()},
            Category = ""{meta.Category ?? string.Empty}"",
        }};
");
        }

        return sb.ToString();
    }

    private static string GenerateAllProperty(BoardGroupMeta[] items)
    {
        var sb = new StringBuilder();

        sb.AppendLine($@" 
        public static BoardGroup[] All = new BoardGroup[] {{ {GenerateAllItemsList(items)} }};
");

        return sb.ToString();
    }

    private static string GenerateAllItemsList(BoardGroupMeta[] items)
    {
        var sb = new StringBuilder();

        foreach (var item in items)
        {
            sb.Append($"{item.PropertyName}, ");
        }

        return sb.ToString();
    }
}

using System.Text;

namespace Vertr.Moex.Generators.MetaItems.Extensions;

internal static class BoardSourceCodeProvider
{
    public static string ToSourceCode(this BoardMeta[] items)
    {
        return $@"namespace {SourceCodeGeneratorConsts.EntitiesNamespace}
{{
    public partial class Board
    {{
    {GenerateStaticProperties(items)}
    {GenerateAllProperty(items)}
    }}
}}";
    }

    private static string GenerateStaticProperties(BoardMeta[] items)
    {
        var sb = new StringBuilder();

        foreach (var meta in items)
        {
            sb.AppendLine($@"
        /// <summary>
        /// {meta.Title}
        /// </summary>
        public static readonly Board {meta.PropertyName} = new Board
        {{
            Id = {meta.Id},
            BoardId = ""{meta.BoardId}"",
            Title = ""{meta.Title}"",
            BoardGroupId = {meta.BoardGroupId},
            EngineId = {meta.EngineId},
            MarketId = {meta.MarketId},
            IsTraded = {meta.IsTraded.ToString().ToLower()},
            IsPrimary = {meta.IsPrimary.ToString().ToLower()},
            HasCandles = {meta.HasCandles.ToString().ToLower()},
        }};
");
        }

        return sb.ToString();
    }

    private static string GenerateAllProperty(BoardMeta[] items)
    {
        var sb = new StringBuilder();

        sb.AppendLine($@" 
        public static Board[] All = new Board[] {{ {GenerateAllItemsList(items)} }};
");

        return sb.ToString();
    }

    private static string GenerateAllItemsList(BoardMeta[] items)
    {
        var sb = new StringBuilder();

        foreach (var item in items)
        {
            sb.Append($"{item.PropertyName}, ");
        }

        return sb.ToString();
    }
}

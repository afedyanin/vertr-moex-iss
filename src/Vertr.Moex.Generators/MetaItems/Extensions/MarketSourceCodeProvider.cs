using System.Text;

namespace Vertr.Moex.Generators.MetaItems.Extensions;
internal static class MarketSourceCodeProvider
{
    public static string ToSourceCode(this MarketMeta[] items)
    {
        return $@"namespace {SourceCodeGeneratorConsts.EntitiesNamespace}
{{
    public partial class Market
    {{
    {GenerateStaticProperties(items)}
    {GenerateAllProperty(items)}
    }}
}}";
    }

    private static string GenerateStaticProperties(MarketMeta[] items)
    {
        var sb = new StringBuilder();

        foreach (var meta in items)
        {
            sb.AppendLine($@"
        /// <summary>
        /// {meta.Title}
        /// </summary>
        public static readonly Market {meta.PropertyName} = new Market
        {{
            Id = {meta.Id},
            MarketId = {meta.MarketId},
            Name = ""{meta.Name}"",
            Title = ""{meta.Title}"",
            EngineId = {meta.EngineId},
            MarketPlace = ""{meta.MarketPlace ?? string.Empty}""
            IsOtc = {meta.IsOtc},
            HasHistoryFiles = {meta.HasHistoryFiles},
            HasHistoryTradesFiles = {meta.HasHistoryTradesFiles},
            HasTrades = {meta.HasTrades},
            HasHistory = {meta.HasHistory},
            HasCandles = {meta.HasCandles},
            HasOrderBook = {meta.HasOrderBook},
            HasTradingSession = {meta.HasTradingSession},
            HasExtraYields = {meta.HasExtraYields},
            HasDelay = {meta.HasDelay},
        }};
");
        }

        return sb.ToString();
    }

    private static string GenerateAllProperty(MarketMeta[] items)
    {
        var sb = new StringBuilder();

        sb.AppendLine($@" 
        public static Market[] All = new Market[] {{ {GenerateAllItemsList(items)} }};
");

        return sb.ToString();
    }

    private static string GenerateAllItemsList(MarketMeta[] items)
    {
        var sb = new StringBuilder();

        foreach (var item in items)
        {
            sb.Append($"{item.PropertyName}, ");
        }

        return sb.ToString();
    }
}

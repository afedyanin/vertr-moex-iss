namespace Vertr.Moex.Generators.MetaItems;
internal class MarketMeta
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Title { get; set; } = string.Empty;

    public string PropertyName => $"{EngineName.ToTitleCase()}_{Name.ToTitleCase()}";

    public int MarketId { get; set; }

    public int EngineId { get; set; }

    public string EngineName { get; set; } = string.Empty;

    public string? MarketPlace { get; set; }

    public bool IsOtc { get; set; }

    public bool HasHistoryFiles { get; set; }

    public bool HasHistoryTradesFiles { get; set; }

    public bool HasTrades { get; set; }

    public bool HasHistory { get; set; }

    public bool HasCandles { get; set; }

    public bool HasOrderBook { get; set; }

    public bool HasTradingSession { get; set; }

    public bool HasExtraYields { get; set; }

    public bool HasDelay { get; set; }
}

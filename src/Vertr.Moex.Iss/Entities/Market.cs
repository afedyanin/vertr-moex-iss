
namespace Vertr.Moex.Iss.Entities;

public partial class Market
{
    public required int Id { get; init; }
    public required int MarketId { get; init; }
    public required string Name { get; init; }
    public required string Title { get; init; }
    public required int EngineId { get; init; }
    public string? MarketPlace { get; init; }
    public bool IsOtc { get; init; }
    public bool HasHistoryFiles { get; init; }
    public bool HasHistoryTradesFiles { get; init; }
    public bool HasTrades { get; init; }
    public bool HasHistory { get; init; }
    public bool HasCandles { get; init; }
    public bool HasOrderBook { get; init; }
    public bool HasTradingSession { get; init; }
    public bool HasExtraYields { get; init; }
    public bool HasDelay { get; init; }
}

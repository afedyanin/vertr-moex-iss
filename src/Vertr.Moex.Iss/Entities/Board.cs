namespace Vertr.Moex.Iss.Entities;

public partial class Board
{
    public int Id { get; init; }

    public string BoardId { get; init; } = string.Empty;

    public string Title { get; init; } = string.Empty;

    public int BoardGroupId { get; init; }

    public int EngineId { get; init; }

    public int MarketId { get; init; }

    public bool IsTraded { get; init; }

    public bool IsPrimary { get; init; }

    public bool HasCandles { get; init; }

}

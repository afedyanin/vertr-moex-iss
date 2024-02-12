namespace Vertr.Moex.Iss.Entities;

public partial class BoardGroup
{
    public int Id { get; init; }

    public int BoardGroupId { get; init; }

    public string Title { get; init; } = string.Empty;

    public string Name { get; init; } = string.Empty;

    public int EngineId { get; init; }

    public int MarketId { get; init; }

    public bool IsTraded { get; init; }

    public bool IsDefault { get; init; }

    public bool IsOrderDriven { get; init; }

    public string? Category { get; init; }

}

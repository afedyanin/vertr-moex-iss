namespace Vertr.Moex.Iss.Entities;

public partial class SecurityType
{
    public int Id { get; init; }

    public string Name { get; init; } = string.Empty;

    public string Title { get; init; } = string.Empty;

    public int EngineId { get; init; }

    public string GroupName { get; init; } = string.Empty;

    public string StockType { get; init; } = string.Empty;
}

namespace Vertr.Moex.Generators.MetaItems;
internal class BoardGroupMeta
{
    public int Id { get; set; }

    public string Title { get; set; } = string.Empty;

    public string Name { get; set; } = string.Empty;

    public string PropertyName => Name.ToTitleCase();

    public int BoardGroupId { get; set; }

    public int EngineId { get; set; }

    public int MarketId { get; set; }

    public bool IsTraded { get; set; }

    public bool IsDefault { get; set; }

    public bool IsOrderDriven { get; set; }

    public string? Category { get; set; }
}

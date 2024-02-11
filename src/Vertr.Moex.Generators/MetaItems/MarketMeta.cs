namespace Vertr.Moex.Generators.MetaItems;
internal class MarketMeta
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Title { get; set; } = string.Empty;

    public string PropertyName => Name.ToTitleCase();

    public int MarketId { get; set; }

    public int EngineId { get; set; }

    public string? MarketPlace { get; set; }
}

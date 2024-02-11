namespace Vertr.Moex.Generators.MetaItems;
internal class MarketMeta
{
    public int Id { get; set; }

    public int TradeEngineId { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Title { get; set; } = string.Empty;

    public string? MarketPlace { get; set; }

    public string PropertyName => Name.ToTitleCase();
}

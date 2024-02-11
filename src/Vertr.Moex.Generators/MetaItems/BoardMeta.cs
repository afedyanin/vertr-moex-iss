namespace Vertr.Moex.Generators.MetaItems;
internal class BoardMeta
{
    public int Id { get; set; }

    public string BoardId { get; set; } = string.Empty;

    public string Title { get; set; } = string.Empty;

    public string PropertyName => BoardId.ToUpper();

    public int BoardGroupId { get; set; }

    public int EngineId { get; set; }

    public int MarketId { get; set; }

    public bool IsTraded { get; set; }

    public bool IsPrimary { get; set; }

}

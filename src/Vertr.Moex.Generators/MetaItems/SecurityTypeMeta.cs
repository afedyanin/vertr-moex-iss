namespace Vertr.Moex.Generators.MetaItems;

internal class SecurityTypeMeta
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Title { get; set; } = string.Empty;

    public string PropertyName => Name.ToTitleCase();

    public int EngineId { get; set; }

    public string GroupName { get; set; } = string.Empty;

    public string StockType { get; set; } = string.Empty;
}

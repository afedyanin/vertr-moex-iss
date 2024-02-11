namespace Vertr.Moex.Generators.MetaItems;
internal class SecurityCollectionMeta
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Title { get; set; } = string.Empty;

    public string PropertyName => Name.ToTitleCase();

    public int SecurityGroupId { get; set; }
}

namespace Vertr.Moex.Iss.Entities;
public partial class SecurityCollection
{
    public int Id { get; init; }

    public string Name { get; init; } = string.Empty;

    public string Title { get; init; } = string.Empty;

    public int SecurityGroupId { get; init; }
}

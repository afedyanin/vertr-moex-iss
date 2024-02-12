namespace Vertr.Moex.Iss.Entities;

public partial class SecurityGroup
{
    public int Id { get; init; }

    public string Name { get; init; } = string.Empty;

    public string Title { get; init; } = string.Empty;

    public bool IsHidden { get; init; }
}

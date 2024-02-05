namespace Vertr.Moex.Iss.UrlBuilderComponents;

// https://iss.moex.com/iss/engines.xml
public partial class Engine
{
    public required int Id { get; init; }
    public required string Name { get; init; }
    public required string Title { get; init; }

}

namespace Vertr.Moex.Iss.UrlBuilderComponents;

public class OutFormat
{
    public static readonly OutFormat Json = new OutFormat { Name = "json" };
    public static readonly OutFormat Xml = new OutFormat { Name = "xml" };
    public static readonly OutFormat Csv = new OutFormat { Name = "csv" };
    public required string Name { get; init; }
}

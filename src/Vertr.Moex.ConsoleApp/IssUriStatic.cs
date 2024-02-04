namespace Vertr.Moex.ConsoleApp;

internal static class IssUriStatic
{
}


public class OutFormat
{
    public static readonly OutFormat Json = new OutFormat { Name = "json" };
    public static readonly OutFormat Xml = new OutFormat { Name = "xml" };
    public static readonly OutFormat Csv = new OutFormat { Name = "csv" };
    public required string Name { get; init; }
}

public class Language
{
    public static readonly Language Rus = new Language { Name = "ru" };
    public static readonly Language Eng = new Language { Name = "en" };
    public required string Name { get; init; }
}

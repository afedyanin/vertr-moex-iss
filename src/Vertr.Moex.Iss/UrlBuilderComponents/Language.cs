namespace Vertr.Moex.Iss.UrlBuilderComponents;

public class Language
{
    public static readonly Language Rus = new Language { Name = "ru" };
    public static readonly Language Eng = new Language { Name = "en" };
    public required string Name { get; init; }
}

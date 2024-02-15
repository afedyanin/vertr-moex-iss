namespace Vertr.Moex.Iss.Entities;
public record class Column
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string ShortTitle { get; set; } = string.Empty;

    public string Title { get; set; } = string.Empty;

    public string Type { get; set; } = string.Empty;

    public int? Precision { get; set; }
}

namespace Vertr.Moex.Iss.Entities;
public record class Column
{
    public static readonly Column Unknown = new Column() { Id = 0, Name = "unknown", ShortTitle = "unknown", Title = "unknown", Precision = null, Type = "unknown" };

    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string ShortTitle { get; set; } = string.Empty;

    public string Title { get; set; } = string.Empty;

    public string Type { get; set; } = string.Empty;

    public int? Precision { get; set; }
}

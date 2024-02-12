namespace Vertr.Moex.Iss.Entities;
public partial class Duration
{
    public int Interval { get; init; }

    public int DurationInSeconds { get; init; }

    public int Days { get; init; }

    public string Title { get; init; } = string.Empty;

    public string Hint { get; init; } = string.Empty;
}

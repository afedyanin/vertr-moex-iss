namespace Vertr.Moex.Generators.MetaItems;
internal class DurationMeta
{
    public int Interval { get; set; }

    public int Duration { get; set; }

    public int Days { get; set; }

    public string Title { get; set; } = string.Empty;

    public string Hint { get; set; } = string.Empty;

    public string PropertyName => GetNameByDuration(Duration);

    internal static string GetNameByDuration(int duration)
    {
        var ts = TimeSpan.FromSeconds(duration);

        return duration switch
        {
            <= 0 => "Z0",
            < 60 => $"S{ts.Seconds}",
            < 60 * 60 => $"M{ts.Minutes}",
            < 60 * 60 * 24 => $"H{ts.Hours}",
            < 60 * 60 * 24 * 7 => $"D{ts.Days}",
            < 60 * 60 * 24 * 31 => $"W{ts.Days / 7}",
            < 60 * 60 * 24 * 31 * 3 => $"MN{ts.Days / 31}",
            _ => $"Q{ts.Days / (31 * 3)}",
        };
    }
}

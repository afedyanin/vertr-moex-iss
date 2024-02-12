using Vertr.Moex.Generators.MetaItems;

namespace Vertr.Moex.Generators.Tests;

[TestFixture(Category = "Unit")]
public class DurationMetaTests
{
    [TestCase(0, "Z0")]
    [TestCase(1, "S1")]
    [TestCase(45, "S45")]
    [TestCase(60, "M1")]
    [TestCase(62, "M1")]
    [TestCase(120, "M2")]
    [TestCase(123, "M2")]
    [TestCase(185, "M3")]
    [TestCase(60 * 60, "H1")]
    [TestCase((60 * 60) + 5, "H1")]
    [TestCase(60 * 60 * 3, "H3")]
    [TestCase(60 * 60 * 15, "H15")]
    [TestCase(60 * 60 * 24, "D1")]
    [TestCase((60 * 60 * 24) + 8000, "D1")]
    [TestCase(60 * 60 * 24 * 5, "D5")]
    [TestCase(60 * 60 * 24 * 7, "W1")]
    [TestCase(60 * 60 * 24 * 7 * 3, "W3")]
    [TestCase(60 * 60 * 24 * 31, "MN1")]
    [TestCase(60 * 60 * 24 * 31 * 2, "MN2")]
    [TestCase(60 * 60 * 24 * 31 * 3, "Q1")]
    [TestCase(60 * 60 * 24 * 31 * 3 * 2, "Q2")]
    public void CanGetDurationByInterval(int durationInSeconds, string name)
    {
        var res = DurationMeta.GetNameByDuration(durationInSeconds);
        Console.WriteLine($"{durationInSeconds} => {res}");
        Assert.That(res, Is.EqualTo(name));
    }

    [TestCase(12)]
    public void CanGetStringFromDuration(int duration)
    {
        var ts = TimeSpan.FromSeconds(duration);
        var tsString = $"S{ts.Seconds}";
        Assert.That(tsString, Is.EqualTo($"S{duration}"));
    }
}

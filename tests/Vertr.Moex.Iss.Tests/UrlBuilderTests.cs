using Vertr.Moex.Iss.Entities;
using Vertr.Moex.Iss.UrlBuilderComponents;

namespace Vertr.Moex.Iss.Tests;

[TestFixture(Category = "Unit")]
public class UrlBuilderTests
{
    [Test]
    public void CanCreateSimpleUrl()
    {
        var url = new UrlBuilder()
            .Securities("SU26223RMFS6")
            .UsePrimaryBoard
            .UseFormat(OutFormat.Json)
            .UseLang(Language.Eng)
            .Build();

        Assert.That(url, Is.Not.Empty);

        Console.WriteLine($"url={url}");
    }

    [Test]
    public void CanGetEngineInfo()
    {
        var url = new UrlBuilder()
            .Engines(Engine.Offboard)
            .Boards(Board.TQBR.BoardId)
            .Build();

        Assert.That(url, Is.Not.Empty);

        Console.WriteLine($"url={url}");
    }
}

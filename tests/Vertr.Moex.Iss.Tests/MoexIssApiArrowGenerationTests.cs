using Vertr.Moex.Iss.Entities;
using Vertr.Moex.Iss.Extensions;

namespace Vertr.Moex.Iss.Tests;

[TestFixture(Category = "Integration", Explicit = true)]
public class MoexIssApiArrowGenerationTests
{
    [Test]
    public async Task CanSaveSecurityColumnsBondsAsArrowFile()
    {
        var api = new MoexIssApi();

        var dfs = await api.SecurityColumns(
            Engine.Stock,
            Market.Stock_Bonds,
            [InfoBlockKey.Securities, InfoBlockKey.Marketdata]);

        for (var i = 0; i < dfs.Length; i++)
        {
            var fileName = $"security-columns-bonds-{i + 1}.arrow.txt";
            await dfs[i].ToArrowFile(fileName);
            Console.WriteLine($"file={fileName} saved.");
        }

        Assert.Pass();
    }

    [Test]
    public async Task CanSaveSecurityColumnsSharesAsArrowFile()
    {
        var api = new MoexIssApi();

        var dfs = await api.SecurityColumns(
            Engine.Stock,
            Market.Stock_Shares,
            [InfoBlockKey.Securities, InfoBlockKey.Marketdata]);

        for (var i = 0; i < dfs.Length; i++)
        {
            var fileName = $"security-columns-shares-{i + 1}.arrow.txt";
            await dfs[i].ToArrowFile(fileName);
            Console.WriteLine($"file={fileName} saved.");
        }

        Assert.Pass();
    }

    [Test]
    public async Task CanSaveSecuritiesSharesAsArrowFile()
    {
        var api = new MoexIssApi();

        var dfs = await api.Securities(
            Engine.Stock,
            Market.Stock_Shares,
            [InfoBlockKey.Securities, InfoBlockKey.Marketdata]);

        for (var i = 0; i < dfs.Length; i++)
        {
            var fileName = $"security-shares-{i + 1}.arrow.txt";
            await dfs[i].ToArrowFile(fileName);
            Console.WriteLine($"file={fileName} saved.");
        }

        Assert.Pass();
    }

    [Test]
    public async Task CanSaveSecuritiesBondsAsArrowFile()
    {
        var api = new MoexIssApi();

        var dfs = await api.Securities(
            Engine.Stock,
            Market.Stock_Bonds,
            [InfoBlockKey.Securities, InfoBlockKey.Marketdata]);

        for (var i = 0; i < dfs.Length; i++)
        {
            var fileName = $"security-bonds-{i + 1}.arrow.txt";
            await dfs[i].ToArrowFile(fileName);
            Console.WriteLine($"file={fileName} saved.");
        }

        Assert.Pass();
    }
}

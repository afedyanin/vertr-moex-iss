using Vertr.Moex.Iss;
using Vertr.Moex.Iss.Entities;

namespace Vertr.Moex.ConsoleApp;

internal sealed class Program
{
    public static async Task Main()
    {
        var api = new MoexIssApi();

        var dfs = await api.Securities(
            Engine.Stock,
            Market.Stock_Bonds,
            [InfoBlockKey.Securities, InfoBlockKey.Marketdata]);

        dfs[0].PrettyPrint();
    }
}

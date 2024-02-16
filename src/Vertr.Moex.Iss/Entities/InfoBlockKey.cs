namespace Vertr.Moex.Iss.Entities;

public class InfoBlockKey
{
    public static readonly InfoBlockKey Securities = new InfoBlockKey { Name = "securities" };
    public static readonly InfoBlockKey Marketdata = new InfoBlockKey { Name = "marketdata" };
    public static readonly InfoBlockKey Dataversion = new InfoBlockKey { Name = "dataversion" };
    public static readonly InfoBlockKey MarketdataYields = new InfoBlockKey { Name = "marketdata_yields" };
    public static readonly InfoBlockKey Trades = new InfoBlockKey { Name = "trades" };

    public string Name { get; init; } = string.Empty;
}

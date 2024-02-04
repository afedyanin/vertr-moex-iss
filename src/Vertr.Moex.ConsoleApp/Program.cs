namespace Vertr.Moex.ConsoleApp;

internal sealed class Program
{
    public static async Task Main()
    {
        using var httpClient = new HttpClient();

        var url = new IssUriBuilder()
            .Securities("SU26223RMFS6")
            .UsePrimaryBoard
            .UseFormat(OutFormat.Json)
            .UseLang(Language.Eng)
            .Build();

        Console.WriteLine(url);

        var res = await httpClient.GetStringAsync(url);

        Console.WriteLine(res);
    }
}

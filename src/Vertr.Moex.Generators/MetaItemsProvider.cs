using System.Text.Json;
using Vertr.Moex.Generators.MetaItems;
using Vertr.Moex.Generators.MetaItems.Factories;

namespace Vertr.Moex.Generators;
internal class MetaItemsProvider
{
    public EngineMeta[] Engines { get; } = new EngineMeta[0];

    public MarketMeta[] Markets { get; } = new MarketMeta[0];

    public BoardMeta[] Boards { get; } = new BoardMeta[0];

    public BoardGroupMeta[] BoardGroups { get; } = new BoardGroupMeta[0];

    public DurationMeta[] Durations { get; } = new DurationMeta[0];

    public SecurityTypeMeta[] SecurityTypes { get; } = new SecurityTypeMeta[0];

    public SecurityGroupMeta[] SecurityGroups { get; } = new SecurityGroupMeta[0];

    public SecurityCollectionMeta[] SecurityCollections { get; } = new SecurityCollectionMeta[0];

    public MetaItemsProvider(string? json)
    {
        if (string.IsNullOrEmpty(json))
        {
            return;
        }

        var dict = CreateJsonDataDictionary(json!);

        Engines = EngineMetaFactory.CreateEngines(dict["engines"]);
        Markets = MarketMetaFactory.CreateMarkets(dict["markets"]);
        Boards = BoardMetaFactory.CreateBoards(dict["boards"]);
        BoardGroups = BoardGroupMetaFactory.CreateBoardGroups(dict["boardgroups"]);
        Durations = DurationMetaFactory.CreateDurations(dict["durations"]);
        SecurityTypes = SecurityTypeMetaFactory.CreateSecurityTypes(dict["securitytypes"]);
        SecurityGroups = SecurityGroupMetaFactory.CreateSecurityGroups(dict["securitygroups"]);
        SecurityCollections = SecurityCollectionMetaFactory.CreateSecurityCollections(dict["securitycollections"]);
    }
    private static Dictionary<string, JsonElement> CreateJsonDataDictionary(string json)
    {
        var jDoc = JsonDocument.Parse(json);
        var root = jDoc.RootElement;

        var dict = new Dictionary<string, JsonElement>
        {
            { "engines", root.GetProperty("engines") },
            { "markets", root.GetProperty("markets") },
            { "boards", root.GetProperty("boards") },
            { "boardgroups", root.GetProperty("boardgroups") },
            { "durations", root.GetProperty("durations") },
            { "securitytypes", root.GetProperty("securitytypes") },
            { "securitygroups", root.GetProperty("securitygroups") },
            { "securitycollections", root.GetProperty("securitycollections") }
        };

        return dict;
    }
}

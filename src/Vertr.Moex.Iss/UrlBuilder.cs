using System.Text;
using Vertr.Moex.Iss.Entities;
using Vertr.Moex.Iss.UrlBuilderComponents;

namespace Vertr.Moex.Iss;
public class UrlBuilder(string? baseUrl = null)
{
    private const string _defaulBaseUrl = "https://iss.moex.com/iss";
    private const string _defaulFormat = "json";

    private readonly StringBuilder _pathbuilder = new StringBuilder();
    private readonly StringBuilder _queryBuilder = new StringBuilder();

    private readonly string _baseUrl = baseUrl ?? _defaulBaseUrl;

    private string _format = _defaulFormat;

    public UrlBuilder Path(string pathKey, string? pathValue = null)
    {
        if (string.IsNullOrEmpty(pathKey))
        {
            return this;
        }

        _pathbuilder.Append($"/{pathKey}");

        if (!string.IsNullOrEmpty(pathValue))
        {
            _pathbuilder.Append($"/{pathValue}");

        }
        return this;
    }

    public UrlBuilder Query(string key, string value)
    {
        _queryBuilder.Append($"{key}={value}&");

        return this;
    }

    public UrlBuilder SetFormat(string format)
    {
        if (string.IsNullOrEmpty(format))
        {
            _format = _defaulFormat;
            return this;
        }

        _format = format;
        return this;
    }

    public UrlBuilder Securities(string? security = null) => Path("securities", security);

    public UrlBuilder Engines(string? engine = null) => Path("engines", engine);

    public UrlBuilder Engines(Engine engine) => Engines(engine.Name);

    public UrlBuilder Markets(string? market = null) => Path("markets", market);

    public UrlBuilder Markets(Market market) => Markets(market.Name);

    public UrlBuilder Boards(string? board = null) => Path("boards", board);

    public UrlBuilder Boards(Board board) => Boards(board.BoardId);

    public UrlBuilder SecurityGroups(string? securityGroup = null) => Path("securitygroups", securityGroup);

    public UrlBuilder SecurityGroups(SecurityGroup securityGroup) => SecurityGroups(securityGroup.Name);

    public UrlBuilder BoardGroups(string? boardGroup = null) => Path("boardgroups", boardGroup);

    public UrlBuilder BoardGroups(BoardGroup boardGroup) => BoardGroups(boardGroup.Name);

    public UrlBuilder Sessions(string? session = null) => Path("sessions", session);

    public UrlBuilder Collections(string? collection = null) => Path("collections", collection);

    public UrlBuilder Collections(SecurityCollection securityCollection) => Collections(securityCollection.Name);

    public UrlBuilder Assets(string? asset = null) => Path("assets", asset);

    public UrlBuilder Series(string? seriesName = null) => Path("series", seriesName);

    public UrlBuilder SiteNews(long? newsId = null) => Path("sitenews", newsId?.ToString());

    public UrlBuilder Events(long? eventId = null) => Path("events", eventId?.ToString());

    public UrlBuilder Indices => Path("indices");

    public UrlBuilder Index => Path("index");

    public UrlBuilder Turnovers => Path("turnovers");

    public UrlBuilder Trades => Path("trades");

    public UrlBuilder OrderBook => Path("orderbook");

    public UrlBuilder Columns => Path("columns");

    public UrlBuilder Candles => Path("candles");

    public UrlBuilder History => Path("history");

    public UrlBuilder Statistics => Path("statistics");

    public UrlBuilder Complex => Path("complex");

    public UrlBuilder Futures => Path("futures");

    public UrlBuilder Bonds => Path("bonds");

    public UrlBuilder Aggregates => Path("aggregates");

    public UrlBuilder Analytics => Path("analytics");

    public UrlBuilder Forts => Path("forts");

    public UrlBuilder Volumes => Path("volumes");

    public UrlBuilder OpenPositions => Path("openpositions");

    public UrlBuilder OptionBoard => Path("optionboard");

    public UrlBuilder Stock => Path("stock");

    public UrlBuilder Yields => Path("yields");

    public UrlBuilder Dates => Path("dates");

    public UrlBuilder UsePrimaryBoard => Query("primary_board", "1");

    public UrlBuilder UseLang(Language lang) => Query("lang", lang.Name);

    public UrlBuilder UseFormat(OutFormat format) => SetFormat(format.Name);

    public UrlBuilder StartFromRow(int startRow) => Query("start", startRow.ToString());

    public UrlBuilder LimitRows(int limit) => Query("limit", limit.ToString());

    public UrlBuilder IncludeMeta(bool on) => Query("iss.meta", on ? "on" : "off");

    public UrlBuilder IncludeData(bool on) => Query("iss.data", on ? "on" : "off");

    public UrlBuilder Reversed(bool on) => Query("reversed", on ? "1" : "0");

    public UrlBuilder OnlyBlocks(InfoBlockKey[] blocks) => Query("iss.only", string.Join(',', blocks.Select(b => b.Name)));

    // TODO: Add query params - https://iss.moex.com/iss/reference/68

    public string Build()
    {
        var path = _pathbuilder.ToString();
        var query = _queryBuilder.ToString();

        var sb = new StringBuilder(_baseUrl);
        if (!string.IsNullOrEmpty(path))
        {
            sb.Append(path);
        }

        sb.Append($".{_format}");

        if (!string.IsNullOrEmpty(query))
        {
            sb.Append($"?{query.TrimEnd('&')}");
        }

        return sb.ToString();
    }
}

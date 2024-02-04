using System.Text;

namespace Vertr.Moex.ConsoleApp;
public class IssUriBuilder(string? baseUrl = null)
{
    private const string _defaulBaseUrl = "https://iss.moex.com/iss";
    private const string _defaulFormat = "json";

    private readonly StringBuilder _pathbuilder = new StringBuilder();
    private readonly StringBuilder _queryBuilder = new StringBuilder();

    private readonly string _baseUrl = baseUrl ?? _defaulBaseUrl;

    private string _format = _defaulFormat;

    public IssUriBuilder Path(string pathKey, string? pathValue = null)
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

    public IssUriBuilder Query(string key, string value)
    {
        _queryBuilder.Append($"&{key}={value}");

        return this;
    }

    public IssUriBuilder SetFormat(string format)
    {
        if (string.IsNullOrEmpty(format))
        {
            _format = _defaulFormat;
            return this;
        }

        _format = format;
        return this;
    }

    public IssUriBuilder Securities(string? security = null) => Path("securities", security);

    public IssUriBuilder Engines(string? engine = null) => Path("engines", engine);

    public IssUriBuilder Markets(string? market = null) => Path("markets", market);

    public IssUriBuilder Boards(string? board = null) => Path("boards", board);

    public IssUriBuilder SecurityGroups(string? securityGroup = null) => Path("securitygroups", securityGroup);

    public IssUriBuilder BoardGroups(string? boardGroup = null) => Path("boardgroups", boardGroup);

    public IssUriBuilder Sessions(string? session = null) => Path("sessions", session);

    public IssUriBuilder Collections(string? collection = null) => Path("collections", collection);

    public IssUriBuilder Assets(string? asset = null) => Path("assets", asset);

    public IssUriBuilder Series(string? seriesName = null) => Path("series", seriesName);

    public IssUriBuilder SiteNews(long? newsId = null) => Path("sitenews", newsId?.ToString());

    public IssUriBuilder Events(long? eventId = null) => Path("events", eventId?.ToString());

    public IssUriBuilder Indices => Path("indices");

    public IssUriBuilder Index => Path("index");

    public IssUriBuilder Turnovers => Path("turnovers");

    public IssUriBuilder Trades => Path("trades");

    public IssUriBuilder OrderBook => Path("orderbook");

    public IssUriBuilder Columns => Path("columns");

    public IssUriBuilder Candles => Path("candles");

    public IssUriBuilder History => Path("history");

    public IssUriBuilder Statistics => Path("statistics");

    public IssUriBuilder Complex => Path("complex");

    public IssUriBuilder Futures => Path("futures");

    public IssUriBuilder Bonds => Path("bonds");

    public IssUriBuilder Aggregates => Path("aggregates");

    public IssUriBuilder Analytics => Path("analytics");

    public IssUriBuilder Forts => Path("forts");

    public IssUriBuilder Volumes => Path("volumes");

    public IssUriBuilder OpenPositions => Path("openpositions");

    public IssUriBuilder OptionBoard => Path("optionboard");

    public IssUriBuilder Stock => Path("stock");

    public IssUriBuilder Yields => Path("yields");

    public IssUriBuilder Dates => Path("dates");

    public IssUriBuilder UsePrimaryBoard => Query("primary_board", "1");

    public IssUriBuilder UseLang(Language lang) => Query("lang", lang.Name);

    public IssUriBuilder UseFormat(OutFormat format) => SetFormat(format.Name);

    public IssUriBuilder StartFromRow(int startRow) => Query("start", startRow.ToString());

    public IssUriBuilder LimitRows(int limit) => Query("limit", limit.ToString());


    // TODO: Add query params - https://iss.moex.com/iss/reference/68
    // TODO: Add Static Data

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
            sb.Append($"?{query}");
        }

        return sb.ToString();
    }
}

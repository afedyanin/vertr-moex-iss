using Apache.Arrow.Ipc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Analysis;
using Microsoft.Net.Http.Headers;
using Vertr.Moex.Iss;
using Vertr.Moex.Iss.Entities;

namespace MoexScreener.Server.Controllers;

[Route("bff/moex-iss")]
[ApiController]
public class MoexIssController : ControllerBase
{
    [HttpGet("bonds")]
    public async Task GetBonds()
    {
        var api = new MoexIssApi();

        var dfs = await api.Securities(
            Engine.Stock,
            Market.Stock_Bonds,
            [InfoBlockKey.Securities]);

        await DataFrameToResponseStream(dfs[0]);
    }

    [HttpGet("shares")]
    public async Task GetShares()
    {
        var api = new MoexIssApi();

        var dfs = await api.Securities(
            Engine.Stock,
            Market.Stock_Shares,
            [InfoBlockKey.Securities]);

        await DataFrameToResponseStream(dfs[0]);
    }

    private async Task DataFrameToResponseStream(DataFrame df)
    {
        Response.Headers.Append(HeaderNames.ContentType, "application/vnd.apache.arrow.stream");
        Response.StatusCode = 200;

        var outputStream = Response.Body;

        foreach (var recordBatch in df.ToArrowRecordBatches())
        {
            using var writer = new ArrowStreamWriter(outputStream, recordBatch.Schema);
            await writer.WriteRecordBatchAsync(recordBatch);
            await writer.WriteEndAsync();
        }

        await outputStream.FlushAsync();
    }
}

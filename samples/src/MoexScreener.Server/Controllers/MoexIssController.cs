using Apache.Arrow.Ipc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;
using Vertr.Moex.Iss;
using Vertr.Moex.Iss.Entities;

namespace MoexScreener.Server.Controllers;

[Route("bff/moex-iss")]
[ApiController]
public class MoexIssController : ControllerBase
{
    [HttpGet("engines")]
    public async Task<IActionResult> GetEngines()
    {
        var api = new MoexIssApi();

        var dfs = await api.SecurityColumns(
            Engine.Stock,
            Market.Stock_Bonds,
            [InfoBlockKey.Securities]);

        return Ok(dfs[0]);
    }

    [HttpGet("engines-arrow")]
    public async Task GetEnginesArrow()
    {
        var api = new MoexIssApi();

        var dfs = await api.SecurityColumns(
            Engine.Stock,
            Market.Stock_Bonds,
            [InfoBlockKey.Securities]);


        foreach (var recordBatch in dfs[0].ToArrowRecordBatches())
        {
            using var writer = new ArrowStreamWriter(Response.Body, recordBatch.Schema);
            await writer.WriteRecordBatchAsync(recordBatch);
            await writer.WriteEndAsync();
        }

        Response.Headers.Append(HeaderNames.ContentDisposition, $"attachment; filename=\"sample-arrow.txt\"");
        Response.Headers.Append(HeaderNames.ContentType, "application/octet-stream");
        Response.StatusCode = 200;
        await Response.Body.FlushAsync();
    }
}

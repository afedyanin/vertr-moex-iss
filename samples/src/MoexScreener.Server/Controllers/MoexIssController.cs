using Apache.Arrow.Ipc;
using Microsoft.AspNetCore.Mvc;
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
    public async Task<IActionResult> GetEnginesArrow()
    {
        var api = new MoexIssApi();

        var dfs = await api.SecurityColumns(
            Engine.Stock,
            Market.Stock_Bonds,
            [InfoBlockKey.Securities]);


        // TODO: Use ArrowStreamWriter
        foreach (var recordBatch in dfs[0].ToArrowRecordBatches())
        {
            using var writer = new ArrowStreamWriter(Response.Body, recordBatch.Schema);
            await writer.WriteRecordBatchAsync(recordBatch);
            await writer.WriteEndAsync();
        }

        return Ok(dfs[0]);
    }
}

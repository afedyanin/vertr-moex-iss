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

    [HttpGet("simple-arrow")]
    public async Task GetEnginesArrow()
    {
        var api = new MoexIssApi();

        var dfs = await api.SecurityColumns(
            Engine.Stock,
            Market.Stock_Bonds,
            [InfoBlockKey.Securities]);


        Response.Headers.Append(HeaderNames.ContentType, "application/vnd.apache.arrow.stream");
        Response.StatusCode = 200;

        var outputStream = Response.Body;

        foreach (var recordBatch in dfs[0].ToArrowRecordBatches())
        {
            using var writer = new ArrowStreamWriter(outputStream, recordBatch.Schema);
            await writer.WriteRecordBatchAsync(recordBatch);
            await writer.WriteEndAsync();
        }

        await outputStream.FlushAsync();

    }

    [HttpGet("simple-file")]
    public async Task GetSimpleFile()
    {
        var filePath = "C:\\Users\\Anatoly\\Documents\\GitHub\\vertr-moex-iss\\samples\\src\\MoexScreener.Server\\wwwroot\\sample-data\\simple.txt";
        var inputStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
        var outputStream = this.Response.Body;

        Response.Headers.Append(HeaderNames.ContentDisposition, $"attachment; filename=\"simple.txt\"");
        Response.Headers.Append(HeaderNames.ContentType, "application/octet-stream");
        Response.StatusCode = 200;

        const int bufferSize = 1 << 10;
        var buffer = new byte[bufferSize];
        while (true)
        {
            var bytesRead = await inputStream.ReadAsync(buffer.AsMemory(0, bufferSize));
            if (bytesRead == 0)
            {
                break;
            }

            await outputStream.WriteAsync(buffer.AsMemory(0, bytesRead));
        }

        await outputStream.FlushAsync();
    }
}

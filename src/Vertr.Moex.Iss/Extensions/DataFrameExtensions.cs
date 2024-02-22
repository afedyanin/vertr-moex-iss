using Apache.Arrow.Ipc;
using Microsoft.Data.Analysis;

namespace Vertr.Moex.Iss.Extensions;
public static class DataFrameExtensions
{
    public static async Task ToArrowFile(this DataFrame df, string filePath)
    {
        using var stream = File.OpenWrite(filePath);
        foreach (var recordBatch in df.ToArrowRecordBatches())
        {
            using var writer = new ArrowFileWriter(stream, recordBatch.Schema);
            await writer.WriteRecordBatchAsync(recordBatch);
            await writer.WriteEndAsync();
        }
    }

    public static async Task ToArrowStream(this DataFrame df, Stream stream)
    {
        foreach (var recordBatch in df.ToArrowRecordBatches())
        {
            using var writer = new ArrowStreamWriter(stream, recordBatch.Schema);
            await writer.WriteRecordBatchAsync(recordBatch);
            await writer.WriteEndAsync();
        }
    }
}

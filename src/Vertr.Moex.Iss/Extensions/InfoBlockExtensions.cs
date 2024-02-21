using Microsoft.Data.Analysis;
using Vertr.Moex.Iss.DataFrameBuilders;
using Vertr.Moex.Iss.Entities;

namespace Vertr.Moex.Iss.Extensions;

public static class InfoBlockExtensions
{
    public static DataFrame ToDataFrame(this InfoBlock infoBlock)
    {
        var factory = new DataFrameFactory(infoBlock.ColumnNames, infoBlock.ColumnMetadata);
        var df = factory.Create(infoBlock.Rows);
        return df;
    }
}

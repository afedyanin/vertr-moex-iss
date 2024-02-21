using Microsoft.Data.Analysis;
using Vertr.Moex.Iss.Entities;

namespace Vertr.Moex.Iss.Extensions;

public static class InfoBlockExtensions
{
    public static DataFrame ToArrowDataFrame(this InfoBlock infoBlock)
    {
        return new DataFrame();
    }
}

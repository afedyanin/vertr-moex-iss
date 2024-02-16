using System.Text.Json;

namespace Vertr.Moex.Iss.Extensions;
internal static class JsonExtensions
{
    public static bool ContainsRootProperty(this JsonDocument jsonDocument, string propertyName)
        => jsonDocument.RootElement.TryGetProperty(propertyName, out var _);
}

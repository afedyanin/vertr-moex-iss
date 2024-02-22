using System.Text.Json;

namespace Vertr.Moex.Iss.Extensions;
internal static class JsonExtensions
{
    public static bool ContainsRootProperty(this JsonDocument jsonDocument, string propertyName)
        => jsonDocument.RootElement.TryGetProperty(propertyName, out var _);

    public static JsonElement GetPropertyOrThrow(this JsonElement jsonElement, string name)
    {
        if (!jsonElement.TryGetProperty(name, out var found))
        {
            throw new ArgumentException($"Json property={name} is not found.");
        }

        return found;
    }
}

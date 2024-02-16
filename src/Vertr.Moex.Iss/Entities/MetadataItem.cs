using System.Text.Json.Serialization;

namespace Vertr.Moex.Iss.Entities;
public record class MetadataItem
{
    [JsonPropertyName("type")]
    public string Type { get; set; } = string.Empty;

    [JsonPropertyName("bytes")]
    public int? Bytes { get; set; }

    [JsonPropertyName("max_size")]
    public int? MaxSize { get; set; }
}

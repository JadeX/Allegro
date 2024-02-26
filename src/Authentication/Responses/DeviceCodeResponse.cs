namespace JadeX.AllegroAPI;

using System.Text.Json.Serialization;

public record DeviceCodeResponse : ApiResponse
{
    [JsonPropertyName("device_code")]
    public string? DeviceCode { get; set; }

    [JsonPropertyName("expires_in")]
    public int ExpiresIn { get; set; }

    [JsonPropertyName("user_code")]
    public string? UserCode { get; set; }

    [JsonPropertyName("interval")]
    public int Interval { get; set; }

    [JsonPropertyName("verification_uri")]
    public string? VerificationUrl { get; set; }

    [JsonPropertyName("verification_uri_complete")]
    public string? VerificationUrlComplete { get; set; }
}

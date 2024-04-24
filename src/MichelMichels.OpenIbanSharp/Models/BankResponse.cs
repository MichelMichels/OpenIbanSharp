using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MichelMichels.OpenIbanSharp.Models;

public class BankResponse
{
    [JsonPropertyName("valid")]
    public bool IsValid { get; set; }

    [JsonPropertyName("messages")]
    public List<string> Messages { get; set; } = [];

    [JsonPropertyName("iban")]
    public string IBAN { get; set; } = string.Empty;

    [JsonPropertyName("bankData")]
    public Dictionary<string, string> BankData { get; set; } = [];

    [JsonPropertyName("checkResults")]
    public Dictionary<string, bool> Results { get; set; } = [];
}

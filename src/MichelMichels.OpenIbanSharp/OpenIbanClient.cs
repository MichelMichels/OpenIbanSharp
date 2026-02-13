using MichelMichels.OpenIbanSharp.Models;
using System.Net.Http.Json;

namespace MichelMichels.OpenIbanSharp;

public class OpenIbanClient(string baseUrl) : IOpenIbanClient
{
    private readonly string baseUrl = baseUrl ?? throw new ArgumentNullException(nameof(baseUrl));

    private readonly Dictionary<string, BankResponse> cache = [];

    private HttpClient? _httpClient;

    public async Task<BankResponse> Validate(string iban)
    {
        if (iban is null)
        {
            throw new ArgumentNullException(nameof(iban), "Parameter 'iban' can't be null.");
        }

        if (cache.TryGetValue(iban, out BankResponse? value))
        {
            return value;
        }

        HttpClient client = GetOrCreateHttpClient();

        string requestUri = $"validate/{iban.Trim()}?getBIC=true&validateBankCode=true";
        HttpResponseMessage message = await client.GetAsync(requestUri);

        BankResponse result = await message.Content.ReadFromJsonAsync<BankResponse>() ?? throw new NotSupportedException();

        cache.TryAdd(iban, result);
        return result;
    }

    private HttpClient GetOrCreateHttpClient()
    {
        return _httpClient ??= new HttpClient()
        {
            BaseAddress = new Uri(baseUrl)
        };
    }
}
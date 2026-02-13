using MichelMichels.OpenIbanSharp.Models;

namespace MichelMichels.OpenIbanSharp;

public interface IOpenIbanClient
{
    Task<BankResponse> Validate(string iban, CancellationToken? token = null);
}

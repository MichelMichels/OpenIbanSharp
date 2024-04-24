using MichelMichels.OpenIbanSharp.Models;
using System.Threading.Tasks;

namespace MichelMichels.OpenIbanSharp;

public interface IOpenIbanClient
{
    Task<BankResponse> Validate(string iban);
}

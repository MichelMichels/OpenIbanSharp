using OpenIbanSharp.Models;

namespace OpenIbanSharp.Interfaces
{
    public interface IOpenIbanClient
    {
        BankResponse Validate(string iban);
    }
}

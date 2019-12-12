using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenIbanSharp.Models;

namespace OpenIbanSharp.Interfaces
{
    public interface IOpenIbanClient
    {
        BankResponse Validate(string iban);
    }
}

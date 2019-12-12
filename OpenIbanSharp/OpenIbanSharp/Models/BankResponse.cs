using RestSharp.Deserializers;
using System.Collections.Generic;

namespace OpenIbanSharp.Models
{
    public class BankResponse
    {
        [DeserializeAs(Name = "valid")]
        public bool IsValid { get; set; }

        [DeserializeAs(Name = "messages")]
        public List<string> Messages { get; set; }

        [DeserializeAs(Name = "iban")]
        public string IBAN { get; set; }

        [DeserializeAs(Name = "bankData")]
        public Dictionary<string, string> BankData { get; set; }

        [DeserializeAs(Name = "checkResults")]
        public Dictionary<string, string> Results { get; set; }
    }    
}

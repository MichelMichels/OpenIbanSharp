using OpenIbanSharp.Interfaces;
using OpenIbanSharp.Models;
using RestSharp;
using SimpleRestSharp.Core;
using System;
using System.Collections.Generic;

namespace OpenIbanSharp.Clients
{
    public class OpenIbanClient : SimpleRestClient, IOpenIbanClient
    {
        private readonly Dictionary<string, BankResponse> cache;

        public OpenIbanClient(string baseUrl) : base(baseUrl)
        {
            cache = new Dictionary<string, BankResponse>();
        }

        public BankResponse Validate(string iban)
        {
            if(iban == null)
            {
                throw new ArgumentException("Parameter 'iban' can't be null.", nameof(iban));
            }

            if(cache.ContainsKey(iban))
            {
                return cache[iban];
            }

            var request = GetRequest("validate/{iban}", Method.GET);
            request.AddParameter("getBIC", "true");
            request.AddParameter("validateBankCode", "true");
            request.AddUrlSegment("iban", iban.Trim());

            var response = GetResponse<BankResponse>(request);
            cache.Add(iban, response.Data);

            return response.Data;
        }
    }
}
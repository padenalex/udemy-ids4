using System.Collections;
using System.Collections.Generic;
using IdentityServer4.Models;

namespace BankOfDotNet.IdentitySvr
{
    public class Config
    {
        public static IEnumerable<ApiResource> GetAllApiResources()
        {
            return new List<ApiResource>
            {
                new ApiResource("bankOfDotNetApi", "Bank of APi display name"),
            };
        }
        
        public static IEnumerable<ApiScope> GetApiScopes()
        {
            return new List<ApiScope>
            {
                new ApiScope(name: "bankOfDotNetApi",   displayName: "some scope descriptins"),
            };
        }

        public static IEnumerable<Client> GetClients()
        {
            return new List<Client>
            {
                new Client
                {
                    ClientId = "client",
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    ClientSecrets =
                    {
                        new Secret("secret".Sha256())
                    },
                    AllowedScopes = { "bankOfDotNetApi" }
                }
            };
        }
        
    //-------
    }
}
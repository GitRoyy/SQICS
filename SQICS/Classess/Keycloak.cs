using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQICS.Classess
{
    class Keycloak
    {
        private static string protocol;
        private static string host;
        private static string port;
        private static string realmName;
        public string clientId { get; }
        public string clientSecret { get; }

        public Keycloak()
        {
            protocol = "http";
            host = "localhost";
            port = "8080";
            realmName = "SQICS";
            clientId = "sqics_client";
            clientSecret = "5muszUgwgvNTQGc5VC0o9NFbzAlhOcjz";
        }

        public Uri GetTokenUri()
        {
            string endpoint = "/protocol/openid-connect/token";

            if (Debugger.IsAttached)
            {
                return new Uri("http://localhost:8080/realms/SQICS/protocol/openid-connect/token");
            }
            else
            {
                return new Uri(protocol + "://" + host + ":" + port + "/auth/realms/" + realmName + endpoint);
            }
                
        }

        public Uri GetUserInfoUri()
        {
            string endpoint = "/protocol/openid-connect/userinfo";

            if (Debugger.IsAttached)
            {
                return new Uri("http://localhost:8080/realms/SQICS/protocol/openid-connect/userinfo");
            }
            else
            {
                return new Uri(protocol + "://" + host + ":" + port + "/auth/realms/" + realmName + endpoint);
            }
        }
    }
}

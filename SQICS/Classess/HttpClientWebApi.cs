using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace SQICS.Classess
{
    class HttpClientWebApi
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly Keycloak keycloak = new Keycloak();
        private readonly NewPlanGet NPlanAPI = new NewPlanGet();

        JsonSerializerOptions _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

        public HttpClientWebApi(IHttpClientFactory httpClientFactory)
        {
            this._httpClientFactory = httpClientFactory;

        }

        public async Task<Token> GetToken(string username, string password)
        {
            Token auth = null;

            var stringContent = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("client_id", keycloak.clientId),
                new KeyValuePair<string, string>("grant_type", "password"),
                new KeyValuePair<string, string>("client_secret", keycloak.clientSecret),
                new KeyValuePair<string, string>("scope", "openid"),
                new KeyValuePair<string, string>("username", username),
                new KeyValuePair<string, string>("password", password),
            });

            HttpClient client = _httpClientFactory.CreateClient();

            try
            {
                var response = await client.PostAsync(keycloak.GetTokenUri(), stringContent);
                response.EnsureSuccessStatusCode();

                using (Stream responseStream = await response.Content.ReadAsStreamAsync())
                {
                    var ser = new DataContractJsonSerializer(typeof(Token));
                    auth = (Token)ser.ReadObject(responseStream);
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
            }

            return auth;
        }

        public async Task<UserInfo> GetUserInfo(Token token)
        {
            UserInfo user = null;

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = keycloak.GetUserInfoUri(),
                Content = new StringContent("", Encoding.UTF8, "application/json"),
            };

            request.Headers.Add("Authorization", "Bearer " + token.access_token);

            HttpClient client = _httpClientFactory.CreateClient();

            try
            {
                var response = await client.SendAsync(request).ConfigureAwait(false);
                response.EnsureSuccessStatusCode();

                using (Stream responseStream = await response.Content.ReadAsStreamAsync())
                {
                    var ser = new DataContractJsonSerializer(typeof(UserInfo));
                    user = (UserInfo)ser.ReadObject(responseStream);
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
            }

            return user;
        }

        public async Task<UserInfo> GetAuthInfo(Token token)
        {
            UserInfo user = null;

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = keycloak.GetAuthoUri(),
                Content = new StringContent("", Encoding.UTF8, "application/json"),
            };

            request.Headers.Add("Authorization", "Bearer " + token.access_token);

            HttpClient client = _httpClientFactory.CreateClient();

            try
            {
                var response = await client.SendAsync(request).ConfigureAwait(false);
                response.EnsureSuccessStatusCode();

                using (Stream responseStream = await response.Content.ReadAsStreamAsync())
                {
                    var ser = new DataContractJsonSerializer(typeof(UserInfo));
                    user = (UserInfo)ser.ReadObject(responseStream);
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
            }

            return user;
        }

        public async Task<List<NPlanInfo>> GetSubAssyName()
        {
            List<NPlanInfo> NPlan = null;

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = NPlanAPI.GetSubAssyName(),
                Content = new StringContent("", Encoding.UTF8, "application/json"),
            };

            HttpClient client = _httpClientFactory.CreateClient();

            try
            {
                var response = await client.GetAsync("https://62d4b9d95112e98e485248f2.mockapi.io/Test/api/AssyCode");
                var content = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    throw new ApplicationException(content);
                }

                NPlan = JsonSerializer.Deserialize<List<NPlanInfo>>(content, _options);
                //NPlanInfo NNPlan = JsonSerializer.Deserialize<NPlanInfo>(content, _options);


                //var response = await client.SendAsync(request).ConfigureAwait(false);
                //response.EnsureSuccessStatusCode();

                //using (Stream responseStream = await response.Content.ReadAsStreamAsync())
                //{
                //    var ser = new DataContractJsonSerializer(typeof(NPlanInfo));
                //    NPlan = (NPlanInfo)ser.ReadObject(responseStream);
                //}


            }
            catch (Exception ex)
            {
                Logger.Error(ex);
            }

            return NPlan;
        }
    }
}

using RestSharp;

namespace ThirdPartyAPIIntegrationRestSharpCRUD.RestSharpHealper
{
    public class RestClientHelper
    {
        private readonly RestClient _client;

        public RestClientHelper(string baseUrl)
        {
            _client = new RestClient(baseUrl);
        }

        public T Execute<T>(RestRequest request) where T : new()
        {
            var response = _client.Execute<T>(request);
            return response.Data;
        }

        public void Execute(RestRequest request)
        {
            _client.Execute(request);
        }
    }
}

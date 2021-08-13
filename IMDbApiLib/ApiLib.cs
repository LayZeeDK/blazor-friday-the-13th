using System.Net;
using System.Net.Http;

namespace IMDbApiLib
{
    public partial class ApiLib
    {
        public string BaseUrl => "https://imdb-api.com";

        private readonly string _apiKey;
        private readonly HttpClient _http;

        public ApiLib(string apiKey, HttpClient http)
        {
            _apiKey = apiKey;
            _http = http;
        }
    }
}

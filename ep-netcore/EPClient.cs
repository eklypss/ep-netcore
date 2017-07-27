using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using epnetcore.Data;
using epnetcore.Enum;
using epnetcore.Helpers.Url;
using epnetcore.Interfaces;
using epnetcore.Model.PlayerStats;
using epnetcore.Model.Search;
using Newtonsoft.Json;

namespace epnetcore
{
    public class EPClient : IEPClient
    {
        private readonly Requester _requester;
        private readonly string _key;

        public EPClient(string key)
        {
            if (string.IsNullOrEmpty(key))
            {
                throw new ArgumentException("API key cannot be null.");
            }

            _requester = new Requester();
            _key = key;
        }

        public async Task<SearchResponse> SearchAsync(string playerName)
        {
            var test = UrlBuilder.BuildString(RequestType.Search, _key, playerName);
            Console.WriteLine(test);
            using (var request = new HttpRequestMessage(HttpMethod.Get, test))
            {
                var result = await _requester.GetResultAsync(request);
                return JsonConvert.DeserializeObject<SearchResponse>(result);
            }
        }

        public async Task<int> GetPlayerIdAsync(string playerName)
        {
            var test = UrlBuilder.BuildString(RequestType.Search, _key, playerName);
            Console.WriteLine(test);
            using (var request = new HttpRequestMessage(HttpMethod.Get, test))
            {
                var result = await _requester.GetResultAsync(request);
                var content = JsonConvert.DeserializeObject<SearchResponse>(result);
                return (int)content.Players.Data.FirstOrDefault().Id;
            }
        }

        public async Task<StatsResponse> GetPlayerStats(int playerId)
        {
            var test = UrlBuilder.BuildString(RequestType.Stats, _key, string.Empty, playerId);
            Console.WriteLine(test);
            using (var request = new HttpRequestMessage(HttpMethod.Get, test))
            {
                var result = await _requester.GetResultAsync(request);
                return JsonConvert.DeserializeObject<StatsResponse>(result);
            }
        }
    }
}
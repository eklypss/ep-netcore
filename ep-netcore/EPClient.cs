using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using epnetcore.Data;
using epnetcore.Enum;
using epnetcore.Helpers.Url;
using epnetcore.Interfaces;
using epnetcore.Model.Leagues;
using epnetcore.Model.PlayerStats;
using epnetcore.Model.Search;
using epnetcore.Model.Teams;
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

        public async Task<SearchResponse> SearchPlayerAsync(string playerName)
        {
            var test = UrlBuilder.BuildString(RequestType.PlayerSearch, _key, playerName);
            Console.WriteLine(test);
            using (var request = new HttpRequestMessage(HttpMethod.Get, test))
            {
                var result = await _requester.GetResultAsync(request);
                return JsonConvert.DeserializeObject<SearchResponse>(result);
            }
        }

        public async Task<int> GetPlayerIdAsync(string playerName)
        {
            var test = UrlBuilder.BuildString(RequestType.PlayerSearch, _key, playerName);
            Console.WriteLine(test);
            using (var request = new HttpRequestMessage(HttpMethod.Get, test))
            {
                var result = await _requester.GetResultAsync(request);
                var content = JsonConvert.DeserializeObject<SearchResponse>(result);
                return (int)content.Players.Data.FirstOrDefault().Id;
            }
        }

        public async Task<StatsResponse> GetPlayerStatsAsync(int playerId)
        {
            var test = UrlBuilder.BuildString(RequestType.PlayerStats, _key, string.Empty, playerId);
            Console.WriteLine(test);
            using (var request = new HttpRequestMessage(HttpMethod.Get, test))
            {
                var result = await _requester.GetResultAsync(request);
                return JsonConvert.DeserializeObject<StatsResponse>(result);
            }
        }

        public async Task<TeamSearchResponse> SearchTeamAsync(string teamName)
        {
            var test = UrlBuilder.BuildString(RequestType.TeamSearch, _key, teamName);
            Console.WriteLine(test);
            using (var request = new HttpRequestMessage(HttpMethod.Get, test))
            {
                var result = await _requester.GetResultAsync(request);
                return JsonConvert.DeserializeObject<TeamSearchResponse>(result);
            }
        }

        public async Task<int> GetTeamIdAsync(string teamName, string leagueName = "")
        {
            var test = UrlBuilder.BuildString(RequestType.TeamSearch, _key, teamName);
            Console.WriteLine(test);
            using (var request = new HttpRequestMessage(HttpMethod.Get, test))
            {
                var result = await _requester.GetResultAsync(request);
                var content = JsonConvert.DeserializeObject<TeamSearchResponse>(result);
                return (int)content.Data.FirstOrDefault(x => x.LatestTeamStats.League.Name == leagueName).Id;
            }
        }

        public async Task<List<int>> GetLeagueIdsAsync(string leagueName)
        {
            var test = UrlBuilder.BuildString(RequestType.LeagueSearch, _key, leagueName);
            Console.WriteLine(test);
            using (var request = new HttpRequestMessage(HttpMethod.Get, test))
            {
                var result = await _requester.GetResultAsync(request);
                var content = JsonConvert.DeserializeObject<LeagueSearchResponse>(result);
                var list2 = new List<int>();
                content.Data.ForEach(x => list2.Add(x.Id));
                return list2;
                //return (int)content.Data.FirstOrDefault(x => x.LatestTeamStats.League.Name == leagueName).Id;
            }
        }

        public async Task<SearchResult> GetTopScorersAsync(int leagueId, int seasonId = 198)
        {
            var test = UrlBuilder.BuildString(RequestType.Scoring, _key, leagueId.ToString());
            Console.WriteLine(test);
            using (var request = new HttpRequestMessage(HttpMethod.Get, test))
            {
                var result = await _requester.GetResultAsync(request);
                var content = JsonConvert.DeserializeObject<SearchResult>(result);
                return content;
            }
        }

        public async Task<SearchResult> GetTopGoalsAsync(int leagueId, int seasonId = 198)
        {
            var test = UrlBuilder.BuildString(RequestType.Goals, _key, leagueId.ToString());
            Console.WriteLine(test);
            using (var request = new HttpRequestMessage(HttpMethod.Get, test))
            {
                var result = await _requester.GetResultAsync(request);
                var content = JsonConvert.DeserializeObject<SearchResult>(result);
                return content;
            }
        }

        public async Task<SearchResult> GetTopSVPAsync(int leagueId, int seasonId = 198)
        {
            var test = UrlBuilder.BuildString(RequestType.SVP, _key, leagueId.ToString());
            Console.WriteLine(test);
            using (var request = new HttpRequestMessage(HttpMethod.Get, test))
            {
                var result = await _requester.GetResultAsync(request);
                var content = JsonConvert.DeserializeObject<SearchResult>(result);
                return content;
            }
        }
    }
}

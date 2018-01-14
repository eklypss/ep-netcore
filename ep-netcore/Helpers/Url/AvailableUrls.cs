namespace epnetcore.Helpers.Url
{
    public static class AvailableUrls
    {
        public const string BASE_URLS = "http://api.eliteprospects.com/beta/";
        public const string SEARCH_PLAYER_URL = "http://api.eliteprospects.com/beta/search?type=player&q={0}&apiKey={1}";
        public const string PLAYER_STATS_URL = "http://api.eliteprospects.com/beta/players/{0}/stats?limit=100&apiKey={1}";
        public const string SEARCH_TEAM_URL = "http://api.eliteprospects.com/beta/teams?filter=name={0}&apiKey={1}";
        public const string SEARCH_LEAGUE_URL = "http://api.eliteprospects.com/beta/leagues?filter=name={0}&apiKey={1}";
    }
}

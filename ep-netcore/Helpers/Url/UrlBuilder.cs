using System;
using epnetcore.Enum;

namespace epnetcore.Helpers.Url
{
    public static class UrlBuilder
    {
        public static string BuildString(RequestType type, string apiKey, string searchTerm = "", int id = -1)
        {
            switch (type)
            {
                case RequestType.PlayerSearch:
                {
                    return string.Format(AvailableUrls.SEARCH_PLAYER_URL, searchTerm, apiKey);
                }
                case RequestType.PlayerStats:
                {
                    return string.Format(AvailableUrls.PLAYER_STATS_URL, id, apiKey);
                }
                case RequestType.TeamSearch:
                {
                    return string.Format(AvailableUrls.SEARCH_TEAM_URL, searchTerm, apiKey);
                }
                case RequestType.LeagueSearch:
                {
                    return string.Format(AvailableUrls.SEARCH_LEAGUE_URL, searchTerm, apiKey);
                }
                case RequestType.Scoring:
                {
                    return string.Format(AvailableUrls.SCORING_URL, searchTerm, apiKey);
                }
                case RequestType.Goals:
                {
                    return string.Format(AvailableUrls.GOALS_URL, searchTerm, apiKey);
                }
                case RequestType.SVP:
                {
                    return string.Format(AvailableUrls.SVP_URL, searchTerm, apiKey);
                }
                default:
                {
                    return string.Empty;
                }
            }
        }
    }
}

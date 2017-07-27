using System;
using epnetcore.Enum;

namespace epnetcore.Helpers.Url
{
    public static class UrlBuilder
    {
        public static string BuildString(RequestType type, string apiKey, string playerName = "", int playerId = -1)
        {
            switch (type)
            {
                case RequestType.Search:
                {
                    return string.Format("{0}{1}&apiKey={2}", AvailableUrls.SEARCH_PLAYER_URL, playerName, apiKey);
                }
                case RequestType.Stats:
                {
                    string fixedUrl = AvailableUrls.PLAYER_STATS_URL.Replace("@ID@", playerId.ToString());
                    return string.Format("{0}?apiKey={1}", fixedUrl, apiKey);
                }
                default:
                {
                    return string.Empty;
                }
            }
        }
    }
}
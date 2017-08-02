using System.Threading.Tasks;
using epnetcore.Model.PlayerStats;
using epnetcore.Model.Search;
using epnetcore.Model.Teams;

namespace epnetcore.Interfaces
{
    public interface IEPClient
    {
        Task<SearchResponse> SearchPlayerAsync(string playerName);

        Task<int> GetPlayerIdAsync(string playerName);

        Task<StatsResponse> GetPlayerStatsAsync(int playerId);

        Task<TeamSearchResponse> SearchTeamAsync(string teamName);

        Task<int> GetTeamIdAsync(string teamName, string leagueName);
    }
}
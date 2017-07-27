using System.Threading.Tasks;
using epnetcore.Model.Search;

namespace epnetcore.Interfaces
{
    public interface IEPClient
    {
        Task<SearchResponse> SearchAsync(string playerName);
    }
}
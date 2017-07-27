using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace epnetcore.Data
{
    public class Requester : IDisposable
    {
        private readonly HttpClient httpClient;

        internal Requester()
        {
            httpClient = new HttpClient();
        }

        public void Dispose()
        {
            httpClient.Dispose();
        }

        public async Task<string> GetResultAsync(HttpRequestMessage requestMessage)
        {
            var result = string.Empty;
            using (var response = await httpClient.GetAsync(requestMessage.RequestUri))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw new HttpRequestException();
                }
                using (var content = response.Content)
                {
                    result = await content.ReadAsStringAsync();
                }
            }
            return result;
        }
    }
}
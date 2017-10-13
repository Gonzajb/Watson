using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace WatsonORT.Presentacion.Servicios
{
    public class ResultadoWatsonService
    {
 
        string uri = "http://jony-personality.mybluemix.net/api/personality";

        public async Task<String> PostAsync(string uri, string data)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.PostAsync(uri, new StringContent(data));

            response.EnsureSuccessStatusCode();
            string content = await response.Content.ReadAsStringAsync();
            return content;
        }
    }
}
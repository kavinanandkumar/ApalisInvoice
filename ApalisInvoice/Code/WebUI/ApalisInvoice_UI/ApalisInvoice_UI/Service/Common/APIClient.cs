using ApalisInvoice_UI.Interface.Common;
using ApalisInvoiceViewModel.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ApalisInvoice_UI.Service.Common
{
    public class APIClient : IAPIClient
    {
        public async Task<T> GetAsync<T>(string apiUrl)
        {
            using (var client = new HttpClient())
            {
                using (var httpResponse = await client.GetAsync(apiUrl))
                {
                    httpResponse.EnsureSuccessStatusCode();
                    string responsContent = await httpResponse.Content.ReadAsStringAsync();
                    return Deserialize<T>(responsContent);
                }
            }
        }
        public async Task<MessageViewModel<T1>> PostAsync<T1, T2>(string apiUrl, T2 content)
        {
            using (var client = new HttpClient())
            {
                using (var httpResponse = await client.PostAsync(apiUrl, CreateHttpContent<T2>(content)))
                {
                    httpResponse.EnsureSuccessStatusCode();
                    string responsContent = await httpResponse.Content.ReadAsStringAsync();
                    return Deserialize<MessageViewModel<T1>>(responsContent);
                }
            }
        }

        private T Deserialize<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
        private HttpContent CreateHttpContent<T>(T content)
        {
            var json = JsonConvert.SerializeObject(content);
            return new StringContent(json,Encoding.UTF8, "application/json");
        }

    }
}

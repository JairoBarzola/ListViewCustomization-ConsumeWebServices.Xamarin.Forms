using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsumirWebServices
{
    class RestClient
    {
        public async  Task<T> GetRequest<T>(string url){
            try
            {
                HttpClient client = new HttpClient();
                var response = await client.GetAsync(url);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var jsonstring = await response.Content.ReadAsStringAsync();
                    return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(jsonstring);
                }
            }
            catch
            {
                return default(T);
            }
            return default(T);
        }
    }
}

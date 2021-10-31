using hcloud_api.Exceptions;
using hcloud_api.Models.Responses;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace hcloud_api.Extensions
{
    public static class Extensions
    {
        public static async Task<T> PostJsonAsync<T>(this HttpClient client, string requestUri, object data) where T : IResponse
        {
            var content = new StringContent(
                JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");

            var response = await client.PostAsync(requestUri, content);
            var responseStr = await response.Content.ReadAsStringAsync();

            return DeserializeAndThrow<T>(responseStr);
        }

        public static async Task<T> PostJsonAsync<T>(this HttpClient client, string requestUri) where T : IResponse
        {
            var response = await client.PostAsync(requestUri, null);
            var responseStr = await response.Content.ReadAsStringAsync();

            return DeserializeAndThrow<T>(responseStr);
        }

        public static async Task<T> PutJsonAsync<T>(this HttpClient client, string requestUri, object data) where T : IResponse
        {
            var content = new StringContent(
                JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");

            var response = await client.PutAsync(requestUri, content);
            var responseStr = await response.Content.ReadAsStringAsync();

            return DeserializeAndThrow<T>(responseStr);
        }

        public static async Task<T> DeleteJsonAsync<T>(this HttpClient client, string requestUri) where T : IResponse
        {
            var response = await client.DeleteAsync(requestUri);
            var responseStr = await response.Content.ReadAsStringAsync();

            return DeserializeAndThrow<T>(responseStr);
        }

        public static async Task<T> GetJsonAsync<T>(this HttpClient client, string requestUri) where T : IResponse
        {
            var response = await client.GetAsync(requestUri);
            var responseStr = await response.Content.ReadAsStringAsync();

            return DeserializeAndThrow<T>(responseStr);
        }

        private static T DeserializeAndThrow<T>(string json) where T : IResponse
        {
            var result = JsonConvert.DeserializeObject<T>(json, new JsonSerializerSettings { DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate });

            if (result?.Error != null)
                throw new HCloudException()
                {
                    Error = result.Error
                };

            return result;
        }

        public static void AddNotNull(this Dictionary<string, object> dictionary, string key, object value)
        {
            if (value != null)
                dictionary.Add(key, value);
        }

        public static string ToQuery(this Dictionary<string, object> query)
        {
            return query.Aggregate(string.Empty, (p, pair) =>
            {
                if (!p.EndsWith("?"))
                    p += "&";

                return p + $"{pair.Key}={pair.Value}";
            });
        }
    }
}

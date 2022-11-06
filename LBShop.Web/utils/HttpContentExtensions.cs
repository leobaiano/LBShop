using Microsoft.Net.Http.Headers;
using System.Text.Json;

namespace LBShop.Web.utils
{
    public static class HttpContentExtensions
    {
        private static MediaTypeHeaderValue contentType = new MediaTypeHeaderValue("application/json");

        public static async Task<T> GetAsync<T>(this HttpResponseMessage response)
        {
            if (!response.IsSuccessStatusCode) throw
                    new ApplicationException(
                        $"Something went wrongcalling the API: " +
                        $"{response.ReasonPhrase}");
            var dataAsString = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            return JsonSerializer.Deserialize<T>(dataAsString,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }
        public static Task<HttpResponseMessage> PostAsJson<T>(
            this HttpClient httpClient,
            string url,
            T data)
        {
            var dataAsString = JsonSerializer.Serialize(data);
            var content = new StringContent(dataAsString);
            content.Headers.ContentType = contentType;
            return httpClient.PostAsync(url, content);
        }
        public static Task<HttpResponseMessage> PuttAsJson<T>(
            this HttpClient httpClient,
            string url,
            T data)
        {
            var dataAsString = JsonSerializer.Serialize(data);
            var content = new StringContent(dataAsString);
            content.Headers.ContentType = contentType;
            return httpClient.PutAsync(url, content);
        }

    }
}

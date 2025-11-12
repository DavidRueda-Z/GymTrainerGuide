using System.Net.Http.Json;
using System.Text.Json;
using GymTrainerGuide.Web.Repositories;


namespace GymTrainerGuide.Web.Repositories
{
    public class Repository : IRepository
    {
        private readonly HttpClient _httpClient;

        public Repository(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<HttpResponseWrapper<T>> Get<T>(string url)
        {
            var response = await _httpClient.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var responseDeserialized = await DeserializeResponse<T>(response);
                return new HttpResponseWrapper<T>(responseDeserialized, false, response);
            }

            return new HttpResponseWrapper<T>(default, true, response);
        }

        public async Task<HttpResponseWrapper<TResponse>> Post<T, TResponse>(string url, T data)
        {
            var response = await _httpClient.PostAsJsonAsync(url, data);
            if (response.IsSuccessStatusCode)
            {
                var responseDeserialized = await DeserializeResponse<TResponse>(response);
                return new HttpResponseWrapper<TResponse>(responseDeserialized, false, response);
            }

            return new HttpResponseWrapper<TResponse>(default, true, response);
        }

        public async Task<HttpResponseWrapper<object>> Put<T>(string url, T data)
        {
            var response = await _httpClient.PutAsJsonAsync(url, data);
            return new HttpResponseWrapper<object>(null, !response.IsSuccessStatusCode, response);
        }

        public async Task<HttpResponseWrapper<object>> Delete(string url)
        {
            var response = await _httpClient.DeleteAsync(url);
            return new HttpResponseWrapper<object>(null, !response.IsSuccessStatusCode, response);
        }

        private async Task<T> DeserializeResponse<T>(HttpResponseMessage httpResponse)
        {
            var responseString = await httpResponse.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(responseString,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true })!;
        }
    }
}

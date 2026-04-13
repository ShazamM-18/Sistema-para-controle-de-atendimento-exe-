using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace SuporteApp.Services
{
    public class ApiService
    {
        private readonly HttpClient _httpClient;
        private readonly JsonSerializerOptions _jsonOptions;

        public string BaseUrl { get; } = "https://localhost:7043/api";
        public string? Token { get; private set; }

        public ApiService()
        {
            _httpClient = new HttpClient();
            _jsonOptions = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
        }

        public void DefinirToken(string token)
        {
            Token = token;
        }

        public void LimparToken()
        {
            Token = null;
        }

        private void AplicarAuthorizationHeader()
        {
            _httpClient.DefaultRequestHeaders.Authorization = null;

            if (!string.IsNullOrWhiteSpace(Token))
            {
                _httpClient.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer", Token);
            }
        }

        public async Task<TResponse?> PostAsync<TRequest, TResponse>(string endpoint, TRequest dados)
        {
            AplicarAuthorizationHeader();

            var json = JsonSerializer.Serialize(dados);
            using var content = new StringContent(json, Encoding.UTF8, "application/json");

            using var response = await _httpClient.PostAsync($"{BaseUrl}/{endpoint}", content);
            var responseContent = await response.Content.ReadAsStringAsync();

            if (string.IsNullOrWhiteSpace(responseContent))
                return default;

            return JsonSerializer.Deserialize<TResponse>(responseContent, _jsonOptions);
        }

        public async Task<TResponse?> GetAsync<TResponse>(string endpoint)
        {
            AplicarAuthorizationHeader();

            using var response = await _httpClient.GetAsync($"{BaseUrl}/{endpoint}");
            var responseContent = await response.Content.ReadAsStringAsync();

            if (string.IsNullOrWhiteSpace(responseContent))
                return default;

            return JsonSerializer.Deserialize<TResponse>(responseContent, _jsonOptions);
        }

        public async Task<TResponse?> PatchAsync<TRequest, TResponse>(string endpoint, TRequest dados)
        {
            AplicarAuthorizationHeader();

            var json = JsonSerializer.Serialize(dados);
            using var content = new StringContent(json, Encoding.UTF8, "application/json");

            using var request = new HttpRequestMessage(new HttpMethod("PATCH"), $"{BaseUrl}/{endpoint}")
            {
                Content = content
            };

            using var response = await _httpClient.SendAsync(request);
            var responseContent = await response.Content.ReadAsStringAsync();

            if (string.IsNullOrWhiteSpace(responseContent))
                return default;

            return JsonSerializer.Deserialize<TResponse>(responseContent, _jsonOptions);
        }
    }
}
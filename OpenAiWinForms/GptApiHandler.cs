using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

public class GptApiHandler
{
    private readonly HttpClient _httpClient;
    private readonly string _apiKey;

    public GptApiHandler(string? apiKey)
    {
        if (string.IsNullOrEmpty(apiKey))
        {
            apiKey = OpenAiWinForms.Properties.Settings.Default.API_KEY;
        }
        _httpClient = new HttpClient();
        _apiKey = apiKey;
        _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _apiKey);
    }

    public async Task<string> GenerateTextAsync(string prompt)
    {
        var requestUrl = "https://api.openai.com/v1/engines/text-davinci-002/completions";
        var requestData = new
        {
            prompt,
            max_tokens = OpenAiWinForms.Properties.Settings.Default.Max_Tokens,
            n = OpenAiWinForms.Properties.Settings.Default.nResponses,
            temperature = OpenAiWinForms.Properties.Settings.Default.Temperature,
        };

        var jsonContent = JsonConvert.SerializeObject(requestData);
        var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

        int retries = 5;
        int delay = 1000; // Tiempo de espera inicial en milisegundos

        for (int i = 0; i < retries; i++)
        {
            var response = await _httpClient.PostAsync(requestUrl, content);

            if (response.IsSuccessStatusCode)
            {
                var responseJson = await response.Content.ReadAsStringAsync();
                dynamic responseObject = JsonConvert.DeserializeObject(responseJson);
                return responseObject.choices[0].text.ToString().Trim();
            }
            else if (response.StatusCode == HttpStatusCode.TooManyRequests)
            {
                await Task.Delay(delay); // Espera antes de intentarlo de nuevo
                delay *= 2; // Duplica el tiempo de espera para el siguiente intento
            }
            else
            {
                throw new Exception($"Error en la solicitud de la API: {response.StatusCode}");
            }
        }

        throw new Exception("Se alcanzó el límite de reintento debido a demasiadas solicitudes.");
    }
}

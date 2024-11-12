using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FrontEnd
{
    public enum HttpVerb
    {
        GET,
        POST,
        PUT,
        DELETE
    }

    public class RESTClient : IDisposable
    {
        private readonly HttpClient _httpClient;

        public string EndPoint { get; set; } // La URL base de la API
        public HttpVerb HttpMethod { get; set; } = HttpVerb.GET;

        // Constructor
        public RESTClient(string endPoint)
        {
            EndPoint = endPoint;
            _httpClient = new HttpClient();
        }

        // Método genérico para realizar la solicitud HTTP
        public async Task<string> MakeRequestAsync(string jsonData = null)
        {
            string responseValue = string.Empty;

            try
            {
                HttpRequestMessage request = new HttpRequestMessage(new HttpMethod(HttpMethod.ToString()), EndPoint);

                // Si es POST o PUT, se envía el cuerpo de la solicitud
                if (jsonData != null)
                {
                    request.Content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                }

                // Obtiene la respuesta de la solicitud
                HttpResponseMessage response = await _httpClient.SendAsync(request);
                responseValue = await response.Content.ReadAsStringAsync();

                // Manejo de códigos de estado
                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception($"Error: {response.StatusCode}, {responseValue}");
                }
            }
            catch (Exception ex)
            {
                responseValue = $"{{\"error\": \"{ex.Message}\"}}";
            }

            return responseValue;
        }

        // Método de ayuda para hacer una solicitud GET
        public async Task<string> GetAsync()
        {
            HttpMethod = HttpVerb.GET;
            return await MakeRequestAsync();
        }

        // Método de ayuda para hacer una solicitud POST
        public async Task<string> PostAsync(string jsonData)
        {
            HttpMethod = HttpVerb.POST;
            return await MakeRequestAsync(jsonData);
        }

        // Método de ayuda para hacer una solicitud PUT
        public async Task<string> PutAsync(string jsonData)
        {
            HttpMethod = HttpVerb.PUT;
            return await MakeRequestAsync(jsonData);
        }

        // Método de ayuda para hacer una solicitud DELETE
        public async Task<string> DeleteAsync()
        {
            HttpMethod = HttpVerb.DELETE;
            return await MakeRequestAsync();
        }

        // Dispose para liberar recursos
        public void Dispose()
        {
            _httpClient?.Dispose();
        }
        public async Task<string> GetAsync(string endpoint = "")
        {
            HttpMethod = HttpVerb.GET;
            // Concatenamos el endpoint adicional al EndPoint base
            EndPoint = $"{EndPoint}{endpoint}";
            return await MakeRequestAsync();
        }
        // Método de ayuda para hacer una solicitud DELETE con un endpoint adicional
        public async Task<string> DeleteAsync(string endpoint = "")
        {
            HttpMethod = HttpVerb.DELETE;
            // Concatenamos el endpoint adicional al EndPoint base
            EndPoint = $"{EndPoint}{endpoint}";
            return await MakeRequestAsync();
        }

    }
}
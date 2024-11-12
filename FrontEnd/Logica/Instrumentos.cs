using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FrontEnd.Logica
{
    public class Instrumentos : Cuenta
    {
        public int IDdeCuenta { get; set; }
        public string Instrumento { get; set; }

        public async Task AsignarInstrumento(int IDdeCuenta, string nuevoInstrumento)
        {
            var client = new HttpClient();
            // Verifica si el usuario ya existe en la tabla por su ID
            var existingInstrumentos = await ObtenerInstrumentosPorCuenta(IDdeCuenta);

            if (existingInstrumentos.Count > 0)
            {
                // Edita el instrumento si el usuario ya tiene uno en la tabla

                string url = $"https://localhost:44329/Instrumentos/edit/{IDdeCuenta}/{Uri.EscapeDataString(nuevoInstrumento)}";
                var response = await client.PutAsync(url, null); // Sin cuerpo, solo usa la URL
            }
            else
            {
                // Si no existe en la tabla, crea el nuevo instrumento
                var data = new
                {
                    IDdeCuenta = IDdeCuenta,
                    Instrumento = nuevoInstrumento
                };

                string jsonData = JsonConvert.SerializeObject(data);

                string url = $"https://localhost:44329/Instrumentos/create";
                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                var response = await client.PostAsync(url, content);

                if (response.IsSuccessStatusCode)
                {
                }
                else
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    throw new HttpRequestException($"Error al crear el instrumento: {responseContent}");
                }
            }
        }

        public async Task<List<Instrumentos>> ObtenerInstrumentosPorCuenta(int IDdeCuenta)
        {
            var clientGet = new HttpClient();
            string url = $"https://localhost:44329/Instrumentos/{IDdeCuenta}";
            var response = await clientGet.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                string responseData = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<Instrumentos>>(responseData);
            }
            return new List<Instrumentos>(); // Retorna lista vacía si no hay instrumentos
        }

        public override string ToString()
        {
            return $"Instrumentos: {{ " +
                   $"ID de Cuenta: {IDdeCuenta}, " +
                   $"Instrumento: {Instrumento} }}";
        }
    }
}

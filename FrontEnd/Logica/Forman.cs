using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FrontEnd.Logica
{
    class Forman
    {
        public string baseUrl = "https://localhost:44330/api/Forman";
        public int IDdeCuenta { get; set; }  // ID de Cuenta
        public int IDdeBanda { get; set; }   // ID de Banda
        public bool Admin { get; set; }

        // Método para crear la interacción
        public async Task<string> CrearInteraccionAsync(int idCuenta, int idBanda)
        {
            using (HttpClient client = new HttpClient())
            {
                // Crear un objeto Forman con los datos proporcionados
                var nuevaInteraccion = new Forman
                {
                    IDdeCuenta = idCuenta,
                    IDdeBanda = idBanda,
                    Admin = false // Configurado por defecto a false
                };

                // Serializar el objeto a JSON usando JsonConvert de Newtonsoft.Json
                string jsonContent = JsonConvert.SerializeObject(nuevaInteraccion);
                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                // Realizar la solicitud POST a la API
                HttpResponseMessage response = await client.PostAsync($"{baseUrl}/Create", content);

                // Verificar la respuesta
                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    return $"Interacción creada exitosamente: {responseBody}";
                }
                else
                {
                    string errorBody = await response.Content.ReadAsStringAsync();
                    return $"Error al crear la interacción: {errorBody}";
                }
            }
        }
    }
}

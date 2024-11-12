using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FrontEnd.Logica
{
    class Banda
    {
        public string baseUrl = "https://localhost:44330/api/Banda";
        public int id { get; set; }
        public int id_de_musico { get; set; }
        public string nombre { get; set; }
        public bool activo { get; set; }


        public async Task CrearBandaAsync(string nombreBanda, string biografiaBanda, int idUsuario)
        {
            // Verificar si la cuenta es de un músico
            var cuenta = await new Cuenta().ObtenerUsuarioPorId(idUsuario);

            if (!cuenta.musico)
            {
                // Si la cuenta no es de un músico, mostrar un mensaje o retornar un error
                Console.WriteLine("Solo los músicos pueden crear una banda.");
                return;
            }

            // Si es músico, se envían los datos a la API para crear la banda
            var clientPost = new RESTClient($"{baseUrl}/create");

            var nuevaBanda = new
            {
                IDdeMusico = idUsuario, // ID del músico (cuenta)
                nombre = nombreBanda,
                biografia = biografiaBanda
            };

            // Serializar la banda a JSON
            string jsonData = JsonConvert.SerializeObject(nuevaBanda);

            // Realizar la solicitud POST a la API
            string response = await clientPost.PostAsync(jsonData);

            // Manejo de respuesta
            if (!string.IsNullOrWhiteSpace(response))
            {
                // Aquí puedes procesar la respuesta si la banda fue creada exitosamente
                Console.WriteLine("Banda creada exitosamente.");
            }
            else
            {
                // Si hubo un error al crear la banda
                Console.WriteLine("Hubo un error al crear la banda.");
            }
        }

        public async Task<string> EditarBandaAsync(int id, string nombre, string biografia)
        {
            using (HttpClient client = new HttpClient())
            {
                var bandaActualizada = new
                {
                    ID = id,
                    nombre = nombre,
                    biografia = biografia
                };

                // Convertir el objeto a JSON
                var jsonContent = JsonConvert.SerializeObject(bandaActualizada);
                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                // Enviar la solicitud POST o PUT
                var response = await client.PostAsync($"{baseUrl}/Edit/{id}", content);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsStringAsync();
                }
                else
                {
                    return $"Error: {response.StatusCode}, {await response.Content.ReadAsStringAsync()}";
                }
            }
        }
        public async Task<bool> EliminarBanda(int idBanda, int idUsuario)
        {
            var client = new RESTClient("https://localhost:44330/api/Banda");

            // Paso 1: Verificar si el usuario es el creador de la banda
            string responseVerificacion = await client.GetAsync($"/VerificarCreador/{idBanda}/{idUsuario}");

            if (responseVerificacion == "true") // Si el resultado es un "true" de la API
            {
                // Paso 2: Enviar la solicitud de eliminación
                string responseDelete = await client.DeleteAsync($"/Delete/{idBanda}");
                return responseDelete.Contains("exitosamente");
            }

            return false; // No se permite eliminar la banda
        }



    }
}

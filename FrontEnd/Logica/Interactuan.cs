using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

public class Interactuan
{
    [JsonProperty("ID")]
    public int ID { get; set; }

    [JsonProperty("IDEmisor")]
    public int IDdeEmisor { get; set; }

    [JsonProperty("IDReceptor")]
    public int IDdeReceptor { get; set; }

    [JsonProperty("Tipo")]
    public string Tipo { get; set; }

    [JsonProperty("Estado")]
    public string Estado { get; set; }

    [JsonProperty("Contenido")]
    public string Contenido { get; set; }

    [JsonProperty("Fecha")]
    public DateTime Fecha { get; set; }

    [JsonProperty("Notificacion")]
    public string Notificacion { get; set; }

    [JsonProperty("Seguido")]
    public bool Seguido { get; set; }

    private readonly HttpClient _httpClient;

    public Interactuan()
    {
        // Inicializar HttpClient solo una vez para evitar instancias innecesarias.
        _httpClient = new HttpClient();
        _httpClient.BaseAddress = new Uri("https://localhost:44329/"); // Base URL de la API
    }

    public async Task<bool> VerificarInteraccionExistente(int idEmisor, int idReceptor)
    {
        var response = await _httpClient.GetAsync($"Interactuan/VerificarInteraccion/{idEmisor}/{idReceptor}");
        return response.IsSuccessStatusCode && bool.Parse(await response.Content.ReadAsStringAsync());
    }


    public async Task DejarDeSeguir(int idEmisor, int idReceptor)
    {
            // Llamada a la API para obtener la interacción entre los usuarios
            var obtenerInteraccionResponse = await _httpClient.GetAsync($"Interactuan/BuscarInteraccion/{idEmisor}/{idReceptor}");

            if (obtenerInteraccionResponse.IsSuccessStatusCode)
            {
                // Leer la respuesta como string
                var responseString = await obtenerInteraccionResponse.Content.ReadAsStringAsync();

                // Deserializar la respuesta JSON manualmente
                var interaccion = JsonConvert.DeserializeObject<Interactuan>(responseString);

                // Obtener la ID de la interacción
                var idInteraccion = interaccion.ID;

                // Llamada a la API para eliminar la interacción usando la ID
                var eliminarResponse = await _httpClient.DeleteAsync($"Interactuan/Delete/{idInteraccion}");

                if (eliminarResponse.IsSuccessStatusCode)
                {
                    // Actualizar contadores si es necesario
                    await ActualizarContadores(idReceptor);
                }
                else
                {
                    string errorResponse = await eliminarResponse.Content.ReadAsStringAsync();
                }
            }
            else
            {
                string errorResponse = await obtenerInteraccionResponse.Content.ReadAsStringAsync();
            }
    }









    // Método para seguir a una cuenta
    public async Task SeguirCuenta(int idEmisor, int idReceptor)
    {
        try
        {

            // Crear la interacción de tipo "seguir cuenta"
            var data = new
            {
                IDdeEmisor = idEmisor,
                IDdeReceptor = idReceptor,
                Tipo = "Seguir",
                Estado = "",
                Contenido = "",
                Fecha = DateTime.Now,
                Notificacion = $"{idEmisor} ha comenzado a seguir tu cuenta.",
                Seguido = true
            };

            // Serializar los datos
            string jsonData = JsonConvert.SerializeObject(data);
            var contentToPost = new StringContent(jsonData, Encoding.UTF8, "application/json");

            // Realizar la solicitud POST para crear la interacción
            HttpResponseMessage response = await _httpClient.PostAsync("Interactuan/create", contentToPost);

            if (response.IsSuccessStatusCode)
            {
                await ActualizarContadores(idReceptor);
            }
            else
            {
                string errorResponse = await response.Content.ReadAsStringAsync();
            }
        }
        catch (Exception ex)
        {
        }
    }
    public async Task<(int seguidores, int seguidos)> ActualizarContadores(int idUsuarioAjeno)
    {
        try
        {

            var responseSeguidoresTask = _httpClient.GetAsync($"Interactuan/Seguidores/{idUsuarioAjeno}");
            var responseSeguidosTask = _httpClient.GetAsync($"Interactuan/Seguidos/{idUsuarioAjeno}");

            await Task.WhenAll(responseSeguidoresTask, responseSeguidosTask);

            int seguidoresCount = int.Parse(await responseSeguidoresTask.Result.Content.ReadAsStringAsync());
            int seguidosCount = int.Parse(await responseSeguidosTask.Result.Content.ReadAsStringAsync());

            return (seguidoresCount, seguidosCount);
        }
        catch (Exception ex)
        {
            return (0, 0);
        }
    }

    public async Task EnviarMensaje(int idEmisor, int idReceptor, string contenido)
    {
        try
        {
            // Crear la interacción de tipo "Mensaje"
            var data = new
            {
                IDdeEmisor = idEmisor,
                IDdeReceptor = idReceptor,
                Tipo = "Mensaje", // Aquí puedes usar un tipo de interacción adecuado
                Estado = "Enviado", // Puedes agregar estado si es necesario
                contenido = contenido,
                fecha = DateTime.Now,
                notificacion = $"{idEmisor} te ha enviado un mensaje.",
                seguido = false // Esto no aplica para mensajes, pero si es necesario puedes ajustarlo
            };

            // Serializar los datos
            string jsonData = JsonConvert.SerializeObject(data);
            var contentToPost = new StringContent(jsonData, Encoding.UTF8, "application/json");

            // Realizar la solicitud POST para crear la interacción
            HttpResponseMessage response = await _httpClient.PostAsync("Interactuan/EnviarMensaje", contentToPost);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Mensaje enviado exitosamente.");
            }
            else
            {
                string errorResponse = await response.Content.ReadAsStringAsync();
                MessageBox.Show($"Error al enviar mensaje: {errorResponse}");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error: {ex.Message}");
        }
    }
    public async Task<List<Interactuan>> ObtenerMensajes(int idEmisor, int idReceptor)
    {
        try
        {
            // Mensaje de depuración: Antes de hacer la solicitud HTTP
            MessageBox.Show($"Obteniendo mensajes entre los usuarios: {idEmisor} y {idReceptor}");

            // Hacer la solicitud para obtener los mensajes entre los usuarios
            var response = await _httpClient.GetAsync($"Interactuan/ObtenerMensajes/{idEmisor}/{idReceptor}");

            // Mensaje de depuración: Revisar si la respuesta fue exitosa
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Respuesta exitosa, procesando los mensajes...");

                var responseString = await response.Content.ReadAsStringAsync();

                // Mensaje de depuración: Mostrar el contenido de la respuesta
                MessageBox.Show($"Contenido de la respuesta: {responseString}");

                var mensajes = JsonConvert.DeserializeObject<List<Interactuan>>(responseString);

                // Mensaje de depuración: Cantidad de mensajes recibidos
                MessageBox.Show($"Se recibieron {mensajes.Count} mensajes.");

                return mensajes;
            }
            else
            {
                // Mensaje de depuración: En caso de error en la respuesta HTTP
                MessageBox.Show($"Error al obtener mensajes. Código de estado: {response.StatusCode}");
                return new List<Interactuan>(); // Retornar una lista vacía si hubo un error
            }
        }
        catch (Exception ex)
        {
            // Mensaje de depuración: Captura del error
            MessageBox.Show($"Error al obtener los mensajes: {ex.Message}");
            return new List<Interactuan>();
        }
    }






    public override string ToString()
    {
        return $"Interaccion: {{ " +
               $"ID Emisor: {IDdeEmisor}, " +
               $"ID Receptor: {IDdeReceptor}, " +
               $"Tipo: {Tipo}, " +
               $"Estado: {Estado}, " +
               $"Contenido: {Contenido}, " +
               $"Fecha: {Fecha.ToString("yyyy-MM-dd HH:mm:ss")}, " +
               $"Notificacion: {Notificacion}, " +
               $"Seguido: {Seguido} }}";
    }
}

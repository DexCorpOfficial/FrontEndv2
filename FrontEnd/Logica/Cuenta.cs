using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace FrontEnd.Logica
{
    public class Cuenta
    {
        public string baseUrl = "https://localhost:44329/Cuenta";
        public int id { get; set; }
        public string genero { get; set; }
        public byte[] foto_Perfil { get; set; }
        public string biografia { get; set; }
        public bool activo { get; set; }
        public List<Instrumentos> Instrumentos { get; set; } = new List<Instrumentos>();
        public string nombre { get; set; }
        public DateTime fechNac { get; set; }

        [JsonProperty("contrasenia")] // Mapeo de JSON a propiedad
        public string contrasena { get; set; }

        public bool musico { get; set; }
        public bool privado { get; set; }

        public async Task<(int idUsuario, bool valido)> Login(string nombre, string contrasena)
        {
            var client = new RESTClient(baseUrl);

            // Obtener la lista de cuentas
            string response = await client.GetAsync();

            // Si la respuesta está vacía, retornar ID vacía y válido como falso
            if (string.IsNullOrWhiteSpace(response))
            {
                return (0, false);
            }

            // Intentar deserializar como lista de cuentas, con manejo de excepciones
            List<Cuenta> cuentas;
            try
            {
                cuentas = JsonConvert.DeserializeObject<List<Cuenta>>(response);
            }
            catch (JsonSerializationException)
            {
                return (0, false);
            }

            // Buscar la cuenta por nombre, verificar la contraseña y que esté activa
            var cuentaBuscada = cuentas.FirstOrDefault(c =>
                string.Equals(c.nombre, nombre, StringComparison.OrdinalIgnoreCase) &&
                c.contrasena == contrasena &&
                c.activo); // Verifica que la cuenta esté activa

            // Si se encontró una cuenta que coincide y está activa, retornar su ID
            if (cuentaBuscada != null)
            {
                return (cuentaBuscada.id, true); // Retornar ID y válido
            }

            // Retornar vacío y no válido si no se encuentra una cuenta activa que coincida
            return (0, false);
        }


        public async Task<int> Registro(string nombre, string contrasena, byte[] foto_Perfil, bool musico, string genero, DateTime fechaNac)
        {
            var clientPost = new RESTClient($"{baseUrl}/create");

            // Crear el objeto que representa los datos a enviar
            var data = new
            {
                Nombre = nombre,
                Contrasenia = contrasena,
                foto_perfil = foto_Perfil,
                Musico = musico,
                genero = genero,
                fecha_nac = fechaNac,
                Privado = false, // Puedes ajustar esto según tus requisitos
            };

            // Serializar el objeto a JSON
            string jsonData = JsonConvert.SerializeObject(data);

            // Realizar la solicitud POST
            string postResponse = await clientPost.PostAsync(jsonData);

            // Si la respuesta no está vacía, intentamos deserializar
            if (!string.IsNullOrWhiteSpace(postResponse))
            {
                // Deserializar la respuesta para obtener el objeto creado
                var cuentaCreada = JsonConvert.DeserializeObject<Cuenta>(postResponse);
                return cuentaCreada.id; // Retornar la ID del usuario recién creado
            }

            return 0; // Retornar 0 si no se encuentra el usuario o si hay un error
        }






        public async Task<List<string>> ObtenerNombres()
        {
            var client = new RESTClient(baseUrl);

            // Realizar la solicitud GET
            string response = await client.GetAsync();

            // Si la respuesta está vacía, retorna una lista vacía
            if (string.IsNullOrWhiteSpace(response))
            {
                return new List<string>();
            }

            // Intentar deserializar como lista de cuentas, con manejo de excepciones
            List<Cuenta> cuentas;
            try
            {
                // Intentar deserializar como lista
                cuentas = JsonConvert.DeserializeObject<List<Cuenta>>(response);
            }
            catch (JsonSerializationException)
            {
                // Si falla, log y retorna lista vacía
                return new List<string>();
            }

            // Filtrar los nombres de las cuentas activas
            var nombresActivos = cuentas
                .Where(c => c.activo)
                .Select(c => c.nombre)
                .ToList();

            return nombresActivos;
        }

        public async Task<Cuenta> ObtenerUsuarioPorId(int idUsuario)
        {
            string url = $"{baseUrl}/{idUsuario}"; // Asegúrate de que esta URL sea correcta
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    var cuenta = JsonConvert.DeserializeObject<Cuenta>(jsonResponse);
                    return cuenta; // Retornar la cuenta deserializada
                }
                else
                {
                    throw new Exception("No se pudo obtener la información del usuario.");
                }
            }
        }

        public async Task eliminarCuenta(int id)
        {
            var client = new RESTClient($"{baseUrl}/{id}");
                string response = await client.DeleteAsync();
        }

        public async Task<List<(int id, string nombre, byte[] fotoPerfil)>> BuscarUsuarios(string nombreParcial)
        {
            var client = new RESTClient(baseUrl);
            string response = await client.GetAsync();

            if (string.IsNullOrWhiteSpace(response))
            {
                return new List<(int, string, byte[])>();
            }

            List<Cuenta> cuentas;
            try
            {
                cuentas = JsonConvert.DeserializeObject<List<Cuenta>>(response);
            }
            catch (JsonSerializationException)
            {
                return new List<(int, string, byte[])>();
            }

            var usuariosFiltrados = cuentas
                .Where(c => c.activo && c.nombre.ToLower().Contains(nombreParcial.ToLower()))
                .Select(c => (c.id, c.nombre, c.foto_Perfil))
                .ToList();

            return usuariosFiltrados;
        }

        public async Task CambiarPrivacidad(int idUsuario, bool nuevaPrivacidad)
        {
                var clientPut = new RESTClient($"{baseUrl}/actualizar_privacidad/{idUsuario}");

                // Serializar el valor booleano directamente, no un objeto
                string jsonData = JsonConvert.SerializeObject(nuevaPrivacidad); // Enviar solo el valor booleano

                // Realizar la solicitud PUT
                string response = await clientPut.PutAsync(jsonData);

                // Verificar si la actualización fue exitosa
                if (string.IsNullOrWhiteSpace(response))
                {
                    throw new Exception("Error al actualizar la privacidad. Respuesta vacía o nula.");
                }
        }

        public async Task<bool> ObtenerPrivacidad(int idUsuario)
        {
            var clientGet = new RESTClient($"{baseUrl}/{idUsuario}"); // Cambia la URL según tu API
            var cuentaJson = await clientGet.GetAsync();

            if (string.IsNullOrWhiteSpace(cuentaJson))
            {
                throw new Exception("Error al obtener la cuenta.");
            }

            // Deserializa la respuesta para obtener el estado de 'Privado'
            var cuenta = JsonConvert.DeserializeObject<Cuenta>(cuentaJson);

            return cuenta.privado;  // Devuelve el valor de 'Privado' de la cuenta
        }


        public async Task<bool> CambiarContrasenia(int idUsuario, string contrasenaAnterior, string contrasenaNueva)
        {
            var client = new RESTClient($"{baseUrl}/CambiarContrasenia/{idUsuario}");

            // Crear el objeto con las contraseñas
            var data = new
            {
                ContraseniaAnterior = contrasenaAnterior,
                ContraseniaNueva = contrasenaNueva
            };

            // Serializar el objeto a JSON
            string jsonData = JsonConvert.SerializeObject(data);

            // Realizar la solicitud PUT
            string response = await client.PutAsync(jsonData);

            // Verificar si el cambio fue exitoso (NoContent)
            return response == null;
        }

        public void comentar(int id, string nombre, byte[] foto_Perfil)
        {
        }
        public void mostrarPerfil(int id, string nombre)
        {
        }
        public async Task ActualizarPerfil(int idUsuario, string nuevoNombre, string nuevaBiografia, byte[] fotoPerfilBytes, string contrasena, string genero)
        {
                // Depuración: Mostrar los datos antes de enviar
                Console.WriteLine($"Actualizando perfil del usuario con ID: {idUsuario}");
                Console.WriteLine($"Nuevo nombre: {nuevoNombre}");
                Console.WriteLine($"Nueva biografía: {nuevaBiografia}");
                Console.WriteLine($"Foto de perfil: {fotoPerfilBytes?.Length} bytes");
                Console.WriteLine($"Contraseña: {contrasena}");
                Console.WriteLine($"Genero: {genero}");

                var client = new RESTClient($"{baseUrl}/edit/{idUsuario}");

                // Crear el objeto con los datos a actualizar
                var data = new
                {
                    ID = idUsuario, 
                    nombre = nuevoNombre,
                    biografia = nuevaBiografia,
                    foto_perfil = fotoPerfilBytes,
                    Contrasenia = contrasena,  // Asegúrate de enviar la contraseña
                    genero = genero  // Asegúrate de enviar el género
                };


                // Serializar el objeto a JSON
                string jsonData = JsonConvert.SerializeObject(data);

                // Depuración: Mostrar los datos serializados
                Console.WriteLine($"Datos serializados: {jsonData}");

                // Realizar la solicitud PUT
                string response = await client.PutAsync(jsonData);

                // Depuración: Verificar la respuesta
                Console.WriteLine($"Respuesta del servidor: {response}");
        }



        public void seguirCuenta(int id, string nombre)
        {
        }
        public void dejarDeSeguir(int id, string nombre)
        {
        }
        public void unirseEvento(int id, string nombre, byte[] foto_Perfil)
        {
        }
        public void salirEvento(int id, string nombre)
        {
        }
        public void enviarMensaje(int id, int nombre, byte[] foto_Perfil)
        {
        }
        public void notificar()
        {
        }
        public void BloquearCuenta(int id, string nombre)
        {
        }
        public void reportarCuenta(int id, string nombre)
        {
        }
        public void unirseBanda(int id, string nombre)
        {
        }
        public void salirBanda(int id, string nombre)
        {
        }
        public override string ToString()
        {
            return $"ID: {id}, Nombre: {nombre}, Genero: {genero}, Foto de perfil: {foto_Perfil}" +
                $", Biografia: {biografia}, Es una cuenta activa: {activo}, Fecha de Nacimiento: {fechNac}, Contraseña: {contrasena}" +
                $"Es musico: {musico}, Instrumentos: {Instrumentos}, Es Privado: {privado}";
        }
    }
}

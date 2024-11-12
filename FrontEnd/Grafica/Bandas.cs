using FrontEnd.Logica;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FrontEnd.Grafica
{
    public partial class Bandas : Form
    {
        public int IdUsuario { get; set; }
        public Bandas(int idUsuario)
        {
            IdUsuario = idUsuario;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ControlBox = false;
            this.WindowState = FormWindowState.Normal;
            InitializeComponent();
            // Configurar el DataGridView al inicio
            ConfigurarDataGridView();
            // Cargar las bandas al abrir el formulario
            CargarBandasEnDataGridView();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {

        }

        private void btn_crearBanda_Click(object sender, EventArgs e)
        {
            crearBanda crearBandaForm = new crearBanda(IdUsuario);
            this.Hide();
            crearBandaForm.ShowDialog();
            this.Close();
        }
        private void ConfigurarDataGridView()
        {
            // Limpia cualquier columna existente
            datagrid_Busqueda.Columns.Clear();
            datagrid_Busqueda.DataSource = null; // Asegúrate de eliminar cualquier fuente de datos

            // Columna para el nombre
            DataGridViewTextBoxColumn nombreColumn = new DataGridViewTextBoxColumn();
            nombreColumn.Width = 80;
            nombreColumn.DefaultCellStyle.Font = new Font("Arial", 12);
            nombreColumn.DefaultCellStyle.BackColor = Color.White;  // Fondo blanco
            nombreColumn.DefaultCellStyle.ForeColor = Color.Black;  // Color del texto negro
            datagrid_Busqueda.Columns.Add(nombreColumn);

            // Columna para el ID (oculta)
            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.Name = "ID";
            idColumn.Visible = false; // Hacer la columna ID oculta
            datagrid_Busqueda.Columns.Add(idColumn);

            // Configuración adicional para el DataGridView
            datagrid_Busqueda.RowTemplate.Height = 40; // Altura de las filas
            datagrid_Busqueda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Asegurarse de que todas las celdas tengan el mismo fondo y color de texto
            foreach (DataGridViewColumn column in datagrid_Busqueda.Columns)
            {
                column.DefaultCellStyle.BackColor = Color.White; // Fondo blanco
                column.DefaultCellStyle.ForeColor = Color.Black; // Texto negro
            }
        }

        private async Task<List<Banda>> ObtenerBandasDesdeAPI()
        {
            using (HttpClient client = new HttpClient())
            {
                string url = "https://localhost:44330/api/Banda";

                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonResponse = await response.Content.ReadAsStringAsync();
                        List<Banda> bandas = JsonConvert.DeserializeObject<List<Banda>>(jsonResponse);
                        return bandas ?? new List<Banda>();
                    }
                    else
                    {
                        // Imprimir el mensaje de error recibido de la API
                        string errorMessage = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Error al cargar bandas: {response.ReasonPhrase} - {errorMessage}");
                        return new List<Banda>();
                    }
                }
                catch (HttpRequestException ex)
                {
                    MessageBox.Show("Error de red: " + ex.Message);
                    return new List<Banda>();
                }
            }
        }
        private async void CargarBandasEnDataGridView()
        {
            // Obtener las bandas desde la API
            List<Banda> bandas = await ObtenerBandasDesdeAPI();

            // Limpiar cualquier dato anterior en el DataGridView
            datagrid_Busqueda.Rows.Clear();

            // Iterar sobre la lista de bandas y agregar una fila para cada banda
            foreach (var banda in bandas)
            {
                // Si no hay una imagen en la banda, podemos dejar esta celda vacía o agregar una imagen predeterminada
                datagrid_Busqueda.Rows.Add(
                    banda.nombre,   // Nombre de la banda
                    banda.id        // ID de la banda (oculto)
                );
            }
        }


        private async void datagrid_Busqueda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Asegúrate de que se haya hecho clic en una fila válida
            if (e.RowIndex >= 0)
            {
                // Obtener el ID de la banda desde la columna oculta
                int idBanda = (int)datagrid_Busqueda.Rows[e.RowIndex].Cells["ID"].Value;
                int idUsuario = 1;  // ID del usuario actual (debes obtenerlo desde el contexto de usuario)

                // Crear la instancia de Forman para registrarse en la banda
                Forman forman = new Forman
                {
                    IDdeCuenta = idUsuario,
                    IDdeBanda = idBanda,
                    Admin = false // El valor default es 0 (no administrador)
                };

                // Llamar al método para registrar la interacción (unirse a la banda)
                await UnirseABanda(forman);
            }
        }

        private async Task UnirseABanda(Forman forman)
        {
            using (HttpClient client = new HttpClient())
            {
                string url = "https://localhost:44330/api/Forman/Create";  // Esta es la ruta correcta según la nueva configuración.


                try
                {
                    // Serializar el objeto Forman a JSON
                    string jsonContent = JsonConvert.SerializeObject(forman);
                    var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                    // Realizar la solicitud POST a la API para unirse a la banda
                    HttpResponseMessage response = await client.PostAsync(url, content);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Te has unido a la banda exitosamente.");
                    }
                    else
                    {
                        
                        MessageBox.Show($"Error al unirse a la banda");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Feed feedForm = new Feed(IdUsuario);
            this.Hide();
            feedForm.ShowDialog();
            this.Close();
        }

    }
}

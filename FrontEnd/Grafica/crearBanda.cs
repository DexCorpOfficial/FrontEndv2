using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEnd.Grafica
{
    public partial class crearBanda : Form
    {
        public int IdUsuario { get; set; }
        public crearBanda(int idUsuario)
        {
            InitializeComponent();
            IdUsuario = idUsuario; // Asigna el ID del usuario
        }

        private void btn_SubirFoto_Click(object sender, EventArgs e)
        {
            pcb_VistaPrevia.Visible = true; // Asegúrate de que el PictureBox es visible
            opfdperfil.InitialDirectory = "c:\\"; // Establece el directorio inicial
            opfdperfil.Filter = "Image files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png"; // Filtro de archivos
            opfdperfil.FilterIndex = 1; // Filtro predeterminado
            opfdperfil.RestoreDirectory = true; // Restaura el directorio anterior

            if (opfdperfil.ShowDialog() == DialogResult.OK)
            {
                string filePath = opfdperfil.FileName; // Obtiene la ruta del archivo seleccionado

                using (var ms = new MemoryStream(File.ReadAllBytes(filePath)))
                {
                    var imagen = Image.FromStream(ms);
                    pcb_VistaPrevia.Image = imagen; // Asigna la imagen al PictureBox
                    pcb_VistaPrevia.SizeMode = PictureBoxSizeMode.Zoom; // Ajusta el modo de visualización
                }
            }
        }

        private byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private async void btn_crearBanda_Click(object sender, EventArgs e)
        {
            // Limpiar mensaje de error
            lbl_MensajeError.Text = string.Empty;
            lbl_MensajeError.ForeColor = System.Drawing.Color.Red;

            // Obtener los datos de los campos
            string nombreBanda = txt_nombreBanda.Text.Trim();
            string descripcionBanda = txt_descripcion.Text.Trim();
            byte[] fotoBanda = null;

            if (opfdperfil.FileName != null && opfdperfil.FileName != string.Empty)
            {
                using (var fs = new FileStream(opfdperfil.FileName, FileMode.Open, FileAccess.Read))
                {
                    using (var ms = new MemoryStream())
                    {
                        fs.CopyTo(ms);
                        fotoBanda = ms.ToArray();
                    }
                }
            }

            if (nombreBanda.Length < 4 || nombreBanda.Length > 50)
            {
                lbl_MensajeError.Text = "El nombre de la banda debe tener entre 4 y 50 caracteres.";
                return;
            }

            if (descripcionBanda.Length < 1 || descripcionBanda.Length > 150)
            {
                lbl_MensajeError.Text = "La biografía debe tener entre 1 y 150 caracteres.";
                return;
            }

            // Crear el objeto Banda a enviar
            var banda = new
            {
                IDdeMusico = this.IdUsuario, // ID del usuario que crea la banda
                nombre = nombreBanda,
                biografia = descripcionBanda,
                foto_banda = fotoBanda // Puede ser null, la API asignará la foto por defecto
            };

            var jsonContent = new StringContent(JsonConvert.SerializeObject(banda), Encoding.UTF8, "application/json");

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44330/api/Banda/");

                try
                {
                    var response = await client.PostAsync("", jsonContent); // Esta línea ya es suficiente


                    if (response.IsSuccessStatusCode)
                    {
                        lbl_MensajeError.ForeColor = System.Drawing.Color.Green;
                        lbl_MensajeError.Text = "Banda creada exitosamente.";
                    }
                    else
                    {
                        lbl_MensajeError.Text = "Error al crear la banda: " + response.ReasonPhrase;
                    }
                }
                catch (Exception ex)
                {
                    lbl_MensajeError.Text = "Error de conexión: " + ex.Message;
                }
            }
        }
    }
}

using FrontEnd.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEnd.Grafica
{
    public partial class Editar_Perfil : Form
    {
        public int IdUsuario { get; set; }
        public Editar_Perfil(int idUsuario)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.WindowState = FormWindowState.Normal;
            IdUsuario = idUsuario;
            string idiomaGuardado = Properties.Settings.Default.Language;
            if (!string.IsNullOrEmpty(idiomaGuardado))
            {
                ApplyLanguage(idiomaGuardado.ToLower());
            }
            else
            {
                ApplyLanguage("español");
            }
            string ModalidadApp = Properties.Settings.Default.Modalidad;
            AplicarModalidad(ModalidadApp);
        }

        private async void OnEditarPerfilLoad(object sender, EventArgs e)
        {
            string language = Properties.Settings.Default.Language;
            var translations = LanguageManager.GetTranslations(language.ToLower());
            Cuenta cuenta = new Cuenta();
            var usuario = await cuenta.ObtenerUsuarioPorId(IdUsuario);
            if (usuario != null)
            {
                txt_NombreUsuarioEditar.AppendText(usuario.nombre);
                if (usuario.foto_Perfil != null)
                {
                    using (var ms = new MemoryStream(usuario.foto_Perfil))
                    {
                        pcb_fotoPerfilGrande.Image = Image.FromStream(ms); // Asignar imagen
                        pcb_fotoPerfilGrande.SizeMode = PictureBoxSizeMode.Zoom; // Ajusta el modo de visualización
                    }
                }
            }
            if (usuario.biografia == null)
            {
                txt_DescripcionEditar.AppendText(translations["txt_DescripcionVacio"]);
            }
            else
            {
                txt_DescripcionEditar.AppendText(usuario.biografia);
            }
        }

        public void ApplyLanguage(string language)
        {
            var translations = LanguageManager.GetTranslations(language.ToLower());
            btn_confirmarEditar.Text = translations["btn_confirmarEditar"];
            btn_CancelarEditar.Text = translations["btn_CancelarEditar"];
        }

        private void AplicarModalidad(string modalidad)
        {
            if (modalidad == "Modo_Oscuro")
            {
                this.BackColor = Color.DarkSlateBlue;
                //BackColor
                btn_confirmarEditar.BackColor = Color.Black;
                btn_CancelarEditar.BackColor = Color.Black;
                pcb_logo.Image = Properties.Resources.BandApp_Claro;
                //ForeColor
                btn_confirmarEditar.ForeColor = Color.White;
                btn_CancelarEditar.ForeColor = Color.White;
            }
            else
            {
                this.BackColor = Color.FromArgb(171, 157, 250);
                //BackColor
                btn_confirmarEditar.BackColor = Color.White;
                btn_CancelarEditar.BackColor = Color.White;
                pcb_logo.Image = Properties.Resources.BandApp_Negro;
                //ForeColor
                btn_confirmarEditar.ForeColor = Color.Black;
                btn_CancelarEditar.ForeColor = Color.Black;
            }
        }

        private async void btn_confirmarEditar_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los campos de texto
            string nuevoNombre = txt_NombreUsuarioEditar.Text;
            string nuevaBiografia = txt_DescripcionEditar.Text;

            // Instanciar la clase Cuenta y llamar al método ActualizarPerfil
            Cuenta cuenta = new Cuenta();
            var usuario = await cuenta.ObtenerUsuarioPorId(IdUsuario);
            // Variable para la foto de perfil (null si no se seleccionó ninguna imagen)
            byte[] fotoPerfilBytes = null;

            // Si se seleccionó una nueva foto de perfil, convertirla en bytes
            if (!string.IsNullOrEmpty(opfdPerfil.FileName))
            {
                // Verificar si el archivo realmente existe antes de intentar cargarlo
                if (File.Exists(opfdPerfil.FileName))
                {
                    fotoPerfilBytes = ImageToByteArray(Image.FromFile(opfdPerfil.FileName));
                }
                else
                {
                    // Si el archivo no se encuentra, no mostrar un error ya que la foto es opcional
                    fotoPerfilBytes = null;
                }
            }
            else
            {
                // Si no se seleccionó una nueva foto, mantener la foto actual del usuario
                if (usuario != null && usuario.foto_Perfil != null)
                {
                    fotoPerfilBytes = usuario.foto_Perfil; // Mantener la foto actual
                }
                else
                {
                    // Si no hay foto actual, se asigna la foto predeterminada
                    fotoPerfilBytes = ImageToByteArray(Properties.Resources.Foto_de_Perfil_Por_Defecto); // Usar la foto predeterminada
                }
            }

            // Llamar al método ActualizarPerfil, pasando los datos
            await cuenta.ActualizarPerfil(IdUsuario, nuevoNombre, nuevaBiografia, fotoPerfilBytes, usuario.contrasena, usuario.genero);
                // Si la actualización fue exitosa, se abre el formulario de perfil
                Perfil PerfilForm = new Perfil(IdUsuario, 0);
                this.Hide();
                PerfilForm.ShowDialog();
                this.Close();
        }




        private void btn_CancelarEditar_Click(object sender, EventArgs e)
        {
            Perfil PerfilForm = new Perfil(IdUsuario, 0);
            this.Hide();
            PerfilForm.ShowDialog();
            this.Close();
        }

        private byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Png); // Puedes cambiar el formato si lo prefieres
                return ms.ToArray();
            }
        }

        private void pcb_busqueda_Click(object sender, EventArgs e)
        {
            opfdPerfil.InitialDirectory = "c:\\"; // Establece el directorio inicial
            opfdPerfil.Filter = "Image files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png"; // Filtro de archivos
            opfdPerfil.FilterIndex = 1; // Filtro predeterminado
            opfdPerfil.RestoreDirectory = true; // Restaura el directorio anterior

            // Mostrar diálogo para seleccionar archivo
            if (opfdPerfil.ShowDialog() == DialogResult.OK)
            {
                string filePath = opfdPerfil.FileName; // Obtiene la ruta del archivo seleccionado

                using (var ms = new MemoryStream(File.ReadAllBytes(filePath)))
                {
                    var imagen = Image.FromStream(ms);
                    pcb_fotoPerfilGrande.Image = imagen; // Asigna la imagen al PictureBox
                    pcb_fotoPerfilGrande.SizeMode = PictureBoxSizeMode.Zoom; // Ajusta el modo de visualización

                    byte[] fotoPerfil = ImageToByteArray(imagen); // Convertir la imagen a bytes
                }
            }
        }
    }
}

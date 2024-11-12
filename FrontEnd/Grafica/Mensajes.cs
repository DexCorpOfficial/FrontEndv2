using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEnd.Logica
{
    public partial class Mensajes : Form
    {
        public int IdUsuario { get; set; }
        public int IdUsuarioAjeno { get; set; }

        public Mensajes(int idUsuario, int idUsuarioAjeno)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.WindowState = FormWindowState.Normal;
            IdUsuario = idUsuario;
            IdUsuarioAjeno = idUsuarioAjeno;
            string idiomaGuardado = Properties.Settings.Default.Language;
            ApplyLanguage(idiomaGuardado ?? "español");
            AplicarModalidad(Properties.Settings.Default.Modalidad);
        }

        private async void OnMensajesLoad(object sender, EventArgs e)
        {
            await LoadUserProfile(IdUsuario);
            ConfigurarDataGridView();
            await CargarMensajes();
        }


        private async Task LoadUserProfile(int idUsuario)
        {
            Cuenta cuenta = new Cuenta();
            var usuario = await cuenta.ObtenerUsuarioPorId(idUsuario);

            if (usuario != null)
            {
                lbl_nombrePerfil.Text = usuario.nombre;
                if (usuario.foto_Perfil != null)
                {
                    using (var ms = new MemoryStream(usuario.foto_Perfil))
                    {
                        pcb_imagenperfil.Image = Image.FromStream(ms); // Asignar imagen
                        pcb_imagenperfil.SizeMode = PictureBoxSizeMode.Zoom; // Ajusta el modo de visualización
                    }
                }
            }
        }


        public void ApplyLanguage(string language)
        {
            var translations = LanguageManager.GetTranslations(language.ToLower());
            btn_VolverFeed.Text = translations["btn_VolverFeed"];
            btn_EnviarMensaje.Text = translations["btn_EnviarMensaje"];
        }

        private void AplicarModalidad(string modalidad)
        {
            if (modalidad == "Modo_Oscuro")
            {
                this.BackColor = Color.DarkSlateBlue;
                //BackColor
                pcb_logo.Image = Properties.Resources.BandApp_Claro;
                btn_VolverFeed.BackColor = Color.Black;
                btn_EnviarMensaje.BackColor = Color.Black;
                txt_Mensaje.BackColor = Color.Black;
                datagrid_Mensajes.AlternatingRowsDefaultCellStyle.BackColor = Color.Black;
                datagrid_Mensajes.DefaultCellStyle.BackColor = Color.Black;
                datagrid_Mensajes.BackColor = Color.Black;
                datagrid_Mensajes.BackgroundColor = Color.FromArgb(64, 64, 64);
                //ForeColor
                btn_VolverFeed.ForeColor = Color.White;
                txt_Mensaje.ForeColor = Color.White;
                lbl_nombrePerfil.ForeColor = Color.White;
                btn_EnviarMensaje.ForeColor = Color.White;
                datagrid_Mensajes.ForeColor = Color.White;
                datagrid_Mensajes.AlternatingRowsDefaultCellStyle.ForeColor = Color.White;
                datagrid_Mensajes.DefaultCellStyle.ForeColor = Color.White;
            }
            else
            {
                this.BackColor = Color.FromArgb(171, 157, 250);
                //BackColor
                pcb_logo.Image = Properties.Resources.BandApp_Negro;
                btn_VolverFeed.BackColor = Color.White;
                btn_EnviarMensaje.BackColor = Color.White;
                txt_Mensaje.BackColor = Color.White;
                datagrid_Mensajes.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
                datagrid_Mensajes.DefaultCellStyle.BackColor = Color.White;
                datagrid_Mensajes.BackColor = Color.White;
                datagrid_Mensajes.BackgroundColor = Color.FromArgb(64, 64, 64);
                //ForeColor
                datagrid_Mensajes.ForeColor = Color.Black;
                datagrid_Mensajes.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
                datagrid_Mensajes.DefaultCellStyle.ForeColor = Color.Black;
                btn_EnviarMensaje.ForeColor = Color.Black;
                txt_Mensaje.ForeColor = Color.Black;
                btn_VolverFeed.ForeColor = Color.Black;
                lbl_nombrePerfil.ForeColor = Color.Black;
            }
        }

        private void ConfigurarDataGridView()
        {
            // Limpiar cualquier columna existente
            datagrid_Mensajes.Columns.Clear();
            datagrid_Mensajes.DataSource = null; // Asegúrate de eliminar cualquier fuente de datos

            // Columna para la imagen (Foto de perfil)
            DataGridViewImageColumn imagenColumn = new DataGridViewImageColumn();
            imagenColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            imagenColumn.Width = 50; // Ajusta el tamaño de la imagen
            imagenColumn.HeaderText = "Foto";
            datagrid_Mensajes.Columns.Add(imagenColumn);

            // Columna para el contenido del mensaje
            DataGridViewTextBoxColumn contenidoColumn = new DataGridViewTextBoxColumn();
            contenidoColumn.Width = 250; // Ajusta el tamaño del contenido
            contenidoColumn.DefaultCellStyle.Font = new Font("Arial", 12);
            contenidoColumn.HeaderText = "Mensaje";
            datagrid_Mensajes.Columns.Add(contenidoColumn);

            // Columna para la fecha del mensaje
            DataGridViewTextBoxColumn fechaColumn = new DataGridViewTextBoxColumn();
            fechaColumn.Width = 100;
            fechaColumn.DefaultCellStyle.Font = new Font("Arial", 10);
            fechaColumn.HeaderText = "Fecha";
            datagrid_Mensajes.Columns.Add(fechaColumn);

            // Configuración adicional para el DataGridView
            datagrid_Mensajes.RowTemplate.Height = 50; // Altura de las filas
            datagrid_Mensajes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }



        private async Task CargarMensajes()
        {
            // Mensaje de depuración: Indicar que se empieza a cargar los mensajes
            MessageBox.Show("Cargando mensajes...");

            Cuenta cuenta = new Cuenta();
            var interactuan = new Interactuan();

            // Obtener los usuarios (usuario logueado y perfil ajeno)
            var usuario = await cuenta.ObtenerUsuarioPorId(IdUsuario);
            var usuarioAjeno = await cuenta.ObtenerUsuarioPorId(IdUsuarioAjeno);

            // Mensaje de depuración: Verificar si los usuarios fueron encontrados correctamente
            if (usuario != null)
            {
                MessageBox.Show($"Usuario encontrado: {usuario.nombre}");
            }
            else
            {
                MessageBox.Show("No se encontró al usuario logueado.");
            }

            if (usuarioAjeno != null)
            {
                MessageBox.Show($"Usuario ajeno encontrado: {usuarioAjeno.nombre}");
            }
            else
            {
                MessageBox.Show("No se encontró al usuario ajeno.");
            }

            // Obtener los mensajes entre los dos usuarios
            var mensajes = await interactuan.ObtenerMensajes(IdUsuario, IdUsuarioAjeno);

            // Mensaje de depuración: Verificar la cantidad de mensajes obtenidos
            MessageBox.Show($"Cantidad de mensajes recibidos: {mensajes.Count}");

            // Convertir la foto de perfil del usuario logueado (byte array a imagen)
            Image fotoPerfil = null;
            if (usuario.foto_Perfil != null && usuario.foto_Perfil.Length > 0)
            {
                using (var ms = new System.IO.MemoryStream(usuario.foto_Perfil))
                {
                    fotoPerfil = Image.FromStream(ms);
                }
                // Mensaje de depuración: Confirmar que se ha cargado la foto de perfil
                MessageBox.Show("Foto de perfil del usuario cargada.");
            }
            else
            {
                // Mensaje de depuración: Indicar que no hay foto de perfil para el usuario
                MessageBox.Show("El usuario no tiene foto de perfil.");
            }

            // Convertir la foto de perfil del perfil ajeno (byte array a imagen)
            Image fotoPerfilAjeno = null;
            if (usuarioAjeno.foto_Perfil != null && usuarioAjeno.foto_Perfil.Length > 0)
            {
                using (var ms = new System.IO.MemoryStream(usuarioAjeno.foto_Perfil))
                {
                    fotoPerfilAjeno = Image.FromStream(ms);
                }
                // Mensaje de depuración: Confirmar que se ha cargado la foto de perfil ajeno
                MessageBox.Show("Foto de perfil del usuario ajeno cargada.");
            }
            else
            {
                // Mensaje de depuración: Indicar que no hay foto de perfil para el usuario ajeno
                MessageBox.Show("El usuario ajeno no tiene foto de perfil.");
            }

            // Limpiar cualquier mensaje previo en el DataGridView
            datagrid_Mensajes.Rows.Clear();

            // Mensaje de depuración: Verificar que se ha limpiado el DataGridView
            MessageBox.Show("DataGridView limpiado.");

            // Recorrer los mensajes y agregar las filas al DataGridView
            foreach (var mensaje in mensajes)
            {
                // Mensaje de depuración: Verificar el emisor y el contenido del mensaje
                MessageBox.Show($"Procesando mensaje. Emisor: {mensaje.IDdeEmisor}, Contenido: {mensaje.Contenido}");

                // Filtrar y mostrar los mensajes según el emisor
                if (mensaje.IDdeEmisor == IdUsuario)
                {
                    // Mensajes enviados por el usuario logueado (perfil propio)
                    datagrid_Mensajes.Rows.Add(fotoPerfil, mensaje.Contenido, mensaje.Fecha.ToString("dd/MM/yyyy HH:mm:ss"));
                }
                else if (mensaje.IDdeEmisor == IdUsuarioAjeno)
                {
                    // Mensajes enviados por el perfil ajeno (otro usuario)
                    datagrid_Mensajes.Rows.Add(fotoPerfilAjeno, mensaje.Contenido, mensaje.Fecha.ToString("dd/MM/yyyy HH:mm:ss"));
                }
            }

            // Mensaje de depuración: Indicar que se han agregado todos los mensajes al DataGridView
            MessageBox.Show("Mensajes cargados en el DataGridView.");
        }






        private void btn_VolverFeed_Click(object sender, System.EventArgs e)
        {
            Feed feedForm = new Feed(IdUsuario);
            this.Hide();
            feedForm.ShowDialog();
            this.Close();
        }

        private async void btn_EnviarMensaje_Click(object sender, EventArgs e)
        {
            // Obtener el texto del mensaje
            string mensaje = txt_Mensaje.Text;

            // Crear la interacción de tipo "Mensaje"
            var interactuan = new Interactuan();
            await interactuan.EnviarMensaje(IdUsuario, IdUsuarioAjeno, mensaje);

            // Limpiar el cuadro de texto después de enviar el mensaje
            txt_Mensaje.Clear();

            // Recargar los mensajes (esto puede ser útil para que aparezca el nuevo mensaje inmediatamente)
            await CargarMensajes();
        }


    }
}

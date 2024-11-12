using System;
using System.Drawing;
using System.Windows.Forms;

namespace FrontEnd.Grafica
{
    public partial class BusquedaUsuarios : Form
    {
        public int IdUsuario { get; set; }
        public BusquedaUsuarios(int idUsuario)
        {
            InitializeComponent();
            IdUsuario = idUsuario;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ControlBox = false;
            this.WindowState = FormWindowState.Normal;
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
            ConfigurarDataGridView();
        }

        private void ApplyLanguage(string language) // Se configura el lenguaje de los botones y textos
        {
            string ModalidadApp = Properties.Settings.Default.Modalidad;
            var translations = LanguageManager.GetTranslations(language.ToLower());
            this.Text = translations["BusquedaUsuariosForm"];
            btb_salir.Text = translations["btb_salir"];
            btn_buscar.Text = translations["btn_buscar"];
        }

        private void AplicarModalidad(string modalidad)
        {
            if (modalidad == "Modo_Oscuro")
            {
                this.BackColor = Color.DarkSlateBlue;
                //ForeColor
                btn_buscar.ForeColor = Color.White;
                btb_salir.ForeColor = Color.White;
                datagrid_Busqueda.ForeColor = Color.White;
                datagrid_Busqueda.AlternatingRowsDefaultCellStyle.ForeColor = Color.White;
                datagrid_Busqueda.DefaultCellStyle.ForeColor = Color.White;
                txt_usuario.ForeColor = Color.White;
                //BackColor
                datagrid_Busqueda.AlternatingRowsDefaultCellStyle.BackColor = Color.Black;
                datagrid_Busqueda.DefaultCellStyle.BackColor = Color.Black;
                datagrid_Busqueda.BackColor = Color.Black;
                datagrid_Busqueda.BackgroundColor = Color.DarkSlateBlue;
                btb_salir.BackColor = Color.Black;
                btn_buscar.BackColor = Color.Black;
                txt_usuario.BackColor = Color.Black;
            }
            else
            {
                this.BackColor = Color.FromArgb(171, 157, 250);
                //ForeColor
                btn_buscar.ForeColor = Color.Black;
                btb_salir.ForeColor = Color.Black;
                datagrid_Busqueda.ForeColor = Color.Black;
                datagrid_Busqueda.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
                datagrid_Busqueda.DefaultCellStyle.ForeColor = Color.Black;
                txt_usuario.ForeColor = Color.Black;
                //BackColor
                datagrid_Busqueda.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
                datagrid_Busqueda.DefaultCellStyle.BackColor = Color.White;
                datagrid_Busqueda.BackColor = Color.White;
                datagrid_Busqueda.BackgroundColor = Color.FromArgb(171, 157, 250);
                btn_buscar.BackColor = Color.White;
                btb_salir.BackColor = Color.White;
                txt_usuario.BackColor = Color.White;
            }
        }

        private void btb_salir_Click(object sender, EventArgs e)
        {
            Feed FeedForm = new Feed(IdUsuario);
            this.Hide();
            FeedForm.ShowDialog();
            this.Close();
        }

        private void txt_usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btn_buscar_Click(object sender, EventArgs e)
        {
            string nombreParcial = txt_usuario.Text.Trim();

            // Llama al método BuscarUsuarios de la clase Cuenta
            var cuenta = new FrontEnd.Logica.Cuenta();
            var usuarios = await cuenta.BuscarUsuarios(nombreParcial);

            // Limpia las filas del DataGridView
            datagrid_Busqueda.Rows.Clear();

            // Agrega cada usuario al DataGridView
            foreach (var usuario in usuarios)
            {
                // Convierte la foto de perfil (byte array) en imagen
                Image fotoPerfil = null;
                if (usuario.fotoPerfil != null && usuario.fotoPerfil.Length > 0)
                {
                    using (var ms = new System.IO.MemoryStream(usuario.fotoPerfil))
                    {
                        fotoPerfil = Image.FromStream(ms);
                    }
                }

                // Añade una fila con la imagen, el nombre y la ID (aunque la columna ID está oculta)
                datagrid_Busqueda.Rows.Add(fotoPerfil, usuario.nombre, usuario.id);
            }
        }



        private void ConfigurarDataGridView()
        {
            // Limpia cualquier columna existente
            datagrid_Busqueda.Columns.Clear();
            datagrid_Busqueda.DataSource = null; // Asegúrate de eliminar cualquier fuente de datos

            // Columna para la imagen
            DataGridViewImageColumn imagenColumn = new DataGridViewImageColumn();
            imagenColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            imagenColumn.Width = 20;
            datagrid_Busqueda.Columns.Add(imagenColumn);

            // Columna para el nombre
            DataGridViewTextBoxColumn nombreColumn = new DataGridViewTextBoxColumn();
            nombreColumn.Width = 80;
            nombreColumn.DefaultCellStyle.Font = new Font("Arial", 12);
            datagrid_Busqueda.Columns.Add(nombreColumn);

            // Columna para el ID (oculta)
            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.Name = "ID";
            idColumn.Visible = false; // Hacer la columna ID oculta
            datagrid_Busqueda.Columns.Add(idColumn);

            // Configuración adicional para el DataGridView
            datagrid_Busqueda.RowTemplate.Height = 40; // Altura de las filas
            datagrid_Busqueda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }



        private void datagrid_Busqueda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Asegura que se haya hecho clic en una fila válida
            {
                int idUsuarioAjeno = (int)datagrid_Busqueda.Rows[e.RowIndex].Cells["ID"].Value;
                if (idUsuarioAjeno != IdUsuario)
                {
                    Perfil PerfilForm = new Perfil(IdUsuario, idUsuarioAjeno);
                    this.Hide();
                    PerfilForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    Perfil PerfilForm = new Perfil(IdUsuario, 0);
                    this.Hide();
                    PerfilForm.ShowDialog();
                    this.Close();
                }
            }
        }
    }
}

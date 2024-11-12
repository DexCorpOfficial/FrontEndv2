using FrontEnd.Logica;
using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEnd.Grafica
{
    public partial class VerMensajeria : Form
    {
        public int IdUsuario { get; set; }
        public VerMensajeria(int idUsuario)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.WindowState = FormWindowState.Normal;
            IdUsuario = idUsuario;
            string idiomaGuardado = Properties.Settings.Default.Language;
            ApplyLanguage(idiomaGuardado ?? "español");
            AplicarModalidad(Properties.Settings.Default.Modalidad);
        }

        private async void OnVerMensajeriaLoad(object sender, EventArgs e)
        {
            await LoadUserProfile(IdUsuario);
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
        }

        private void AplicarModalidad(string modalidad)
        {
            if (modalidad == "Modo_Oscuro")
            {
                this.BackColor = Color.DarkSlateBlue;
                //BackColor
                pcb_logo.Image = Properties.Resources.BandApp_Claro;
                btn_VolverFeed.BackColor = Color.Black;
                //ForeColor
                btn_VolverFeed.ForeColor = Color.White;
                lbl_nombrePerfil.ForeColor = Color.White;
            }
            else
            {
                this.BackColor = Color.FromArgb(171, 157, 250);
                //BackColor
                pcb_logo.Image = Properties.Resources.BandApp_Negro;
                btn_VolverFeed.BackColor = Color.White;

                //ForeColor
                btn_VolverFeed.ForeColor = Color.Black;
                lbl_nombrePerfil.ForeColor = Color.Black;
            }
        }

        private void btn_VolverFeed_Click(object sender, EventArgs e)
        {
            Feed feedForm = new Feed(IdUsuario);
            this.Hide();
            feedForm.ShowDialog();
            this.Close();
        }
    }
}

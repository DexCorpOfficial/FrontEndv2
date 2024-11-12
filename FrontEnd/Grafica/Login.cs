using FrontEnd.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEnd
{
    public partial class Login : Form
    {
        private Timer TemporizadorError;
        private bool ImagenOriginal;
        public Login()
        {
            InitializeComponent();
            TemporizadorError = new Timer();
            TemporizadorError.Interval = 5000;
            TemporizadorError.Tick += TemporizadorError_Tick;
            this.MaximizeBox = false;// No permite al programa ser maximizado
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Cambia el borde del programa
            this.WindowState = FormWindowState.Normal;
            txt_contrasenia.UseSystemPasswordChar = true; // Cambia el texo contraseña a no visible
            string ModalidadApp = Properties.Settings.Default.Modalidad;
            AplicarModalidad(ModalidadApp);

            // Aqui se configurara el Idioma del programa para que el ComboBox funcione y ademas verifica si ya se guardo un lenguaje antes
            string idiomaGuardado = Properties.Settings.Default.Language;
            if (!string.IsNullOrEmpty(idiomaGuardado))
            {
                ApplyLanguage(idiomaGuardado.ToLower());
            }
            else
            {
                ApplyLanguage("español");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void btb_salir_Click(object sender, EventArgs e)
        {
            this.Close(); //Sale del programa
        }

        private void Pcb_contrasenia_MouseDown(object sender, MouseEventArgs e) 
        {
            pcb_contrasenia.Image = Properties.Resources.Ojo_cerrado; // Cambia la imagen a un ojo cerrado
            txt_contrasenia.UseSystemPasswordChar = false; // Cambia el texo contraseña a visible
        }

        private void Pcb_contrasenia_MouseUp(object sender, MouseEventArgs e)
        {
            pcb_contrasenia.Image = Properties.Resources.Ojo_abierto; // Cambia la imagen a un ojo abierto
            txt_contrasenia.UseSystemPasswordChar = true; // Cambia el texo contraseña a no visible
        }
        private void ApplyLanguage(string language) // Se configura el lenguaje de los botones y textos
        {
            var translations = LanguageManager.GetTranslations(language.ToLower());

            lbl_usuario.Text = translations["lbl_usuario"];
            lbl_contrasenia.Text = translations["lbl_contrasenia"];
            btn_ingresar.Text = translations["btn_ingresar"];
            btn_registrarse.Text = translations["btn_registrarse"];
            lbl_derechos.Text = translations["txt_derechos"];
            btb_salir.Text = translations["btb_salir"];
            lbl_idioma.Text = translations["lbl_idioma"];
        }

        private void SaveLanguagePreference(string language)
        {
            Properties.Settings.Default.Language = language.ToUpper(); // Guardar en formato 'ENGLISH' o 'SPANISH'
            Properties.Settings.Default.Save();
        }

        private void cbox_idioma_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedLanguage = cbox_idioma.SelectedItem.ToString();
            string languageKey = selectedLanguage.ToLower();
            lbl_MensajeError.Text = null;
            TemporizadorError.Stop();
            ApplyLanguage(languageKey);
            SaveLanguagePreference(languageKey);
        }

        private void pcb_modalidad_Click(object sender, EventArgs e)
        {
            if (ImagenOriginal)
            {
                AplicarModalidad("Modo_Oscuro");
                ModalidadDeAppGuardada("Modo_Oscuro");
            }
            else
            {
                AplicarModalidad("Modo_Claro");
                ModalidadDeAppGuardada("Modo_Claro");
            }
        }

        private void AplicarModalidad(string modalidad)
        {
            if (modalidad == "Modo_Oscuro")
            {
                pcb_logo.Image = Properties.Resources.Logo_modo_Oscuro;
                pcb_modalidad.Image = Properties.Resources.Modo_Oscuro;
                this.BackColor = Color.DarkSlateBlue;
                //ForeColor
                lbl_usuario.ForeColor = Color.White;
                lbl_idioma.ForeColor = Color.White;
                lbl_derechos.ForeColor = Color.White;
                lbl_contrasenia.ForeColor = Color.White;
                btb_salir.ForeColor = Color.White;
                btn_ingresar.ForeColor = Color.White;
                btn_registrarse.ForeColor = Color.White;
                cbox_idioma.ForeColor = Color.White;
                txt_contrasenia.ForeColor = Color.White;
                txt_usuario.ForeColor = Color.White;
                //BackColor
                btb_salir.BackColor = Color.Black;
                btn_ingresar.BackColor = Color.Black;
                btn_registrarse.BackColor = Color.Black;
                txt_contrasenia.BackColor = Color.Black;
                txt_usuario.BackColor = Color.Black;
                cbox_idioma.BackColor = Color.Black;
                ImagenOriginal = false;
            }
            else
            {
                pcb_logo.Image = Properties.Resources.Logo_Modo_Claro;
                pcb_modalidad.Image = Properties.Resources.Modo_Claro;
                this.BackColor = Color.FromArgb(171, 157, 250);
                //ForeColor
                lbl_usuario.ForeColor = Color.Black;
                lbl_idioma.ForeColor = Color.Black;
                lbl_derechos.ForeColor = Color.Black;
                lbl_contrasenia.ForeColor = Color.Black;
                btb_salir.ForeColor = Color.Black;
                btn_ingresar.ForeColor = Color.Black;
                btn_registrarse.ForeColor = Color.Black;
                cbox_idioma.ForeColor = Color.Black;
                txt_contrasenia.ForeColor = Color.Black;
                txt_usuario.ForeColor = Color.Black;
                //BackColor
                btb_salir.BackColor = Color.White;
                btn_ingresar.BackColor = Color.White;
                btn_registrarse.BackColor = Color.White;
                txt_contrasenia.BackColor = Color.White;
                txt_usuario.BackColor = Color.White;
                cbox_idioma.BackColor = Color.White;
                ImagenOriginal = true;
            }
        }
        private void ModalidadDeAppGuardada(string NombreModalidad)
        {
            Properties.Settings.Default.Modalidad = NombreModalidad;
            Properties.Settings.Default.Save();
        }

        private async void btn_ingresar_Click(object sender, EventArgs e)
        {
            bool valido = true; // Cambiar a verdadero inicialmente
            string usuario = txt_usuario.Text;
            string contrasenia = txt_contrasenia.Text;

            // Obtiene traducciones del idioma seleccionado
            var translations = LanguageManager.GetTranslations(Properties.Settings.Default.Language.ToLower());

            // Validaciones
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contrasenia))
            {
                lbl_MensajeError.Text = translations["error_vacio"];
                TemporizadorError.Start();
                valido = false;
            }
            else if (usuario.Length > 30)
            {
                lbl_MensajeError.Text = translations["error_usuariolargo"];
                TemporizadorError.Start();
                valido = false;
            }
            else if (contrasenia.Length > 32 || contrasenia.Length < 8)
            {
                lbl_MensajeError.Text = translations["error_contrasenialargo"];
                TemporizadorError.Start();
                valido = false;
            }

            if (valido)
            {
                // Llama al método de login
                var cuenta = new Cuenta();
                var (idUsuario, esValido) = await cuenta.Login(usuario, contrasenia);

                if (!esValido)
                {
                    lbl_MensajeError.Text = translations["error_login"];
                    TemporizadorError.Start();
                    return;
                }
                else
                {
                    lbl_MensajeError.Text = null;
                    TemporizadorError.Stop();

                    // Guardar la ID del usuario en las propiedades
                    Properties.Settings.Default.UserId = idUsuario; // Asegúrate de que UserId esté definido en tus propiedades
                    Properties.Settings.Default.Save(); // Guardar cambios

                    Feed feedForm = new Feed(idUsuario);
                    this.Hide();
                    feedForm.ShowDialog();
                    this.Close();
                }
            }
        }




        private void TemporizadorError_Tick(object sender, EventArgs e)
        {
            lbl_MensajeError.Text = null; // Limpia el mensaje de error
            TemporizadorError.Stop(); // Detiene el Timer para que no siga ejecutándose
        }

        private void btn_registrarse_Click(object sender, EventArgs e)
        {
            TemporizadorError.Stop();
            Registro registroForm = new Registro();
            this.Hide();
            registroForm.ShowDialog();
            this.Close();
        }

    }
}

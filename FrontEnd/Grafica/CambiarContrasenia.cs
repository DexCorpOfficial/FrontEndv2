using FrontEnd.Logica;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FrontEnd.Grafica
{
    public partial class CambiarContrasenia : Form
    {
        public int IdUsuario { get; set; }
        private Dictionary<string, string> translations; // Campo de la clase para almacenar las traducciones

        public CambiarContrasenia(int idUsuario)
        {
            IdUsuario = idUsuario;
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ControlBox = false;
            this.WindowState = FormWindowState.Normal;
            txt_contraseniaAnterior.UseSystemPasswordChar = true;
            txt_contraseniaNueva.UseSystemPasswordChar = true;

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

        private void ApplyLanguage(string language)
        {
            translations = LanguageManager.GetTranslations(language.ToLower()); // Inicializa las traducciones
            this.Text = translations["configuracionForm"];
            btb_salir.Text = translations["btb_salir"];
            btn_confirmarCambioC.Text = translations["btn_confirmarCambioC"];
            lbl_contraseniaNueva.Text = translations["lbl_contraseniaNueva"];
            lbl__contraseniaAnterior.Text = translations["lbl__contraseniaAnterior"];
        }

        private void AplicarModalidad(string modalidad)
        {
            if (modalidad == "Modo_Oscuro")
            {
                this.BackColor = Color.DarkSlateBlue;
                btb_salir.ForeColor = Color.White;
                btn_confirmarCambioC.ForeColor = Color.White;
                lbl__contraseniaAnterior.ForeColor = Color.White;
                lbl_contraseniaNueva.ForeColor = Color.White;
                txt_contraseniaAnterior.ForeColor = Color.White;
                txt_contraseniaNueva.ForeColor = Color.White;
                btb_salir.BackColor = Color.Black;
                btn_confirmarCambioC.BackColor = Color.Black;
                txt_contraseniaAnterior.BackColor = Color.Black;
                txt_contraseniaNueva.BackColor = Color.Black;
            }
            else
            {
                this.BackColor = Color.FromArgb(171, 157, 250);
                btb_salir.ForeColor = Color.Black;
                btn_confirmarCambioC.ForeColor = Color.Black;
                lbl_contraseniaNueva.ForeColor = Color.Black;
                lbl__contraseniaAnterior.ForeColor = Color.Black;
                txt_contraseniaAnterior.ForeColor = Color.Black;
                txt_contraseniaNueva.ForeColor = Color.Black;
                btb_salir.BackColor = Color.White;
                btn_confirmarCambioC.BackColor = Color.White;
                txt_contraseniaAnterior.BackColor = Color.White;
                txt_contraseniaNueva.BackColor = Color.White;
            }
        }

        private void btb_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btn_confirmarCambioC_Click(object sender, EventArgs e)
        {
            string contrasenaAnterior = txt_contraseniaAnterior.Text;
            string contrasenaNueva = txt_contraseniaNueva.Text;

            // Validar longitud de la nueva contraseña
            if (contrasenaNueva.Length < 8 || contrasenaNueva.Length > 32)
            {
                MessageBox.Show(
                    translations["mensaje_ContraseñaError"],
                    translations["titulo_ContraseñaError"],
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return; // Salir del método si la contraseña no cumple con los requisitos
            }

            var cuenta = new Cuenta();
            bool cambioExitoso = await cuenta.CambiarContrasenia(IdUsuario, contrasenaAnterior, contrasenaNueva);
            MessageBox.Show(
                    translations["mensaje_Confirmado"],
                    translations["titulo_Confirmado"],
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
            );
            this.Close();
        }


        private void Pcb_contrasenia_MouseDown(object sender, MouseEventArgs e)
        {
            pcb_contrasenia.Image = Properties.Resources.Ojo_cerrado; // Cambia la imagen a un ojo cerrado
            txt_contraseniaAnterior.UseSystemPasswordChar = false; // Cambia el texo contraseña a visible
            txt_contraseniaNueva.UseSystemPasswordChar = false; // Cambia el texo contraseña a no visible
        }

        private void Pcb_contrasenia_MouseUp(object sender, MouseEventArgs e)
        {
            pcb_contrasenia.Image = Properties.Resources.Ojo_abierto; // Cambia la imagen a un ojo abierto
            txt_contraseniaAnterior.UseSystemPasswordChar = true; // Cambia el texo contraseña a no visible
            txt_contraseniaNueva.UseSystemPasswordChar = true; // Cambia el texo contraseña a no visible
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrontEnd.Grafica;
using FrontEnd.Logica;

namespace FrontEnd
{
    public partial class Configuracion : Form
    {
        public int IdUsuario { get; set; }
        private bool esMusico = false;
        private bool otro = false;
        private string instrumento = null;
        public event EventHandler CambioLenguaje;
        public event EventHandler ModalidadConfig;
        public event Action Cerrar;
        private bool ImagenOriginal;
        private bool cuenta_privada;
        public Configuracion(int idUsuario)
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
        }

        private async void Configuracion_Load(object sender, EventArgs e)
        {
            try
            {
                var cuenta = new Cuenta();
                bool esPrivado = await cuenta.ObtenerPrivacidad(IdUsuario);
                // Si la cuenta es privada, marcar el CheckBox
                chb_cuenta_Privada.Checked = esPrivado;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la privacidad de la cuenta: {ex.Message}");
            }
        }


        private async void btn_salir_Click(object sender, EventArgs e)
        {
            if (chb_cuenta_Privada.Checked == true)
            try
            {
                var cuenta = new Cuenta(); // Crear una instancia de la clase Cuenta
                await cuenta.CambiarPrivacidad(IdUsuario, true); // Cambiar privado a 1
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cambiar la privacidad: {ex.Message}");
            } 
            else if (chb_cuenta_Privada.Checked == false)
            try
            {
                    var cuenta = new Cuenta(); // Crear una instancia de la clase Cuenta
                    await cuenta.CambiarPrivacidad(IdUsuario, false); // Cambiar privado a 0
                    this.Close();
            }
            catch (Exception ex)
            {
                    MessageBox.Show($"Error al cambiar la privacidad: {ex.Message}");
            }

            this.Close();
        }

        private void ApplyLanguage(string language) // Se configura el lenguaje de los botones y textos
        {
            string ModalidadApp = Properties.Settings.Default.Modalidad;
            var translations = LanguageManager.GetTranslations(language.ToLower());
            this.Text = translations["configuracionForm"];

            if (ModalidadApp == "Modo_Oscuro")
            {
                btn_modalidad.Text = translations["cambiar_modo_claro"];
            }
            else
            {
                btn_modalidad.Text = translations["cambiar_modo_oscuro"];
            }
            btn_confirmarEliminar.Text = translations["btn_confirmarEliminar"];
            lbl_cofirmarEliminar.Text = translations["lbl_confirmarEliminar"];
            btn_cambiar_Contraseña.Text = translations["btn_cambiar_contraseña"];
            lbl_cuenta_privada.Text = translations["lbl_cuentaPrivada"];
            lbl_idioma.Text = translations["lbl_idioma"];
            btb_salir.Text = translations["btb_salir"];
            lbl_idioma.Text = translations["lbl_idioma"];
            btn_cerrarsesion.Text = translations["btn_cerrarsesion"];
            btn_eliminarCuenta.Text = translations["btn_eliminarCuenta"];
        }
        private void SaveLanguagePreference(string language)
        {
            Properties.Settings.Default.Language = language.ToUpper();
            Properties.Settings.Default.Save();
        }

        private void cbox_idioma_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedLanguage = cbox_idioma.SelectedItem.ToString();
            string languageKey = selectedLanguage.ToLower();

            string ModalidadApp = Properties.Settings.Default.Modalidad;
            AplicarModalidad(ModalidadApp);
            ApplyLanguage(languageKey);
            SaveLanguagePreference(languageKey);
            CambioLenguaje?.Invoke(this, EventArgs.Empty);
        }

        public string GetCurrentLanguage()
        {
            return Properties.Settings.Default.Language; // Retornar el idioma guardado
        }

        public string ModalidadNueva()
        {
            return Properties.Settings.Default.Modalidad; // Retornar la modalidad guardada
        }

        private void btn_cerrarsesion_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.UserId = 0;
            Properties.Settings.Default.Save();

            Cerrar?.Invoke();
            this.Close();
        }


        private void button1_Click(object sender, EventArgs e)
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
            ModalidadConfig?.Invoke(this, EventArgs.Empty);
        }

        private void AplicarModalidad(string modalidad)
        {
            var translations = LanguageManager.GetTranslations(GetCurrentLanguage().ToLower());
            if (modalidad == "Modo_Oscuro")
            {
                pcb_modalidad.Image = Properties.Resources.Modo_Oscuro;
                this.BackColor = Color.DarkSlateBlue;
                //ForeColor
                lbl_idioma.ForeColor = Color.White;
                btb_salir.ForeColor = Color.White;
                cbox_idioma.ForeColor = Color.White;
                btn_cerrarsesion.ForeColor = Color.White;
                btn_modalidad.ForeColor = Color.White;
                btn_cambiar_Contraseña.ForeColor = Color.White;
                btn_modalidad.ForeColor = Color.White;
                btn_eliminarCuenta.ForeColor = Color.White;
                btn_confirmarEliminar.ForeColor = Color.White;
                lbl_cofirmarEliminar.ForeColor = Color.White;
                // Cambiar texto de la modalidad
                btn_modalidad.Text = translations["cambiar_modo_claro"];
                //BackColor
                btb_salir.BackColor = Color.Black;
                btn_confirmarEliminar.BackColor = Color.Black;
                btn_eliminarCuenta.BackColor = Color.Black;
                btn_cerrarsesion.BackColor = Color.Black;
                btn_cambiar_Contraseña.BackColor = Color.Black;
                btn_modalidad.BackColor = Color.Black;
                cbox_idioma.BackColor = Color.Black;
                ImagenOriginal = false;
            }
            else
            {
                pcb_modalidad.Image = Properties.Resources.Modo_Claro;
                this.BackColor = Color.FromArgb(171, 157, 250);
                //ForeColor
                btn_modalidad.ForeColor = Color.Black;
                btn_confirmarEliminar.ForeColor = Color.Black;
                lbl_cofirmarEliminar.ForeColor = Color.Black;
                lbl_idioma.ForeColor = Color.Black;
                btb_salir.ForeColor = Color.Black;
                btn_cerrarsesion.ForeColor = Color.Black;
                cbox_idioma.ForeColor = Color.Black;
                btn_cambiar_Contraseña.ForeColor = Color.Black;
                btn_modalidad.ForeColor = Color.Black;
                btn_eliminarCuenta.ForeColor = Color.Black;
                // Cambiar texto de la modalidad
                btn_modalidad.Text = translations["cambiar_modo_oscuro"];
                //BackColor
                btn_confirmarEliminar.BackColor = Color.White;
                btn_eliminarCuenta.BackColor = Color.White;
                btb_salir.BackColor = Color.White;
                btn_cerrarsesion.BackColor = Color.White;
                btn_cambiar_Contraseña.BackColor = Color.White;
                btn_modalidad.BackColor = Color.White;
                cbox_idioma.BackColor = Color.White;
                ImagenOriginal = true;
            }
        }

        private void ModalidadDeAppGuardada(string NombreModalidad)
        {
            Properties.Settings.Default.Modalidad = NombreModalidad;
            Properties.Settings.Default.Save();
        }

        private void chb_cuenta_Privada_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_cuenta_Privada.Checked == true)
            {
                cuenta_privada = true;
            }else
            {
                cuenta_privada = false;
            }
        }

        private void btn_eliminarCuenta_Click(object sender, EventArgs e)
        {
            lbl_cofirmarEliminar.Visible = true;
            btn_confirmarEliminar.Visible = true;
        }

        private async void btn_confirmarEliminar_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.UserId = 0;
            Properties.Settings.Default.Save();
            var cuenta = new Cuenta();
            await cuenta.eliminarCuenta(IdUsuario);
            Cerrar?.Invoke();
            this.Close();
        }

        private void btn_cambiar_Contraseña_Click(object sender, EventArgs e)
        {
            CambiarContrasenia CambiarContraseniaForm = new CambiarContrasenia(IdUsuario);
            CambiarContraseniaForm.ShowDialog();
        }
    }
}

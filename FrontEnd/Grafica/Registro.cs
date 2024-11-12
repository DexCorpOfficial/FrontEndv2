using FrontEnd.Logica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FrontEnd
{
    public partial class Registro : Form
    {
        private string PlaceholderText = null;
        private readonly string[] instrumentosPopularesENGLISH =
{
    "Piano", "Guitar", "Violin", "Drums", "Flute", "Saxophone", "Trumpet", "Clarinet",
    "Cello", "Harp", "Trombone", "French Horn", "Tuba", "Oboe", "Bassoon", "Mandolin",
    "Accordion", "Harmonica", "Sitar", "Banjo", "Ukulele", "Electric Guitar", "Bass Guitar"
};

        private readonly string[] instrumentosPopularesESPANIOL =
        {
    "Piano", "Guitarra", "Violín", "Batería", "Flauta", "Saxofón", "Trompeta", "Clarinete",
    "Violoncello", "Arpa", "Trombón", "Trompa", "Tuba", "Oboe", "Fagote", "Mandolina",
    "Acordeón", "Armónica", "Sitar", "Banjo", "Ukulele", "Guitarra Eléctrica", "Guitarra Baja"
};
        private readonly string[] opcionesSexoESPANIOL = { "Hombre", "Mujer", "Otro", "Prefiero no decirlo" };
        private readonly string[] opcionesSexoENGLISH = { "Male", "Female", "Other", "Prefer not to say" };
        private Timer TemporizadorError;
        private bool isOriginalImage;
        private bool esMusico = false;
        private bool otro = false;
        private string instrumento = null;
        public Registro()
        {
            InitializeComponent();

            DateTime hoy = DateTime.Now;
            dtp_fecha.MinDate = hoy.AddYears(-100);
            dtp_fecha.MaxDate = hoy.AddYears(-15);
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.WindowState = FormWindowState.Normal;
            string idiomaGuardado = Properties.Settings.Default.Language;
            Console.WriteLine(idiomaGuardado);
            if (idiomaGuardado == null)
            {
                ApplyLanguage(idiomaGuardado.ToLower());
                cbox_idioma.SelectedItem = idiomaGuardado;
            }
            else
            {
                ApplyLanguage("español");
                cbox_idioma.SelectedItem = "Español";
                Properties.Settings.Default.Language = "español";
                Properties.Settings.Default.Save();
            }
            string ModalidadApp = Properties.Settings.Default.Modalidad;
            AplicarModalidad(ModalidadApp);
            TemporizadorError = new Timer();
            TemporizadorError.Interval = 5000;
            TemporizadorError.Tick += TemporizadorError_Tick;
            txt_contrasenia.UseSystemPasswordChar = true;
            txt_confirmarcontrasenia.UseSystemPasswordChar = true;
            InitializePlaceholder();

        }

        private void InitializePlaceholder()
        {
            txt_busquedaInstrumento.Text = PlaceholderText;
            txt_busquedaInstrumento.Enter += txt_busquedaInstrumento_Enter;
            txt_busquedaInstrumento.Leave += txt_busquedaInstrumento_Leave;
            txt_busquedaInstrumento.TextChanged += Txt_busquedaInstrumento_TextChanged;
        }

        private void txt_busquedaInstrumento_Enter(object sender, EventArgs e)
        {
            // Cuando el TextBox recibe el enfoque, borrar el texto de marcador de posición
            if (txt_busquedaInstrumento.Text == PlaceholderText)
            {
                txt_busquedaInstrumento.Text = "";
            }
        }

        private void txt_busquedaInstrumento_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_busquedaInstrumento.Text))
            {
                txt_busquedaInstrumento.Text = PlaceholderText;

                var allInstruments = Properties.Settings.Default.Language.ToLower() == "english"
                    ? instrumentosPopularesENGLISH
                    : instrumentosPopularesESPANIOL;

                lbox_instrumentos.Items.Clear();
                lbox_instrumentos.Items.AddRange(allInstruments.OrderBy(i => i).ToArray());
            }
        }

        private void Txt_busquedaInstrumento_TextChanged(object sender, EventArgs e)
        {
            string searchText = txt_busquedaInstrumento.Text.ToLower();

            string[] instrumentosActuales = Properties.Settings.Default.Language.ToLower() == "english"
                ? instrumentosPopularesENGLISH
                : instrumentosPopularesESPANIOL;

            var filteredList = instrumentosActuales
                .Where(i => i.ToLower().Contains(searchText))
                .OrderBy(i => i)
                .ToArray();

            lbox_instrumentos.Items.Clear();
            lbox_instrumentos.Items.AddRange(filteredList);
        }

        private void Registro_Load(object sender, EventArgs e)
        {
        }


        private void btn_Volver_Click(object sender, EventArgs e)
        {
            Login Login = new Login();
            this.Hide();
            Login.ShowDialog();
            this.Close();
        }

        private void pcb_modalidad_Click(object sender, EventArgs e)
        {
            if (isOriginalImage)
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
                //ForeColor
                this.BackColor = Color.DarkSlateBlue;
                lbox_instrumentos.ForeColor = Color.White;
                txt_busquedaInstrumento.ForeColor = Color.White;
                lbl_tipoCuenta.ForeColor = Color.White;
                cbox_sexo.ForeColor = Color.White;
                dtp_fecha.ForeColor = Color.White;
                lbl_sexo.ForeColor = Color.White;
                lbl_fechaNacimiento.ForeColor = Color.White;
                lbl_idioma.ForeColor = Color.White;
                lbl_derechos.ForeColor = Color.White;
                btn_Volver.ForeColor = Color.White;
                cbox_idioma.ForeColor = Color.White;
                lbl_contrasenia.ForeColor = Color.White;
                txt_contrasenia.ForeColor = Color.White;
                btn_confirmar.ForeColor = Color.White;
                txt_confirmarcontrasenia.ForeColor = Color.White;
                txt_nombre.ForeColor = Color.White;
                lbl_Foto_Perfil.ForeColor = Color.White;
                lbl_nombre.ForeColor = Color.White;
                lbl_confirmarcontrasenia.ForeColor = Color.White;
                lbl_otro.ForeColor = Color.White;
                btn_SubirFoto.ForeColor = Color.White;
                //BackColor
                btn_Volver.BackColor = Color.Black;
                btn_SubirFoto.BackColor = Color.Black;
                txt_nombre.BackColor = Color.Black;
                txt_confirmarcontrasenia.BackColor = Color.Black;
                txt_contrasenia.BackColor = Color.Black;
                lbox_instrumentos.BackColor = Color.Black;
                txt_busquedaInstrumento.BackColor = Color.Black;
                txt_contrasenia.BackColor = Color.Black;
                cbox_idioma.BackColor = Color.Black;
                cbox_sexo.BackColor = Color.Black;
                btn_confirmar.BackColor = Color.Black;
                isOriginalImage = false;
            }
            else
            {
                pcb_logo.Image = Properties.Resources.Logo_Modo_Claro;
                pcb_modalidad.Image = Properties.Resources.Modo_Claro;
                this.BackColor = Color.FromArgb(171, 157, 250);
                //ForeColor
                txt_busquedaInstrumento.ForeColor = Color.Black;
                lbl_Foto_Perfil.ForeColor = Color.Black;
                lbox_instrumentos.ForeColor = Color.Black;
                lbl_tipoCuenta.ForeColor = Color.Black;
                cbox_sexo.ForeColor = Color.Black;
                dtp_fecha.ForeColor = Color.Black;
                lbl_sexo.ForeColor = Color.Black;
                lbl_fechaNacimiento.ForeColor = Color.Black;
                lbl_idioma.ForeColor = Color.Black;
                lbl_derechos.ForeColor = Color.Black;
                btn_Volver.ForeColor = Color.Black;
                cbox_idioma.ForeColor = Color.Black;
                lbl_contrasenia.ForeColor = Color.Black;
                txt_contrasenia.ForeColor = Color.Black;
                btn_confirmar.ForeColor = Color.Black;
                txt_confirmarcontrasenia.ForeColor = Color.Black;
                lbl_confirmarcontrasenia.ForeColor = Color.Black;
                txt_nombre.ForeColor = Color.Black;
                lbl_nombre.ForeColor = Color.Black;
                lbl_otro.ForeColor = Color.Black;
                btn_SubirFoto.ForeColor = Color.Black;
                //BackColor
                btn_SubirFoto.BackColor = Color.White;
                btn_Volver.BackColor = Color.White;
                txt_nombre.BackColor = Color.White;
                txt_confirmarcontrasenia.BackColor = Color.White;
                txt_contrasenia.BackColor = Color.White;
                lbox_instrumentos.BackColor = Color.White;
                txt_busquedaInstrumento.BackColor = Color.White;
                txt_contrasenia.BackColor = Color.White;
                cbox_idioma.BackColor = Color.White;
                cbox_sexo.BackColor = Color.White;
                btn_confirmar.BackColor = Color.White;
                isOriginalImage = true;
            }
        }

        private void ApplyLanguage(string language)
        {
            var translations = LanguageManager.GetTranslations(language.ToLower());
            lbox_instrumentos.Items.Clear();
            cbox_sexo.Items.Clear();
            PlaceholderText = translations["placeholder"];
            InitializePlaceholder();
            if (language == "español")
            {
                cbox_sexo.Items.AddRange(opcionesSexoESPANIOL);
                lbox_instrumentos.Items.AddRange(instrumentosPopularesESPANIOL);
            }
            else if (language == "english")
            {
                cbox_sexo.Items.AddRange(opcionesSexoENGLISH);
                lbox_instrumentos.Items.AddRange(instrumentosPopularesENGLISH);
            }

            if (cbox_sexo.Items.Count > 0)
            {
                cbox_sexo.SelectedIndex = 0;
            }

            if (lbox_instrumentos.Items.Count > 0)
            {
                lbox_instrumentos.SelectedIndex = 0;
            }
            btn_SubirFoto.Text = translations["btn_foto_perfil"];
            lbl_Foto_Perfil.Text = translations["lbl_foto_perfil"];
            lbl_otro.Text = translations["lbl_otro"];
            lbl_tipoCuenta.Text = translations["lbl_tipoCuenta"];
            lbl_derechos.Text = translations["txt_derechos"];
            btn_Volver.Text = translations["btn_volver"];
            lbl_idioma.Text = translations["lbl_idioma"];
            lbl_contrasenia.Text = translations["lbl_contrasenia"];
            lbl_confirmarcontrasenia.Text = translations["lbl_confirmarcontrasenia"];
            btn_confirmar.Text = translations["btn_continuar"];
            lbl_nombre.Text = translations["lbl_nombre"];
            lbl_sexo.Text = translations["lbl_sexo"];
            lbl_fechaNacimiento.Text = translations["lbl_fechaNacimiento"];
        }


        private void cbox_idioma_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedLanguage = cbox_idioma.SelectedItem.ToString();
            string languageKey = selectedLanguage.ToLower();
            lbl_MensajeError.Text = null;
            if (TemporizadorError != null)
            {
                TemporizadorError.Stop();
            }
            ApplyLanguage(languageKey);
            SaveLanguagePreference(languageKey);
        }

        private void SaveLanguagePreference(string language)
        {
            Properties.Settings.Default.Language = language.ToUpper(); // Guardar en formato 'ENGLISH' o 'SPANISH'
            Properties.Settings.Default.Save();
        }

        private void ModalidadDeAppGuardada(string NombreModalidad)
        {
            Properties.Settings.Default.Modalidad = NombreModalidad;
            Properties.Settings.Default.Save();
        }

        private void TemporizadorError_Tick(object sender, EventArgs e)
        {
            lbl_MensajeError.Text = null; // Limpia el mensaje de error
            TemporizadorError.Stop(); // Detiene el Timer para que no siga ejecutándose
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

        private async void btn_continuar_Click(object sender, EventArgs e)
        {
            bool valido = true;
            string contrasenia = txt_contrasenia.Text;
            string nombre = txt_nombre.Text;
            string confirmarcontrasenia = txt_confirmarcontrasenia.Text;
            DateTime fechaNacimiento = dtp_fecha.Value;

            // Obtiene traducciones del idioma seleccionado
            var translations = LanguageManager.GetTranslations(Properties.Settings.Default.Language.ToLower());

            // Validaciones
            if (string.IsNullOrWhiteSpace(contrasenia) || string.IsNullOrWhiteSpace(nombre))
            {
                lbl_MensajeError.Text = translations["error_vacio"];
                TemporizadorError.Start();
                valido = false;
            }
            else if (nombre.Length > 30)
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
            else if (contrasenia != confirmarcontrasenia)
            {
                lbl_MensajeError.Text = translations["error_noiguales"];
                TemporizadorError.Start();
                valido = false;
            }
            else if (esMusico && string.IsNullOrWhiteSpace(instrumento))
            {
                lbl_MensajeError.Text = translations["error_instrumento"];
                TemporizadorError.Start();
                valido = false;
            }

            if (valido)
            {
                // Verifica si el nombre ya está en uso llamando a ObtenerNombres
                var cuenta = new Cuenta();
                List<string> nombresActivos = await cuenta.ObtenerNombres();

                if (nombresActivos.Contains(nombre))
                {
                    lbl_MensajeError.Text = translations["error_nombreexistente"];
                    TemporizadorError.Start();
                    return;
                }

                // Si el nombre no está en uso, continúa con el registro
                string genero = cbox_sexo.Text;
                bool musico = chb_Musico.Checked;

                // Obtén los bytes de la imagen de perfil
                byte[] fotoPerfil;

                if (string.IsNullOrEmpty(opfdPerfil.FileName) || !File.Exists(opfdPerfil.FileName))
                {
                    // Cargar imagen por defecto si no se ha seleccionado un archivo o el archivo no existe.
                    fotoPerfil = ImageToByteArray(Properties.Resources.Foto_de_Perfil_Por_Defecto);
                }
                else
                {
                    // Si el archivo existe, cargarlo.
                    fotoPerfil = File.ReadAllBytes(opfdPerfil.FileName);
                }

                // Llama al registro y obtiene el ID del usuario
                var Instrumentos = new Instrumentos();
                int idUsuario = await cuenta.Registro(nombre, contrasenia, fotoPerfil, musico, genero, fechaNacimiento);
                if (esMusico)
                {
                    await Instrumentos.AsignarInstrumento(idUsuario, instrumento);
                }
                lbl_MensajeError.Text = null;
                TemporizadorError.Stop();
                Properties.Settings.Default.UserId = idUsuario;
                Properties.Settings.Default.Save();
                Feed feedForm = new Feed(idUsuario); // Pasar el ID al formulario Feed
                this.Hide();
                feedForm.ShowDialog();
                this.Close();
            }
        }


        // Método para convertir un Bitmap a byte[]
        private byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Png); // Puedes cambiar el formato si lo prefieres
                return ms.ToArray();
            }
        }






        private void chb_Musico_CheckedChanged(object sender, EventArgs e)
        {
            string[] instrumentosActuales = Properties.Settings.Default.Language.ToLower() == "english"
            ? instrumentosPopularesENGLISH
            : instrumentosPopularesESPANIOL;

            lbox_instrumentos.Items.Clear();
            lbox_instrumentos.Items.AddRange(instrumentosActuales.OrderBy(i => i).ToArray());

            if (chb_Musico.Checked == true)
            {
                lbl_otro.Visible = true;
                chb_otro.Visible = true;
                lbox_instrumentos.Visible = true;
                chb_otro.Checked = false;
                txt_busquedaInstrumento.Visible = true;
                esMusico = true;
            }
            else
            {
                lbl_otro.Visible = false;
                chb_otro.Visible = false;
                lbox_instrumentos.Visible = false;
                chb_otro.Checked = false;
                txt_busquedaInstrumento.Visible = false;
                esMusico = false;
                instrumento = null;
            }
        }

        private void chb_otro_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_otro.Checked == true)
            {
                instrumento = "otro";
                otro = true;
            }
            else
            {
                instrumento = null;
                otro = false;
            }
        }

        private void lbox_instrumentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbox_instrumentos.SelectedIndex >= 0)
            {
                instrumento = lbox_instrumentos.Text;
                chb_otro.Checked = false;
                otro = false;
            }
        }

        private void btn_SubirFoto_Click(object sender, EventArgs e)
        {
            pcb_VistaPrevia.Visible = true; // Asegúrate de que el PictureBox es visible
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
                    pcb_VistaPrevia.Image = imagen; // Asigna la imagen al PictureBox
                    pcb_VistaPrevia.SizeMode = PictureBoxSizeMode.Zoom; // Ajusta el modo de visualización

                    byte[] fotoPerfil = ImageToByteArray(imagen); // Convertir la imagen a bytes
                }
            }
        }

    }
}
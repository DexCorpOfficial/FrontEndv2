using FrontEnd.Grafica;
using FrontEnd.Logica;
using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEnd
{
    public partial class Feed : Form
    {
        public int IdUsuario { get; set; }
        private string textoMostradoConfig;
        private string textoMostradoSalir;
        private string textoMostradoMis_Bandas;
        private int currentCharIndexConfig = 0;
        private int currentCharIndexMis_Bandas = 0;
        private int currentCharIndexSalir = 0;
        private Timer timer1;
        private Timer timer2;
        private Timer timer3;
        public string SelectedLanguage { get; set; }
        public Feed(int idUsuario)
        {
            InitializeComponent();
            IdUsuario = idUsuario; // Asigna el ID del usuario

            // Carga de idioma
            string idiomaGuardado = Properties.Settings.Default.Language;
            if (!string.IsNullOrEmpty(idiomaGuardado))
            {
                ApplyLanguage(idiomaGuardado.ToLower());
            }
            else
            {
                ApplyLanguage("español");
            }

            // Inicialización de temporizadores
            timer1 = new Timer();
            timer1.Interval = 1;
            timer1.Tick += Timer1_TickConfig;

            timer2 = new Timer();
            timer2.Interval = 1;
            timer2.Tick += Timer2_TickSalir;

            timer3 = new Timer();
            timer3.Interval = 1;
            timer3.Tick += Timer3_TickMis_Bandas;

            // Configuración del formulario
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.WindowState = FormWindowState.Normal;
            string ModalidadApp = Properties.Settings.Default.Modalidad;
            AplicarModalidad(ModalidadApp);
            configuracionMenuItem.Text = string.Empty;
            salirMenuItem.Text = string.Empty;
            Mis_BandasMenuItem.Text = string.Empty;

            this.Load += new EventHandler(OnFeedLoad); // Cambia a OnFeedLoad
        }

        private async void OnFeedLoad(object sender, EventArgs e)
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


        private void ConfiguracionMenuItem_MouseHover(object sender, EventArgs e)
        {
            // Reiniciar el índice y mostrar el texto "Configuración"
            currentCharIndexConfig = 0;
            configuracionMenuItem.Text = string.Empty;
            timer1.Start();
        }

        private void ConfiguracionMenuItem_MouseLeave(object sender, EventArgs e)
        {
            // Detener el Timer y ocultar el texto
            timer1.Stop();
            configuracionMenuItem.Text = string.Empty;
        }


        private void Timer1_TickConfig(object sender, EventArgs e)
        {
            // Mostrar progresivamente el texto "Configuración"
            if (currentCharIndexConfig < textoMostradoConfig.Length)
            {
                configuracionMenuItem.Text += textoMostradoConfig[currentCharIndexConfig];
                currentCharIndexConfig++;
            }
            else
            {
                timer1.Stop();
            }
        }
        private void SalirMenuItem_MouseHover(object sender, EventArgs e)
        {
            // Reiniciar el índice y mostrar el texto "Salir"
            currentCharIndexSalir = 0;
            salirMenuItem.Text = string.Empty;
            timer2.Start();
        }

        private void SalirMenuItem_MouseLeave(object sender, EventArgs e)
        {
            // Detener el Timer y ocultar el texto
            timer2.Stop();
            salirMenuItem.Text = string.Empty;
        }

        private void Timer2_TickSalir(object sender, EventArgs e)
        {
            // Mostrar progresivamente el texto "Salir"
            if (currentCharIndexSalir < textoMostradoSalir.Length)
            {
                salirMenuItem.Text += textoMostradoSalir[currentCharIndexSalir];
                currentCharIndexSalir++;
            }
            else
            {
                timer2.Stop();
            }
        }

        private void Mis_BandasMenuItem_MouseHover(object sender, EventArgs e)
        {
            // Reiniciar el índice y mostrar el texto "Mis Bandas"
            currentCharIndexMis_Bandas = 0;
            Mis_BandasMenuItem.Text = string.Empty;
            timer3.Start();
        }
        private void Mis_BandasMenuItem_MouseLeave(object sender, EventArgs e)
        {
            // Detener el Timer y ocultar el texto
            timer3.Stop();
            Mis_BandasMenuItem.Text = string.Empty;
        }

        private void Timer3_TickMis_Bandas(object sender, EventArgs e)
        {
            // Mostrar progresivamente el texto "Mis Bandas"
            if (currentCharIndexMis_Bandas < textoMostradoMis_Bandas.Length)
            {
                Mis_BandasMenuItem.Text += textoMostradoMis_Bandas[currentCharIndexMis_Bandas];
                currentCharIndexMis_Bandas++;
            }
            else
            {
                timer3.Stop();
            }
        }

        private void pcb_Menu_Click(object sender, EventArgs e)
        {
            contextMenuOpciones.Show(pcb_Menu, new Point(0, 0));
        }

        private void configuracionMenuItem_Click(object sender, EventArgs e)
        {
            Configuracion configForm = new Configuracion(IdUsuario);
            configForm.CambioLenguaje += ConfigForm_LanguageChanged;
            configForm.ModalidadConfig += ConfigForm_ModalidadConfig;
            configForm.Cerrar += () => this.Close();
            configForm.ShowDialog();
        }

        private void ConfigForm_LanguageChanged(object sender, EventArgs e)
        {
            string newLanguage = ((Configuracion)sender).GetCurrentLanguage();
            ApplyLanguage(newLanguage);
        }
        private void ConfigForm_ModalidadConfig(object sender, EventArgs e)
        {
            string ModalidadNueva = ((Configuracion)sender).ModalidadNueva();
            AplicarModalidad(ModalidadNueva);
        }

        private void salirMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void ApplyLanguage(string language)
        {
            var translations = LanguageManager.GetTranslations(language.ToLower());
            textoMostradoConfig = translations["Configuracion"];
            textoMostradoSalir = translations["Salir"];
            textoMostradoMis_Bandas = translations["Mis_Bandas"];
            btn_publicar.Text = translations["Publicar"];
        }

        private void Feed_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(SelectedLanguage))
            {
                ApplyLanguage(SelectedLanguage);
            }
        }
        private void AplicarModalidad(string modalidad)
        {
            if (modalidad == "Modo_Oscuro")
            {
                this.BackColor = Color.DarkSlateBlue;
                //BackColor
                configuracionMenuItem.Image = Properties.Resources.TuercaConfigOscuro;
                salirMenuItem.Image = Properties.Resources.SalirOscuro;
                pcb_inbox.IconColor = Color.White;
                icon_MeGusta.IconColor = Color.White;
                icon_compartir.IconColor = Color.White;
                iconMensajes.IconColor = Color.White;
                iconSiguientePost.IconColor = Color.White;
                iconPostAnterior.IconColor = Color.White;
                pcb_Comentarios.Image = Properties.Resources.Comentario_Oscuro;
                pcb_busqueda.IconColor = Color.White;
                pcb_logo.Image = Properties.Resources.BandApp_Claro;
                pcb_Menu.Image = Properties.Resources.BarradetareasOscuro;
                pcb_inbox.BackColor = Color.DarkSlateBlue;
                icon_MeGusta.BackColor = Color.DarkSlateBlue;
                icon_compartir.BackColor = Color.DarkSlateBlue;
                iconSiguientePost.BackColor = Color.DarkSlateBlue;
                iconPostAnterior.BackColor = Color.DarkSlateBlue;
                pcb_Comentarios.BackColor = Color.DarkSlateBlue;
                pcb_busqueda.BackColor = Color.DarkSlateBlue;
                configuracionMenuItem.BackColor = Color.DarkSlateBlue;
                Mis_BandasMenuItem.BackColor = Color.DarkSlateBlue;
                iconMensajes.BackColor = Color.DarkSlateBlue;
                salirMenuItem.BackColor = Color.DarkSlateBlue;
                btn_publicar.BackColor = Color.Black;
                pcb_fondoamigos.BackColor = Color.FromArgb(64, 64, 64);
                pcb_fondoamigos.IconColor = Color.FromArgb(64, 64, 64);
                pcb_imagenperfil.BackColor = Color.FromArgb(64, 64, 64);
                lbl_nombrePerfil.BackColor = Color.FromArgb(64, 64, 64);
                pcb_foto_Publicado.BackColor = Color.DarkSlateBlue;
                lbl_nombre_Publicado.BackColor = Color.DarkSlateBlue;
                configuracionMenuItem.ImageTransparentColor = Color.DarkSlateBlue;
                Mis_BandasMenuItem.ImageTransparentColor = Color.DarkSlateBlue;
                salirMenuItem.ImageTransparentColor = Color.DarkSlateBlue;
                //ForeColor
                lbl_nombrePerfil.ForeColor = Color.White;
                lbl_nombre_Publicado.ForeColor = Color.White;
                btn_publicar.ForeColor = Color.White;
            }
            else
            {
                this.BackColor = Color.FromArgb(171, 157, 250);
                //BackColor
                configuracionMenuItem.Image = Properties.Resources.TuercaConfigClaro;
                salirMenuItem.Image = Properties.Resources.SalirClaro;
                pcb_inbox.IconColor = Color.Black;
                icon_MeGusta.IconColor = Color.Black;
                icon_compartir.IconColor = Color.Black;
                iconMensajes.IconColor = Color.Black;
                iconSiguientePost.IconColor = Color.Black;
                iconPostAnterior.IconColor = Color.Black;
                pcb_Comentarios.Image = Properties.Resources.Comentario_Claro;
                pcb_logo.Image = Properties.Resources.BandApp_Negro;
                pcb_busqueda.IconColor = Color.Black;
                pcb_Menu.Image = Properties.Resources.BarradetareasClaro;
                btn_publicar.BackColor = Color.White;
                pcb_Comentarios.BackColor = Color.FromArgb(171, 157, 250);
                icon_MeGusta.BackColor = Color.FromArgb(171, 157, 250);
                icon_compartir.BackColor = Color.FromArgb(171, 157, 250);
                iconMensajes.BackColor = Color.FromArgb(171, 157, 250);
                iconSiguientePost.BackColor = Color.FromArgb(171, 157, 250);
                iconPostAnterior.BackColor = Color.FromArgb(171, 157, 250);
                pcb_inbox.BackColor = Color.FromArgb(171, 157, 250);
                pcb_busqueda.BackColor = Color.FromArgb(171, 157, 250);
                configuracionMenuItem.BackColor = Color.FromArgb(171, 157, 250);
                Mis_BandasMenuItem.BackColor = Color.FromArgb(171, 157, 250);
                salirMenuItem.BackColor = Color.FromArgb(171, 157, 250);
                pcb_fondoamigos.BackColor = Color.FromArgb(218, 212, 250);
                pcb_fondoamigos.IconColor = Color.FromArgb(218, 212, 250);
                pcb_imagenperfil.BackColor = Color.FromArgb(218, 212, 250);
                lbl_nombrePerfil.BackColor = Color.FromArgb(218, 212, 250);
                pcb_foto_Publicado.BackColor = Color.FromArgb(171, 157, 250);
                lbl_nombre_Publicado.BackColor = Color.FromArgb(171, 157, 250);
                configuracionMenuItem.ImageTransparentColor = Color.FromArgb(171, 157, 250);
                Mis_BandasMenuItem.ImageTransparentColor = Color.FromArgb(171, 157, 250);
                salirMenuItem.ImageTransparentColor = Color.FromArgb(171, 157, 250);
                //ForeColor
                btn_publicar.ForeColor = Color.Black;
                lbl_nombrePerfil.ForeColor = Color.Black;
                lbl_nombre_Publicado.ForeColor = Color.Black;
            }
        }
        public string GetCurrentLanguage()
        {
            return Properties.Settings.Default.Language; // Retorna el idioma guardado
        }

        public string ModalidadNueva()
        {
            return Properties.Settings.Default.Modalidad; // Retorna la modalidad guardada
        }

        private void btn_publicar_Click(object sender, EventArgs e)
        {
            SubirPublicacion SubirPublicacionForm = new SubirPublicacion();
            SubirPublicacionForm.ShowDialog();
        }

        private void pcb_busqueda_Click(object sender, EventArgs e)
        {
            BusquedaUsuarios BusquedaUsuariosForm = new BusquedaUsuarios(IdUsuario);
            this.Hide();
            BusquedaUsuariosForm.ShowDialog();
            this.Close();
        }

        private void lbl_nombrePerfil_Click(object sender, EventArgs e)
        {
            Perfil PerfilForm = new Perfil(IdUsuario, 0);
            this.Hide();
            PerfilForm.ShowDialog();
            this.Close();
        }

        private void Mis_BandasMenuItem_Click(object sender, EventArgs e)
        {
            Bandas BandasForm = new Bandas(IdUsuario);
            this.Hide();
            BandasForm.ShowDialog();
            this.Close();
        }
    }
}

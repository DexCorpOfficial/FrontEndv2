using FrontEnd.Logica;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEnd.Grafica
{
    public partial class Perfil : Form
    {
        public int IdUsuario { get; set; }
        public int IdUsuarioAjeno { get; set; }

        public Perfil(int idUsuario, int idUsuarioAjeno)
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
            this.Load += new EventHandler(OnPerfilLoad);
        }

        private async void OnPerfilLoad(object sender, EventArgs e)
        {
            if (IdUsuarioAjeno != 0)
            {
                await PerfilAjeno(IdUsuarioAjeno);
                await UpdateSeguidoresSeguidos(IdUsuarioAjeno);
            }
            else
            {
                await PerfilPropio(IdUsuario);
                await UpdateSeguidoresSeguidos(IdUsuario);
            }
        }

        private async Task PerfilPropio(int idUsuario)
        {
            string language = Properties.Settings.Default.Language;
            var translations = LanguageManager.GetTranslations(language.ToLower());
            Cuenta cuenta = new Cuenta();
            var usuario = await cuenta.ObtenerUsuarioPorId(idUsuario);
            btn_editarPerfil.Visible = true;

            if (usuario != null)
            {
                lbl_NombrePerfilGrande.Text = usuario.nombre;
                lbl_sexo.Text = translations["lbl_sexo"] + usuario.genero;
                if (usuario.foto_Perfil != null)
                {
                    using (var ms = new MemoryStream(usuario.foto_Perfil))
                    {
                        pcb_fotoPerfilGrande.Image = Image.FromStream(ms);
                        pcb_fotoPerfilGrande.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                }

                // Obtener los instrumentos y actualizar el label
                Instrumentos instrumentos = new Instrumentos(); // Instanciando la clase Instrumentos
                var listaInstrumentos = await instrumentos.ObtenerInstrumentosPorCuenta(idUsuario);

                // Depuración: Imprimir la lista de instrumentos
                Debug.WriteLine("Lista de instrumentos para el usuario " + idUsuario + ":");
                foreach (var instrumento in listaInstrumentos)
                {
                    Debug.WriteLine("Instrumento: " + instrumento.nombre);
                }

                if (listaInstrumentos.Count > 0)
                {
                    lbl_InstrumentoUsuario.Text = translations["lbl_InstrumentoUsuario"] + string.Join(", ", listaInstrumentos.Select(i => i.Instrumento));
                }
                else
                {
                    lbl_InstrumentoUsuario.Visible = false;
                }

                await UpdateSeguidoresSeguidos(idUsuario);
            }
            if (usuario.biografia == null)
            {
                lbl_DescripcionUsuario.Text = translations["lbl_DescripcionUsuario"] + translations["txt_DescripcionVacio"];
            }
            else
            {
                lbl_DescripcionUsuario.Text = translations["lbl_DescripcionUsuario"] + usuario.biografia;
            }
        }


        private async Task PerfilAjeno(int idUsuarioAjeno)
        {
            Cuenta cuenta = new Cuenta();
            string language = Properties.Settings.Default.Language;
            var translations = LanguageManager.GetTranslations(language.ToLower());
            var usuarioAjeno = await cuenta.ObtenerUsuarioPorId(idUsuarioAjeno);
            btn_seguir.Visible = true;
            btn_escribir.Visible = true;

            if (usuarioAjeno != null)
            {
                lbl_NombrePerfilGrande.Text = usuarioAjeno.nombre;
                lbl_sexo.Text = translations["lbl_sexo"] + usuarioAjeno.genero;
                if (usuarioAjeno.foto_Perfil != null)
                {
                    using (var ms = new MemoryStream(usuarioAjeno.foto_Perfil))
                    {
                        pcb_fotoPerfilGrande.Image = Image.FromStream(ms);
                        pcb_fotoPerfilGrande.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                }

                // Obtener los instrumentos y actualizar el label
                Instrumentos instrumentos = new Instrumentos(); // Instanciando la clase Instrumentos
                var listaInstrumentos = await instrumentos.ObtenerInstrumentosPorCuenta(idUsuarioAjeno);

                // Depuración: Imprimir la lista de instrumentos
                Debug.WriteLine("Lista de instrumentos para el usuario ajeno " + idUsuarioAjeno + ":");
                foreach (var instrumento in listaInstrumentos)
                {
                    Debug.WriteLine("Instrumento: " + instrumento.nombre);
                }

                if (listaInstrumentos.Count > 0)
                {
                    lbl_InstrumentoUsuario.Text = translations["lbl_InstrumentoUsuario"] + string.Join(", ", listaInstrumentos.Select(i => i.Instrumento));
                }
                else
                {
                    lbl_InstrumentoUsuario.Visible = false;
                }

                bool yaSigue = await VerificarSiYaSigue(IdUsuario, idUsuarioAjeno);
                btn_seguir.Text = yaSigue ? translations["DejarSeguir"] : translations["Seguir"];
                await UpdateSeguidoresSeguidos(idUsuarioAjeno);
            }
            if (usuarioAjeno.biografia == null)
            {
                lbl_DescripcionUsuario.Text = translations["lbl_DescripcionUsuario"] + translations["txt_DescripcionVacio"];
            }
            else
            {
                lbl_DescripcionUsuario.Text = translations["lbl_DescripcionUsuario"] + usuarioAjeno.biografia;
            }
        }



        private async Task<bool> VerificarSiYaSigue(int idEmisor, int idReceptor)
        {
            Interactuan interactuan = new Interactuan();
            return await interactuan.VerificarInteraccionExistente(idEmisor, idReceptor);
        }

        private async Task UpdateSeguidoresSeguidos(int idUsuario)
        {
            string language = Properties.Settings.Default.Language;
            var translations = LanguageManager.GetTranslations(language.ToLower());
            var interactuan = new Interactuan();
            var (seguidores, seguidos) = await interactuan.ActualizarContadores(idUsuario);

            lbl_Seguidores.Text = translations["lbl_Seguidores"] + seguidores.ToString();
            lbl_Seguidos.Text = translations["lbl_Seguidos"] + seguidos.ToString();
        }

        public void ApplyLanguage(string language)
        {
            var translations = LanguageManager.GetTranslations(language.ToLower());
            lbl_PublicacionesCreadas.Text = translations["lbl_PublicacionesCreadas"];
            btn_editarPerfil.Text = translations["btn_editarPerfil"];
            btn_VolverFeed.Text = translations["btn_VolverFeed"];
            btn_escribir.Text = translations["btn_escribir"];
        }

        private void AplicarModalidad(string modalidad)
        {
            if (modalidad == "Modo_Oscuro")
            {
                this.BackColor = Color.DarkSlateBlue;
                //BackColor
                pcb_logo.Image = Properties.Resources.BandApp_Claro;
                btn_VolverFeed.BackColor = Color.Black;
                btn_editarPerfil.BackColor = Color.Black;
                btn_seguir.BackColor = Color.Black;
                btn_escribir.BackColor = Color.Black;
                //ForeColor
                btn_VolverFeed.ForeColor = Color.White;
                lbl_sexo.ForeColor = Color.White;
                btn_editarPerfil.ForeColor = Color.White;
                btn_seguir.ForeColor = Color.White;
                lbl_nombrePerfil.ForeColor = Color.White;
                lbl_DescripcionUsuario.ForeColor = Color.White;
                lbl_PublicacionesCreadas.ForeColor = Color.White;
                lbl_InstrumentoUsuario.ForeColor = Color.White;
                lbl_Seguidores.ForeColor = Color.White;
                lbl_Seguidos.ForeColor = Color.White;
                lbl_NombrePerfilGrande.ForeColor = Color.White;
                btn_escribir.ForeColor = Color.White;
            }
            else
            {
                this.BackColor = Color.FromArgb(171, 157, 250);
                //BackColor
                pcb_logo.Image = Properties.Resources.BandApp_Negro;
                btn_VolverFeed.BackColor = Color.White;
                btn_editarPerfil.BackColor = Color.White;
                btn_seguir.BackColor = Color.White;
                btn_escribir.BackColor = Color.White;

                //ForeColor
                btn_VolverFeed.ForeColor = Color.Black;
                btn_editarPerfil.ForeColor = Color.Black;
                btn_seguir.ForeColor = Color.Black;
                lbl_sexo.ForeColor = Color.Black;
                lbl_nombrePerfil.ForeColor = Color.Black;
                lbl_DescripcionUsuario.ForeColor = Color.Black;
                lbl_PublicacionesCreadas.ForeColor = Color.Black;
                lbl_InstrumentoUsuario.ForeColor = Color.Black;
                lbl_Seguidores.ForeColor = Color.Black;
                lbl_Seguidos.ForeColor = Color.Black;
                lbl_NombrePerfilGrande.ForeColor = Color.Black;
                btn_escribir.ForeColor = Color.Black;
            }
        }

        private async Task LoadUserProfile(int idUsuario)
        {
            Cuenta cuenta = new Cuenta();
            var usuario = await cuenta.ObtenerUsuarioPorId(idUsuario);
            lbl_nombrePerfil.Enabled = true;
            lbl_nombrePerfil.Visible = true;
            pcb_imagenperfil.Enabled = true;
            pcb_imagenperfil.Visible = true;

            if (usuario != null)
            {
                lbl_nombrePerfil.Text = usuario.nombre;
                if (usuario.foto_Perfil != null)
                {
                    using (var ms = new MemoryStream(usuario.foto_Perfil))
                    {
                        pcb_imagenperfil.Image = Image.FromStream(ms);
                        pcb_imagenperfil.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                }
            }
        }


        private void btn_editarPerfil_Click(object sender, EventArgs e)
        {
            Editar_Perfil Editar_PerfilForm = new Editar_Perfil(IdUsuario);
            this.Hide();
            Editar_PerfilForm.ShowDialog();
            this.Close();
        }

        private async void btn_seguir_Click(object sender, EventArgs e)
        {
            string language = Properties.Settings.Default.Language;
            var translations = LanguageManager.GetTranslations(language.ToLower());
            Interactuan interactuan = new Interactuan();
            bool yaSigue = await VerificarSiYaSigue(IdUsuario, IdUsuarioAjeno);

            if (yaSigue)
            {
                await interactuan.DejarDeSeguir(IdUsuario, IdUsuarioAjeno);
                btn_seguir.Text = translations["Seguir"];
            }
            else
            {
                await interactuan.SeguirCuenta(IdUsuario, IdUsuarioAjeno);
                btn_seguir.Text = translations["DejarSeguir"];
            }

            await UpdateSeguidoresSeguidos(IdUsuarioAjeno);
        }

        private void btn_VolverFeed_Click(object sender, EventArgs e)
        {
            Feed feedForm = new Feed(IdUsuario);
            this.Hide();
            feedForm.ShowDialog();
            this.Close();
        }

        private void btn_escribir_Click(object sender, EventArgs e)
        {
            Mensajes MensajesForm = new Mensajes(IdUsuario,IdUsuarioAjeno);
            this.Hide();
            MensajesForm.ShowDialog();
            this.Close();
        }
    }
}

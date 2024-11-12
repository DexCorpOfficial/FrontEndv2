
namespace FrontEnd
{
    partial class Feed
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Feed));
            this.lbl_nombrePerfil = new System.Windows.Forms.Label();
            this.contextMenuOpciones = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.configuracionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Mis_BandasMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_publicar = new System.Windows.Forms.Button();
            this.lbl_Descripcion_Post = new System.Windows.Forms.Label();
            this.lbl_nombre_Publicado = new System.Windows.Forms.Label();
            this.lbox_lista_Amigos = new System.Windows.Forms.ListBox();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.pcb_imagenperfil = new System.Windows.Forms.PictureBox();
            this.iconMensajes = new FontAwesome.Sharp.IconPictureBox();
            this.icon_MeGusta = new FontAwesome.Sharp.IconPictureBox();
            this.pcb_Comentarios = new System.Windows.Forms.PictureBox();
            this.iconSiguientePost = new FontAwesome.Sharp.IconPictureBox();
            this.iconPostAnterior = new FontAwesome.Sharp.IconPictureBox();
            this.pcb_foto_Publicado = new System.Windows.Forms.PictureBox();
            this.pcb_Publicacion = new System.Windows.Forms.PictureBox();
            this.icon_compartir = new FontAwesome.Sharp.IconPictureBox();
            this.pcb_busqueda = new FontAwesome.Sharp.IconPictureBox();
            this.pcb_inbox = new FontAwesome.Sharp.IconPictureBox();
            this.pcb_Menu = new System.Windows.Forms.PictureBox();
            this.pcb_logo = new System.Windows.Forms.PictureBox();
            this.pcb_fondoamigos = new FontAwesome.Sharp.IconPictureBox();
            this.contextMenuOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_imagenperfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMensajes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_MeGusta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Comentarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSiguientePost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPostAnterior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_foto_Publicado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Publicacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_compartir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_busqueda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_inbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_fondoamigos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nombrePerfil
            // 
            this.lbl_nombrePerfil.AutoEllipsis = true;
            this.lbl_nombrePerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_nombrePerfil.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombrePerfil.Location = new System.Drawing.Point(1048, 26);
            this.lbl_nombrePerfil.Name = "lbl_nombrePerfil";
            this.lbl_nombrePerfil.Size = new System.Drawing.Size(166, 47);
            this.lbl_nombrePerfil.TabIndex = 29;
            this.lbl_nombrePerfil.Text = "(Nombre______Perfil)";
            this.lbl_nombrePerfil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_nombrePerfil.Click += new System.EventHandler(this.lbl_nombrePerfil_Click);
            // 
            // contextMenuOpciones
            // 
            this.contextMenuOpciones.BackColor = System.Drawing.Color.Transparent;
            this.contextMenuOpciones.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuOpciones.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.contextMenuOpciones.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.contextMenuOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuracionMenuItem,
            this.Mis_BandasMenuItem,
            this.salirMenuItem});
            this.contextMenuOpciones.Name = "contextMenuStrip1";
            this.contextMenuOpciones.Size = new System.Drawing.Size(272, 134);
            // 
            // configuracionMenuItem
            // 
            this.configuracionMenuItem.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.configuracionMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.configuracionMenuItem.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configuracionMenuItem.ForeColor = System.Drawing.Color.White;
            this.configuracionMenuItem.Image = global::FrontEnd.Properties.Resources.TuercaConfigOscuro;
            this.configuracionMenuItem.Name = "configuracionMenuItem";
            this.configuracionMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.configuracionMenuItem.Size = new System.Drawing.Size(271, 36);
            this.configuracionMenuItem.Text = "Configuracion";
            this.configuracionMenuItem.Click += new System.EventHandler(this.configuracionMenuItem_Click);
            this.configuracionMenuItem.MouseLeave += new System.EventHandler(this.ConfiguracionMenuItem_MouseLeave);
            this.configuracionMenuItem.MouseHover += new System.EventHandler(this.ConfiguracionMenuItem_MouseHover);
            // 
            // Mis_BandasMenuItem
            // 
            this.Mis_BandasMenuItem.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.Mis_BandasMenuItem.ForeColor = System.Drawing.Color.White;
            this.Mis_BandasMenuItem.Image = global::FrontEnd.Properties.Resources.Foto_Defecto_Bandas;
            this.Mis_BandasMenuItem.Name = "Mis_BandasMenuItem";
            this.Mis_BandasMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Mis_BandasMenuItem.Size = new System.Drawing.Size(271, 36);
            this.Mis_BandasMenuItem.Text = "Mis Bandas";
            this.Mis_BandasMenuItem.Click += new System.EventHandler(this.Mis_BandasMenuItem_Click);
            this.Mis_BandasMenuItem.MouseLeave += new System.EventHandler(this.Mis_BandasMenuItem_MouseLeave);
            this.Mis_BandasMenuItem.MouseHover += new System.EventHandler(this.Mis_BandasMenuItem_MouseHover);
            // 
            // salirMenuItem
            // 
            this.salirMenuItem.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.salirMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.salirMenuItem.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salirMenuItem.ForeColor = System.Drawing.Color.White;
            this.salirMenuItem.Image = global::FrontEnd.Properties.Resources.SalirOscuro;
            this.salirMenuItem.Name = "salirMenuItem";
            this.salirMenuItem.Size = new System.Drawing.Size(271, 36);
            this.salirMenuItem.Text = "Salir";
            this.salirMenuItem.Click += new System.EventHandler(this.salirMenuItem_Click);
            this.salirMenuItem.MouseLeave += new System.EventHandler(this.SalirMenuItem_MouseLeave);
            this.salirMenuItem.MouseHover += new System.EventHandler(this.SalirMenuItem_MouseHover);
            // 
            // btn_publicar
            // 
            this.btn_publicar.BackColor = System.Drawing.Color.Black;
            this.btn_publicar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_publicar.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_publicar.FlatAppearance.BorderSize = 0;
            this.btn_publicar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_publicar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn_publicar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_publicar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_publicar.ForeColor = System.Drawing.Color.White;
            this.btn_publicar.Location = new System.Drawing.Point(483, 640);
            this.btn_publicar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_publicar.Name = "btn_publicar";
            this.btn_publicar.Size = new System.Drawing.Size(299, 32);
            this.btn_publicar.TabIndex = 38;
            this.btn_publicar.Text = "Subir Publicacion";
            this.btn_publicar.UseVisualStyleBackColor = false;
            this.btn_publicar.Click += new System.EventHandler(this.btn_publicar_Click);
            // 
            // lbl_Descripcion_Post
            // 
            this.lbl_Descripcion_Post.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Descripcion_Post.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Descripcion_Post.Location = new System.Drawing.Point(88, 539);
            this.lbl_Descripcion_Post.Name = "lbl_Descripcion_Post";
            this.lbl_Descripcion_Post.Size = new System.Drawing.Size(748, 82);
            this.lbl_Descripcion_Post.TabIndex = 39;
            this.lbl_Descripcion_Post.Text = "Descripcion...\r\n";
            // 
            // lbl_nombre_Publicado
            // 
            this.lbl_nombre_Publicado.AutoEllipsis = true;
            this.lbl_nombre_Publicado.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.lbl_nombre_Publicado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre_Publicado.Location = new System.Drawing.Point(409, 55);
            this.lbl_nombre_Publicado.Name = "lbl_nombre_Publicado";
            this.lbl_nombre_Publicado.Size = new System.Drawing.Size(166, 18);
            this.lbl_nombre_Publicado.TabIndex = 43;
            this.lbl_nombre_Publicado.Text = "(Nombre______Perfil)";
            // 
            // lbox_lista_Amigos
            // 
            this.lbox_lista_Amigos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbox_lista_Amigos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbox_lista_Amigos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbox_lista_Amigos.ForeColor = System.Drawing.Color.White;
            this.lbox_lista_Amigos.FormattingEnabled = true;
            this.lbox_lista_Amigos.ItemHeight = 18;
            this.lbox_lista_Amigos.Location = new System.Drawing.Point(986, 118);
            this.lbox_lista_Amigos.Name = "lbox_lista_Amigos";
            this.lbox_lista_Amigos.Size = new System.Drawing.Size(253, 452);
            this.lbox_lista_Amigos.TabIndex = 51;
            this.lbox_lista_Amigos.Visible = false;
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(88, 85);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(748, 30);
            this.lbl_Titulo.TabIndex = 53;
            this.lbl_Titulo.Text = "Titulo...";
            // 
            // pcb_imagenperfil
            // 
            this.pcb_imagenperfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pcb_imagenperfil.Image = global::FrontEnd.Properties.Resources.Foto_de_Perfil_Por_Defecto;
            this.pcb_imagenperfil.Location = new System.Drawing.Point(986, 26);
            this.pcb_imagenperfil.Name = "pcb_imagenperfil";
            this.pcb_imagenperfil.Size = new System.Drawing.Size(45, 47);
            this.pcb_imagenperfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_imagenperfil.TabIndex = 30;
            this.pcb_imagenperfil.TabStop = false;
            this.pcb_imagenperfil.WaitOnLoad = true;
            // 
            // iconMensajes
            // 
            this.iconMensajes.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.iconMensajes.IconChar = FontAwesome.Sharp.IconChar.Commenting;
            this.iconMensajes.IconColor = System.Drawing.Color.White;
            this.iconMensajes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMensajes.IconSize = 47;
            this.iconMensajes.Location = new System.Drawing.Point(903, 12);
            this.iconMensajes.Name = "iconMensajes";
            this.iconMensajes.Size = new System.Drawing.Size(47, 47);
            this.iconMensajes.TabIndex = 52;
            this.iconMensajes.TabStop = false;
            // 
            // icon_MeGusta
            // 
            this.icon_MeGusta.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.icon_MeGusta.IconChar = FontAwesome.Sharp.IconChar.CirclePlay;
            this.icon_MeGusta.IconColor = System.Drawing.Color.White;
            this.icon_MeGusta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icon_MeGusta.IconSize = 47;
            this.icon_MeGusta.Location = new System.Drawing.Point(138, 629);
            this.icon_MeGusta.Name = "icon_MeGusta";
            this.icon_MeGusta.Size = new System.Drawing.Size(47, 47);
            this.icon_MeGusta.TabIndex = 47;
            this.icon_MeGusta.TabStop = false;
            // 
            // pcb_Comentarios
            // 
            this.pcb_Comentarios.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.pcb_Comentarios.Image = global::FrontEnd.Properties.Resources.Comentario_Oscuro;
            this.pcb_Comentarios.Location = new System.Drawing.Point(76, 629);
            this.pcb_Comentarios.Name = "pcb_Comentarios";
            this.pcb_Comentarios.Size = new System.Drawing.Size(44, 43);
            this.pcb_Comentarios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_Comentarios.TabIndex = 46;
            this.pcb_Comentarios.TabStop = false;
            // 
            // iconSiguientePost
            // 
            this.iconSiguientePost.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.iconSiguientePost.IconChar = FontAwesome.Sharp.IconChar.ChevronDown;
            this.iconSiguientePost.IconColor = System.Drawing.Color.White;
            this.iconSiguientePost.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconSiguientePost.IconSize = 47;
            this.iconSiguientePost.Location = new System.Drawing.Point(903, 305);
            this.iconSiguientePost.Name = "iconSiguientePost";
            this.iconSiguientePost.Size = new System.Drawing.Size(47, 47);
            this.iconSiguientePost.TabIndex = 45;
            this.iconSiguientePost.TabStop = false;
            // 
            // iconPostAnterior
            // 
            this.iconPostAnterior.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.iconPostAnterior.IconChar = FontAwesome.Sharp.IconChar.ChevronUp;
            this.iconPostAnterior.IconColor = System.Drawing.Color.White;
            this.iconPostAnterior.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPostAnterior.IconSize = 47;
            this.iconPostAnterior.Location = new System.Drawing.Point(903, 252);
            this.iconPostAnterior.Name = "iconPostAnterior";
            this.iconPostAnterior.Size = new System.Drawing.Size(47, 47);
            this.iconPostAnterior.TabIndex = 44;
            this.iconPostAnterior.TabStop = false;
            // 
            // pcb_foto_Publicado
            // 
            this.pcb_foto_Publicado.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.pcb_foto_Publicado.Image = global::FrontEnd.Properties.Resources.Foto_de_Perfil_Por_Defecto;
            this.pcb_foto_Publicado.Location = new System.Drawing.Point(363, 42);
            this.pcb_foto_Publicado.Name = "pcb_foto_Publicado";
            this.pcb_foto_Publicado.Size = new System.Drawing.Size(40, 40);
            this.pcb_foto_Publicado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_foto_Publicado.TabIndex = 42;
            this.pcb_foto_Publicado.TabStop = false;
            // 
            // pcb_Publicacion
            // 
            this.pcb_Publicacion.Image = global::FrontEnd.Properties.Resources.Prueba_Tecnica_1200x900;
            this.pcb_Publicacion.Location = new System.Drawing.Point(92, 118);
            this.pcb_Publicacion.Name = "pcb_Publicacion";
            this.pcb_Publicacion.Size = new System.Drawing.Size(744, 407);
            this.pcb_Publicacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_Publicacion.TabIndex = 41;
            this.pcb_Publicacion.TabStop = false;
            // 
            // icon_compartir
            // 
            this.icon_compartir.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.icon_compartir.IconChar = FontAwesome.Sharp.IconChar.Share;
            this.icon_compartir.IconColor = System.Drawing.Color.White;
            this.icon_compartir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icon_compartir.IconSize = 47;
            this.icon_compartir.Location = new System.Drawing.Point(208, 629);
            this.icon_compartir.Name = "icon_compartir";
            this.icon_compartir.Size = new System.Drawing.Size(47, 47);
            this.icon_compartir.TabIndex = 40;
            this.icon_compartir.TabStop = false;
            // 
            // pcb_busqueda
            // 
            this.pcb_busqueda.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.pcb_busqueda.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.pcb_busqueda.IconColor = System.Drawing.Color.White;
            this.pcb_busqueda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pcb_busqueda.IconSize = 47;
            this.pcb_busqueda.Location = new System.Drawing.Point(272, 12);
            this.pcb_busqueda.Name = "pcb_busqueda";
            this.pcb_busqueda.Size = new System.Drawing.Size(47, 47);
            this.pcb_busqueda.TabIndex = 36;
            this.pcb_busqueda.TabStop = false;
            this.pcb_busqueda.Click += new System.EventHandler(this.pcb_busqueda_Click);
            // 
            // pcb_inbox
            // 
            this.pcb_inbox.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.pcb_inbox.IconChar = FontAwesome.Sharp.IconChar.Inbox;
            this.pcb_inbox.IconColor = System.Drawing.Color.White;
            this.pcb_inbox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pcb_inbox.IconSize = 47;
            this.pcb_inbox.Location = new System.Drawing.Point(172, 12);
            this.pcb_inbox.Name = "pcb_inbox";
            this.pcb_inbox.Size = new System.Drawing.Size(48, 47);
            this.pcb_inbox.TabIndex = 35;
            this.pcb_inbox.TabStop = false;
            // 
            // pcb_Menu
            // 
            this.pcb_Menu.BackColor = System.Drawing.Color.Transparent;
            this.pcb_Menu.Image = ((System.Drawing.Image)(resources.GetObject("pcb_Menu.Image")));
            this.pcb_Menu.Location = new System.Drawing.Point(226, 12);
            this.pcb_Menu.Name = "pcb_Menu";
            this.pcb_Menu.Size = new System.Drawing.Size(40, 40);
            this.pcb_Menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_Menu.TabIndex = 34;
            this.pcb_Menu.TabStop = false;
            this.pcb_Menu.Click += new System.EventHandler(this.pcb_Menu_Click);
            // 
            // pcb_logo
            // 
            this.pcb_logo.BackColor = System.Drawing.Color.Transparent;
            this.pcb_logo.Image = global::FrontEnd.Properties.Resources.BandApp_Claro;
            this.pcb_logo.Location = new System.Drawing.Point(12, 12);
            this.pcb_logo.Name = "pcb_logo";
            this.pcb_logo.Size = new System.Drawing.Size(150, 40);
            this.pcb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_logo.TabIndex = 31;
            this.pcb_logo.TabStop = false;
            // 
            // pcb_fondoamigos
            // 
            this.pcb_fondoamigos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pcb_fondoamigos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcb_fondoamigos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pcb_fondoamigos.IconChar = FontAwesome.Sharp.IconChar._0;
            this.pcb_fondoamigos.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pcb_fondoamigos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pcb_fondoamigos.IconSize = 299;
            this.pcb_fondoamigos.Location = new System.Drawing.Point(956, 12);
            this.pcb_fondoamigos.Name = "pcb_fondoamigos";
            this.pcb_fondoamigos.Size = new System.Drawing.Size(299, 609);
            this.pcb_fondoamigos.TabIndex = 37;
            this.pcb_fondoamigos.TabStop = false;
            // 
            // Feed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pcb_imagenperfil);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.iconMensajes);
            this.Controls.Add(this.lbox_lista_Amigos);
            this.Controls.Add(this.icon_MeGusta);
            this.Controls.Add(this.pcb_Comentarios);
            this.Controls.Add(this.iconSiguientePost);
            this.Controls.Add(this.iconPostAnterior);
            this.Controls.Add(this.lbl_nombre_Publicado);
            this.Controls.Add(this.pcb_foto_Publicado);
            this.Controls.Add(this.pcb_Publicacion);
            this.Controls.Add(this.icon_compartir);
            this.Controls.Add(this.lbl_Descripcion_Post);
            this.Controls.Add(this.btn_publicar);
            this.Controls.Add(this.pcb_busqueda);
            this.Controls.Add(this.pcb_inbox);
            this.Controls.Add(this.pcb_Menu);
            this.Controls.Add(this.pcb_logo);
            this.Controls.Add(this.lbl_nombrePerfil);
            this.Controls.Add(this.pcb_fondoamigos);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Feed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BandApp";
            this.contextMenuOpciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_imagenperfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMensajes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_MeGusta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Comentarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSiguientePost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPostAnterior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_foto_Publicado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Publicacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_compartir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_busqueda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_inbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_fondoamigos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_nombrePerfil;
        private System.Windows.Forms.PictureBox pcb_imagenperfil;
        private System.Windows.Forms.PictureBox pcb_logo;
        private System.Windows.Forms.PictureBox pcb_Menu;
        private System.Windows.Forms.ContextMenuStrip contextMenuOpciones;
        private System.Windows.Forms.ToolStripMenuItem configuracionMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Mis_BandasMenuItem;
        private FontAwesome.Sharp.IconPictureBox pcb_inbox;
        private FontAwesome.Sharp.IconPictureBox pcb_busqueda;
        private FontAwesome.Sharp.IconPictureBox pcb_fondoamigos;
        private System.Windows.Forms.Button btn_publicar;
        private System.Windows.Forms.Label lbl_Descripcion_Post;
        private FontAwesome.Sharp.IconPictureBox icon_compartir;
        private System.Windows.Forms.PictureBox pcb_Publicacion;
        private System.Windows.Forms.PictureBox pcb_foto_Publicado;
        private System.Windows.Forms.Label lbl_nombre_Publicado;
        private FontAwesome.Sharp.IconPictureBox iconPostAnterior;
        private FontAwesome.Sharp.IconPictureBox iconSiguientePost;
        private System.Windows.Forms.PictureBox pcb_Comentarios;
        private FontAwesome.Sharp.IconPictureBox icon_MeGusta;
        private System.Windows.Forms.ListBox lbox_lista_Amigos;
        private FontAwesome.Sharp.IconPictureBox iconMensajes;
        private System.Windows.Forms.Label lbl_Titulo;
    }
}


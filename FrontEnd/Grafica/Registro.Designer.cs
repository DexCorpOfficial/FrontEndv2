
namespace FrontEnd
{
    partial class Registro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.btn_Volver = new System.Windows.Forms.Button();
            this.cbox_idioma = new System.Windows.Forms.ComboBox();
            this.lbl_idioma = new System.Windows.Forms.Label();
            this.lbl_derechos = new System.Windows.Forms.Label();
            this.lbl_MensajeError = new System.Windows.Forms.Label();
            this.lbl_contrasenia = new System.Windows.Forms.Label();
            this.txt_contrasenia = new System.Windows.Forms.TextBox();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.lbl_confirmarcontrasenia = new System.Windows.Forms.Label();
            this.txt_confirmarcontrasenia = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_sexo = new System.Windows.Forms.Label();
            this.lbl_fechaNacimiento = new System.Windows.Forms.Label();
            this.cbox_sexo = new System.Windows.Forms.ComboBox();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.lbl_tipoCuenta = new System.Windows.Forms.Label();
            this.lbox_instrumentos = new System.Windows.Forms.ListBox();
            this.chb_Musico = new System.Windows.Forms.CheckBox();
            this.txt_busquedaInstrumento = new System.Windows.Forms.TextBox();
            this.lbl_otro = new System.Windows.Forms.Label();
            this.chb_otro = new System.Windows.Forms.CheckBox();
            this.pcb_contrasenia = new System.Windows.Forms.PictureBox();
            this.pcb_logo = new System.Windows.Forms.PictureBox();
            this.pcb_modalidad = new System.Windows.Forms.PictureBox();
            this.lbl_Foto_Perfil = new System.Windows.Forms.Label();
            this.btn_SubirFoto = new System.Windows.Forms.Button();
            this.opfdPerfil = new System.Windows.Forms.OpenFileDialog();
            this.pcb_VistaPrevia = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_contrasenia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_modalidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_VistaPrevia)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Volver
            // 
            this.btn_Volver.BackColor = System.Drawing.Color.DimGray;
            this.btn_Volver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Volver.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_Volver.FlatAppearance.BorderSize = 0;
            this.btn_Volver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_Volver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn_Volver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Volver.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Volver.ForeColor = System.Drawing.Color.White;
            this.btn_Volver.Location = new System.Drawing.Point(9, 649);
            this.btn_Volver.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(75, 23);
            this.btn_Volver.TabIndex = 5;
            this.btn_Volver.Text = "Volver";
            this.btn_Volver.UseVisualStyleBackColor = false;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // cbox_idioma
            // 
            this.cbox_idioma.BackColor = System.Drawing.Color.DimGray;
            this.cbox_idioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_idioma.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbox_idioma.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_idioma.ForeColor = System.Drawing.SystemColors.Window;
            this.cbox_idioma.FormattingEnabled = true;
            this.cbox_idioma.Items.AddRange(new object[] {
            "Español",
            "English"});
            this.cbox_idioma.Location = new System.Drawing.Point(1084, 9);
            this.cbox_idioma.Name = "cbox_idioma";
            this.cbox_idioma.Size = new System.Drawing.Size(121, 26);
            this.cbox_idioma.TabIndex = 22;
            this.cbox_idioma.SelectedIndexChanged += new System.EventHandler(this.cbox_idioma_SelectedIndexChanged);
            // 
            // lbl_idioma
            // 
            this.lbl_idioma.AutoSize = true;
            this.lbl_idioma.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idioma.Location = new System.Drawing.Point(1007, 12);
            this.lbl_idioma.Name = "lbl_idioma";
            this.lbl_idioma.Size = new System.Drawing.Size(55, 18);
            this.lbl_idioma.TabIndex = 23;
            this.lbl_idioma.Text = "Idioma";
            // 
            // lbl_derechos
            // 
            this.lbl_derechos.AutoSize = true;
            this.lbl_derechos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_derechos.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_derechos.Location = new System.Drawing.Point(0, 0);
            this.lbl_derechos.Name = "lbl_derechos";
            this.lbl_derechos.Size = new System.Drawing.Size(250, 14);
            this.lbl_derechos.TabIndex = 25;
            this.lbl_derechos.Text = "© 2024 DexCorp. Todos los derechos reservados.";
            // 
            // lbl_MensajeError
            // 
            this.lbl_MensajeError.BackColor = System.Drawing.Color.Transparent;
            this.lbl_MensajeError.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_MensajeError.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MensajeError.ForeColor = System.Drawing.Color.Red;
            this.lbl_MensajeError.Location = new System.Drawing.Point(107, 649);
            this.lbl_MensajeError.Name = "lbl_MensajeError";
            this.lbl_MensajeError.Size = new System.Drawing.Size(1098, 18);
            this.lbl_MensajeError.TabIndex = 26;
            this.lbl_MensajeError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_contrasenia
            // 
            this.lbl_contrasenia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contrasenia.Location = new System.Drawing.Point(288, 440);
            this.lbl_contrasenia.Name = "lbl_contrasenia";
            this.lbl_contrasenia.Size = new System.Drawing.Size(97, 18);
            this.lbl_contrasenia.TabIndex = 28;
            this.lbl_contrasenia.Text = "Contraseña :";
            // 
            // txt_contrasenia
            // 
            this.txt_contrasenia.BackColor = System.Drawing.Color.DimGray;
            this.txt_contrasenia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_contrasenia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contrasenia.ForeColor = System.Drawing.Color.White;
            this.txt_contrasenia.Location = new System.Drawing.Point(392, 438);
            this.txt_contrasenia.Name = "txt_contrasenia";
            this.txt_contrasenia.Size = new System.Drawing.Size(143, 26);
            this.txt_contrasenia.TabIndex = 30;
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.BackColor = System.Drawing.Color.DimGray;
            this.btn_confirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_confirmar.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_confirmar.FlatAppearance.BorderSize = 0;
            this.btn_confirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_confirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn_confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_confirmar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirmar.ForeColor = System.Drawing.Color.White;
            this.btn_confirmar.Location = new System.Drawing.Point(597, 612);
            this.btn_confirmar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(94, 27);
            this.btn_confirmar.TabIndex = 31;
            this.btn_confirmar.Text = "Confirmar";
            this.btn_confirmar.UseVisualStyleBackColor = false;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_continuar_Click);
            // 
            // lbl_confirmarcontrasenia
            // 
            this.lbl_confirmarcontrasenia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_confirmarcontrasenia.Location = new System.Drawing.Point(734, 426);
            this.lbl_confirmarcontrasenia.Name = "lbl_confirmarcontrasenia";
            this.lbl_confirmarcontrasenia.Size = new System.Drawing.Size(97, 40);
            this.lbl_confirmarcontrasenia.TabIndex = 32;
            this.lbl_confirmarcontrasenia.Text = "Confirmar\r\nContraseña :";
            // 
            // txt_confirmarcontrasenia
            // 
            this.txt_confirmarcontrasenia.BackColor = System.Drawing.Color.DimGray;
            this.txt_confirmarcontrasenia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_confirmarcontrasenia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_confirmarcontrasenia.ForeColor = System.Drawing.Color.White;
            this.txt_confirmarcontrasenia.Location = new System.Drawing.Point(858, 440);
            this.txt_confirmarcontrasenia.Name = "txt_confirmarcontrasenia";
            this.txt_confirmarcontrasenia.Size = new System.Drawing.Size(143, 26);
            this.txt_confirmarcontrasenia.TabIndex = 33;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.Location = new System.Drawing.Point(526, 393);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(94, 18);
            this.lbl_nombre.TabIndex = 34;
            this.lbl_nombre.Text = "Nombre :";
            // 
            // txt_nombre
            // 
            this.txt_nombre.AccessibleDescription = "";
            this.txt_nombre.BackColor = System.Drawing.Color.DimGray;
            this.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.ForeColor = System.Drawing.Color.White;
            this.txt_nombre.Location = new System.Drawing.Point(626, 391);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(143, 26);
            this.txt_nombre.TabIndex = 35;
            // 
            // lbl_sexo
            // 
            this.lbl_sexo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sexo.Location = new System.Drawing.Point(288, 499);
            this.lbl_sexo.Name = "lbl_sexo";
            this.lbl_sexo.Size = new System.Drawing.Size(97, 18);
            this.lbl_sexo.TabIndex = 37;
            this.lbl_sexo.Text = "Sexo :";
            // 
            // lbl_fechaNacimiento
            // 
            this.lbl_fechaNacimiento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fechaNacimiento.Location = new System.Drawing.Point(734, 487);
            this.lbl_fechaNacimiento.Name = "lbl_fechaNacimiento";
            this.lbl_fechaNacimiento.Size = new System.Drawing.Size(113, 41);
            this.lbl_fechaNacimiento.TabIndex = 39;
            this.lbl_fechaNacimiento.Text = "Fecha de\r\nNacimiento : ";
            // 
            // cbox_sexo
            // 
            this.cbox_sexo.BackColor = System.Drawing.Color.DimGray;
            this.cbox_sexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_sexo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbox_sexo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_sexo.ForeColor = System.Drawing.SystemColors.Window;
            this.cbox_sexo.FormattingEnabled = true;
            this.cbox_sexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "Otro",
            "Prefiero no decirlo"});
            this.cbox_sexo.Location = new System.Drawing.Point(392, 496);
            this.cbox_sexo.Name = "cbox_sexo";
            this.cbox_sexo.Size = new System.Drawing.Size(185, 26);
            this.cbox_sexo.TabIndex = 40;
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.CalendarFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fecha.CalendarForeColor = System.Drawing.Color.Black;
            this.dtp_fecha.CalendarMonthBackground = System.Drawing.Color.Black;
            this.dtp_fecha.CustomFormat = "";
            this.dtp_fecha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha.Location = new System.Drawing.Point(858, 496);
            this.dtp_fecha.MaxDate = new System.DateTime(2024, 8, 22, 15, 55, 15, 0);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(143, 26);
            this.dtp_fecha.TabIndex = 41;
            this.dtp_fecha.Value = new System.DateTime(2024, 8, 22, 0, 0, 0, 0);
            // 
            // lbl_tipoCuenta
            // 
            this.lbl_tipoCuenta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipoCuenta.Location = new System.Drawing.Point(734, 541);
            this.lbl_tipoCuenta.Name = "lbl_tipoCuenta";
            this.lbl_tipoCuenta.Size = new System.Drawing.Size(150, 25);
            this.lbl_tipoCuenta.TabIndex = 42;
            this.lbl_tipoCuenta.Text = "Cuenta de Musico :";
            // 
            // lbox_instrumentos
            // 
            this.lbox_instrumentos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbox_instrumentos.FormattingEnabled = true;
            this.lbox_instrumentos.ItemHeight = 18;
            this.lbox_instrumentos.Location = new System.Drawing.Point(919, 573);
            this.lbox_instrumentos.Name = "lbox_instrumentos";
            this.lbox_instrumentos.Size = new System.Drawing.Size(143, 94);
            this.lbox_instrumentos.TabIndex = 44;
            this.lbox_instrumentos.Visible = false;
            this.lbox_instrumentos.SelectedIndexChanged += new System.EventHandler(this.lbox_instrumentos_SelectedIndexChanged);
            // 
            // chb_Musico
            // 
            this.chb_Musico.AutoSize = true;
            this.chb_Musico.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_Musico.Location = new System.Drawing.Point(890, 546);
            this.chb_Musico.Name = "chb_Musico";
            this.chb_Musico.Size = new System.Drawing.Size(15, 14);
            this.chb_Musico.TabIndex = 45;
            this.chb_Musico.UseVisualStyleBackColor = true;
            this.chb_Musico.CheckedChanged += new System.EventHandler(this.chb_Musico_CheckedChanged);
            // 
            // txt_busquedaInstrumento
            // 
            this.txt_busquedaInstrumento.BackColor = System.Drawing.Color.DimGray;
            this.txt_busquedaInstrumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_busquedaInstrumento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_busquedaInstrumento.ForeColor = System.Drawing.Color.White;
            this.txt_busquedaInstrumento.Location = new System.Drawing.Point(919, 541);
            this.txt_busquedaInstrumento.Name = "txt_busquedaInstrumento";
            this.txt_busquedaInstrumento.Size = new System.Drawing.Size(143, 26);
            this.txt_busquedaInstrumento.TabIndex = 46;
            this.txt_busquedaInstrumento.Visible = false;
            // 
            // lbl_otro
            // 
            this.lbl_otro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_otro.Location = new System.Drawing.Point(1068, 541);
            this.lbl_otro.Name = "lbl_otro";
            this.lbl_otro.Size = new System.Drawing.Size(54, 25);
            this.lbl_otro.TabIndex = 47;
            this.lbl_otro.Text = "Otro:";
            this.lbl_otro.Visible = false;
            // 
            // chb_otro
            // 
            this.chb_otro.AutoSize = true;
            this.chb_otro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_otro.Location = new System.Drawing.Point(1128, 544);
            this.chb_otro.Name = "chb_otro";
            this.chb_otro.Size = new System.Drawing.Size(15, 14);
            this.chb_otro.TabIndex = 48;
            this.chb_otro.UseVisualStyleBackColor = true;
            this.chb_otro.Visible = false;
            this.chb_otro.CheckedChanged += new System.EventHandler(this.chb_otro_CheckedChanged);
            // 
            // pcb_contrasenia
            // 
            this.pcb_contrasenia.Image = global::FrontEnd.Properties.Resources.Ojo_abierto;
            this.pcb_contrasenia.Location = new System.Drawing.Point(541, 440);
            this.pcb_contrasenia.Name = "pcb_contrasenia";
            this.pcb_contrasenia.Size = new System.Drawing.Size(36, 26);
            this.pcb_contrasenia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_contrasenia.TabIndex = 36;
            this.pcb_contrasenia.TabStop = false;
            this.pcb_contrasenia.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pcb_contrasenia_MouseDown);
            this.pcb_contrasenia.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Pcb_contrasenia_MouseUp);
            // 
            // pcb_logo
            // 
            this.pcb_logo.BackColor = System.Drawing.Color.Transparent;
            this.pcb_logo.Image = ((System.Drawing.Image)(resources.GetObject("pcb_logo.Image")));
            this.pcb_logo.Location = new System.Drawing.Point(291, 12);
            this.pcb_logo.Name = "pcb_logo";
            this.pcb_logo.Size = new System.Drawing.Size(710, 345);
            this.pcb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_logo.TabIndex = 24;
            this.pcb_logo.TabStop = false;
            // 
            // pcb_modalidad
            // 
            this.pcb_modalidad.Image = ((System.Drawing.Image)(resources.GetObject("pcb_modalidad.Image")));
            this.pcb_modalidad.Location = new System.Drawing.Point(1211, 0);
            this.pcb_modalidad.Name = "pcb_modalidad";
            this.pcb_modalidad.Size = new System.Drawing.Size(47, 39);
            this.pcb_modalidad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_modalidad.TabIndex = 21;
            this.pcb_modalidad.TabStop = false;
            this.pcb_modalidad.Click += new System.EventHandler(this.pcb_modalidad_Click);
            // 
            // lbl_Foto_Perfil
            // 
            this.lbl_Foto_Perfil.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Foto_Perfil.Location = new System.Drawing.Point(276, 546);
            this.lbl_Foto_Perfil.Name = "lbl_Foto_Perfil";
            this.lbl_Foto_Perfil.Size = new System.Drawing.Size(113, 18);
            this.lbl_Foto_Perfil.TabIndex = 49;
            this.lbl_Foto_Perfil.Text = "Foto de Perfil:";
            // 
            // btn_SubirFoto
            // 
            this.btn_SubirFoto.BackColor = System.Drawing.Color.DimGray;
            this.btn_SubirFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_SubirFoto.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_SubirFoto.FlatAppearance.BorderSize = 0;
            this.btn_SubirFoto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_SubirFoto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn_SubirFoto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_SubirFoto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SubirFoto.ForeColor = System.Drawing.Color.White;
            this.btn_SubirFoto.Location = new System.Drawing.Point(392, 543);
            this.btn_SubirFoto.Margin = new System.Windows.Forms.Padding(0);
            this.btn_SubirFoto.Name = "btn_SubirFoto";
            this.btn_SubirFoto.Size = new System.Drawing.Size(185, 23);
            this.btn_SubirFoto.TabIndex = 50;
            this.btn_SubirFoto.Text = "Subir Foto";
            this.btn_SubirFoto.UseVisualStyleBackColor = false;
            this.btn_SubirFoto.Click += new System.EventHandler(this.btn_SubirFoto_Click);
            // 
            // opfdPerfil
            // 
            this.opfdPerfil.FileName = "openFileDialog1";
            // 
            // pcb_VistaPrevia
            // 
            this.pcb_VistaPrevia.Location = new System.Drawing.Point(426, 575);
            this.pcb_VistaPrevia.Name = "pcb_VistaPrevia";
            this.pcb_VistaPrevia.Size = new System.Drawing.Size(123, 94);
            this.pcb_VistaPrevia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_VistaPrevia.TabIndex = 52;
            this.pcb_VistaPrevia.TabStop = false;
            this.pcb_VistaPrevia.Visible = false;
            this.pcb_VistaPrevia.WaitOnLoad = true;
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pcb_VistaPrevia);
            this.Controls.Add(this.btn_SubirFoto);
            this.Controls.Add(this.lbl_Foto_Perfil);
            this.Controls.Add(this.chb_otro);
            this.Controls.Add(this.lbl_otro);
            this.Controls.Add(this.txt_busquedaInstrumento);
            this.Controls.Add(this.chb_Musico);
            this.Controls.Add(this.lbox_instrumentos);
            this.Controls.Add(this.lbl_tipoCuenta);
            this.Controls.Add(this.dtp_fecha);
            this.Controls.Add(this.cbox_sexo);
            this.Controls.Add(this.lbl_fechaNacimiento);
            this.Controls.Add(this.lbl_sexo);
            this.Controls.Add(this.pcb_contrasenia);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.txt_confirmarcontrasenia);
            this.Controls.Add(this.lbl_confirmarcontrasenia);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.txt_contrasenia);
            this.Controls.Add(this.lbl_contrasenia);
            this.Controls.Add(this.lbl_MensajeError);
            this.Controls.Add(this.lbl_derechos);
            this.Controls.Add(this.pcb_logo);
            this.Controls.Add(this.lbl_idioma);
            this.Controls.Add(this.cbox_idioma);
            this.Controls.Add(this.pcb_modalidad);
            this.Controls.Add(this.btn_Volver);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BandApp";
            this.Load += new System.EventHandler(this.Registro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_contrasenia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_modalidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_VistaPrevia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Volver;
        private System.Windows.Forms.PictureBox pcb_modalidad;
        private System.Windows.Forms.ComboBox cbox_idioma;
        private System.Windows.Forms.Label lbl_idioma;
        private System.Windows.Forms.PictureBox pcb_logo;
        private System.Windows.Forms.Label lbl_derechos;
        private System.Windows.Forms.Label lbl_MensajeError;
        private System.Windows.Forms.Label lbl_contrasenia;
        private System.Windows.Forms.TextBox txt_contrasenia;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.Label lbl_confirmarcontrasenia;
        private System.Windows.Forms.TextBox txt_confirmarcontrasenia;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.PictureBox pcb_contrasenia;
        private System.Windows.Forms.Label lbl_sexo;
        private System.Windows.Forms.Label lbl_fechaNacimiento;
        private System.Windows.Forms.ComboBox cbox_sexo;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.Label lbl_tipoCuenta;
        private System.Windows.Forms.ListBox lbox_instrumentos;
        private System.Windows.Forms.CheckBox chb_Musico;
        private System.Windows.Forms.TextBox txt_busquedaInstrumento;
        private System.Windows.Forms.Label lbl_otro;
        private System.Windows.Forms.CheckBox chb_otro;
        private System.Windows.Forms.Label lbl_Foto_Perfil;
        private System.Windows.Forms.Button btn_SubirFoto;
        private System.Windows.Forms.OpenFileDialog opfdPerfil;
        private System.Windows.Forms.PictureBox pcb_VistaPrevia;
    }
}
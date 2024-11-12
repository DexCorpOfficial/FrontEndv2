
namespace FrontEnd
{
    partial class Configuracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configuracion));
            this.btb_salir = new System.Windows.Forms.Button();
            this.lbl_idioma = new System.Windows.Forms.Label();
            this.cbox_idioma = new System.Windows.Forms.ComboBox();
            this.btn_cerrarsesion = new System.Windows.Forms.Button();
            this.btn_modalidad = new System.Windows.Forms.Button();
            this.pcb_modalidad = new System.Windows.Forms.PictureBox();
            this.lbl_cuenta_privada = new System.Windows.Forms.Label();
            this.chb_cuenta_Privada = new System.Windows.Forms.CheckBox();
            this.btn_cambiar_Contraseña = new System.Windows.Forms.Button();
            this.btn_eliminarCuenta = new System.Windows.Forms.Button();
            this.btn_confirmarEliminar = new System.Windows.Forms.Button();
            this.lbl_cofirmarEliminar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_modalidad)).BeginInit();
            this.SuspendLayout();
            // 
            // btb_salir
            // 
            this.btb_salir.BackColor = System.Drawing.Color.Black;
            this.btb_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btb_salir.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btb_salir.FlatAppearance.BorderSize = 0;
            this.btb_salir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btb_salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btb_salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btb_salir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btb_salir.ForeColor = System.Drawing.Color.White;
            this.btb_salir.Location = new System.Drawing.Point(9, 329);
            this.btb_salir.Margin = new System.Windows.Forms.Padding(0);
            this.btb_salir.Name = "btb_salir";
            this.btb_salir.Size = new System.Drawing.Size(75, 23);
            this.btb_salir.TabIndex = 5;
            this.btb_salir.Text = "Salir";
            this.btb_salir.UseVisualStyleBackColor = false;
            this.btb_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // lbl_idioma
            // 
            this.lbl_idioma.AutoSize = true;
            this.lbl_idioma.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idioma.Location = new System.Drawing.Point(82, 42);
            this.lbl_idioma.Name = "lbl_idioma";
            this.lbl_idioma.Size = new System.Drawing.Size(55, 18);
            this.lbl_idioma.TabIndex = 19;
            this.lbl_idioma.Text = "Idioma";
            // 
            // cbox_idioma
            // 
            this.cbox_idioma.BackColor = System.Drawing.Color.Black;
            this.cbox_idioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_idioma.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbox_idioma.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_idioma.ForeColor = System.Drawing.SystemColors.Window;
            this.cbox_idioma.FormattingEnabled = true;
            this.cbox_idioma.Items.AddRange(new object[] {
            "Español",
            "English"});
            this.cbox_idioma.Location = new System.Drawing.Point(171, 39);
            this.cbox_idioma.Name = "cbox_idioma";
            this.cbox_idioma.Size = new System.Drawing.Size(121, 26);
            this.cbox_idioma.TabIndex = 20;
            this.cbox_idioma.SelectedIndexChanged += new System.EventHandler(this.cbox_idioma_SelectedIndexChanged);
            // 
            // btn_cerrarsesion
            // 
            this.btn_cerrarsesion.BackColor = System.Drawing.Color.Black;
            this.btn_cerrarsesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_cerrarsesion.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_cerrarsesion.FlatAppearance.BorderSize = 0;
            this.btn_cerrarsesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_cerrarsesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn_cerrarsesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cerrarsesion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrarsesion.ForeColor = System.Drawing.Color.White;
            this.btn_cerrarsesion.Location = new System.Drawing.Point(74, 82);
            this.btn_cerrarsesion.Margin = new System.Windows.Forms.Padding(0);
            this.btn_cerrarsesion.Name = "btn_cerrarsesion";
            this.btn_cerrarsesion.Size = new System.Drawing.Size(231, 29);
            this.btn_cerrarsesion.TabIndex = 21;
            this.btn_cerrarsesion.Text = "Cerrar sesion y salir";
            this.btn_cerrarsesion.UseVisualStyleBackColor = false;
            this.btn_cerrarsesion.Click += new System.EventHandler(this.btn_cerrarsesion_Click);
            // 
            // btn_modalidad
            // 
            this.btn_modalidad.BackColor = System.Drawing.Color.Black;
            this.btn_modalidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_modalidad.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_modalidad.FlatAppearance.BorderSize = 0;
            this.btn_modalidad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_modalidad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn_modalidad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_modalidad.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modalidad.ForeColor = System.Drawing.Color.White;
            this.btn_modalidad.Location = new System.Drawing.Point(124, 125);
            this.btn_modalidad.Margin = new System.Windows.Forms.Padding(0);
            this.btn_modalidad.Name = "btn_modalidad";
            this.btn_modalidad.Size = new System.Drawing.Size(181, 39);
            this.btn_modalidad.TabIndex = 22;
            this.btn_modalidad.Text = "Cambiar a modo Claro";
            this.btn_modalidad.UseVisualStyleBackColor = false;
            this.btn_modalidad.Click += new System.EventHandler(this.button1_Click);
            // 
            // pcb_modalidad
            // 
            this.pcb_modalidad.Image = ((System.Drawing.Image)(resources.GetObject("pcb_modalidad.Image")));
            this.pcb_modalidad.Location = new System.Drawing.Point(74, 125);
            this.pcb_modalidad.Name = "pcb_modalidad";
            this.pcb_modalidad.Size = new System.Drawing.Size(47, 39);
            this.pcb_modalidad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_modalidad.TabIndex = 23;
            this.pcb_modalidad.TabStop = false;
            // 
            // lbl_cuenta_privada
            // 
            this.lbl_cuenta_privada.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cuenta_privada.Location = new System.Drawing.Point(118, 202);
            this.lbl_cuenta_privada.Name = "lbl_cuenta_privada";
            this.lbl_cuenta_privada.Size = new System.Drawing.Size(120, 25);
            this.lbl_cuenta_privada.TabIndex = 46;
            this.lbl_cuenta_privada.Text = "Cuenta privada:";
            // 
            // chb_cuenta_Privada
            // 
            this.chb_cuenta_Privada.AutoSize = true;
            this.chb_cuenta_Privada.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_cuenta_Privada.Location = new System.Drawing.Point(255, 205);
            this.chb_cuenta_Privada.Name = "chb_cuenta_Privada";
            this.chb_cuenta_Privada.Size = new System.Drawing.Size(15, 14);
            this.chb_cuenta_Privada.TabIndex = 49;
            this.chb_cuenta_Privada.UseVisualStyleBackColor = true;
            this.chb_cuenta_Privada.CheckedChanged += new System.EventHandler(this.chb_cuenta_Privada_CheckedChanged);
            // 
            // btn_cambiar_Contraseña
            // 
            this.btn_cambiar_Contraseña.BackColor = System.Drawing.Color.Black;
            this.btn_cambiar_Contraseña.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_cambiar_Contraseña.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_cambiar_Contraseña.FlatAppearance.BorderSize = 0;
            this.btn_cambiar_Contraseña.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_cambiar_Contraseña.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn_cambiar_Contraseña.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cambiar_Contraseña.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cambiar_Contraseña.ForeColor = System.Drawing.Color.White;
            this.btn_cambiar_Contraseña.Location = new System.Drawing.Point(121, 251);
            this.btn_cambiar_Contraseña.Margin = new System.Windows.Forms.Padding(0);
            this.btn_cambiar_Contraseña.Name = "btn_cambiar_Contraseña";
            this.btn_cambiar_Contraseña.Size = new System.Drawing.Size(149, 23);
            this.btn_cambiar_Contraseña.TabIndex = 55;
            this.btn_cambiar_Contraseña.Text = "Cambiar contraseña";
            this.btn_cambiar_Contraseña.UseVisualStyleBackColor = false;
            this.btn_cambiar_Contraseña.Click += new System.EventHandler(this.btn_cambiar_Contraseña_Click);
            // 
            // btn_eliminarCuenta
            // 
            this.btn_eliminarCuenta.BackColor = System.Drawing.Color.Black;
            this.btn_eliminarCuenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_eliminarCuenta.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_eliminarCuenta.FlatAppearance.BorderSize = 0;
            this.btn_eliminarCuenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_eliminarCuenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn_eliminarCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_eliminarCuenta.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminarCuenta.ForeColor = System.Drawing.Color.White;
            this.btn_eliminarCuenta.Location = new System.Drawing.Point(121, 294);
            this.btn_eliminarCuenta.Margin = new System.Windows.Forms.Padding(0);
            this.btn_eliminarCuenta.Name = "btn_eliminarCuenta";
            this.btn_eliminarCuenta.Size = new System.Drawing.Size(149, 23);
            this.btn_eliminarCuenta.TabIndex = 56;
            this.btn_eliminarCuenta.Text = "Eliminar Cuenta";
            this.btn_eliminarCuenta.UseVisualStyleBackColor = false;
            this.btn_eliminarCuenta.Click += new System.EventHandler(this.btn_eliminarCuenta_Click);
            // 
            // btn_confirmarEliminar
            // 
            this.btn_confirmarEliminar.BackColor = System.Drawing.Color.Black;
            this.btn_confirmarEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_confirmarEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_confirmarEliminar.FlatAppearance.BorderSize = 0;
            this.btn_confirmarEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_confirmarEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn_confirmarEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_confirmarEliminar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirmarEliminar.ForeColor = System.Drawing.Color.White;
            this.btn_confirmarEliminar.Location = new System.Drawing.Point(207, 326);
            this.btn_confirmarEliminar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_confirmarEliminar.Name = "btn_confirmarEliminar";
            this.btn_confirmarEliminar.Size = new System.Drawing.Size(46, 23);
            this.btn_confirmarEliminar.TabIndex = 57;
            this.btn_confirmarEliminar.Text = "Si";
            this.btn_confirmarEliminar.UseVisualStyleBackColor = false;
            this.btn_confirmarEliminar.Visible = false;
            this.btn_confirmarEliminar.Click += new System.EventHandler(this.btn_confirmarEliminar_Click);
            // 
            // lbl_cofirmarEliminar
            // 
            this.lbl_cofirmarEliminar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cofirmarEliminar.Location = new System.Drawing.Point(121, 327);
            this.lbl_cofirmarEliminar.Name = "lbl_cofirmarEliminar";
            this.lbl_cofirmarEliminar.Size = new System.Drawing.Size(72, 25);
            this.lbl_cofirmarEliminar.TabIndex = 58;
            this.lbl_cofirmarEliminar.Text = "Seguro?";
            this.lbl_cofirmarEliminar.Visible = false;
            // 
            // Configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.lbl_cofirmarEliminar);
            this.Controls.Add(this.btn_confirmarEliminar);
            this.Controls.Add(this.btn_eliminarCuenta);
            this.Controls.Add(this.btn_cambiar_Contraseña);
            this.Controls.Add(this.chb_cuenta_Privada);
            this.Controls.Add(this.lbl_cuenta_privada);
            this.Controls.Add(this.pcb_modalidad);
            this.Controls.Add(this.btn_modalidad);
            this.Controls.Add(this.btn_cerrarsesion);
            this.Controls.Add(this.cbox_idioma);
            this.Controls.Add(this.lbl_idioma);
            this.Controls.Add(this.btb_salir);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Configuracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuracion";
            this.Load += new System.EventHandler(this.Configuracion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_modalidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btb_salir;
        private System.Windows.Forms.Label lbl_idioma;
        private System.Windows.Forms.ComboBox cbox_idioma;
        private System.Windows.Forms.Button btn_cerrarsesion;
        private System.Windows.Forms.Button btn_modalidad;
        private System.Windows.Forms.PictureBox pcb_modalidad;
        private System.Windows.Forms.Label lbl_cuenta_privada;
        private System.Windows.Forms.CheckBox chb_cuenta_Privada;
        private System.Windows.Forms.Button btn_cambiar_Contraseña;
        private System.Windows.Forms.Button btn_eliminarCuenta;
        private System.Windows.Forms.Button btn_confirmarEliminar;
        private System.Windows.Forms.Label lbl_cofirmarEliminar;
    }
}
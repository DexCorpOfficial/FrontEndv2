
namespace FrontEnd.Grafica
{
    partial class crearBanda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(crearBanda));
            this.btn_SubirFoto = new System.Windows.Forms.Button();
            this.lbl_Foto_Perfil = new System.Windows.Forms.Label();
            this.txt_nombreBanda = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.opfdperfil = new System.Windows.Forms.OpenFileDialog();
            this.pcb_VistaPrevia = new System.Windows.Forms.PictureBox();
            this.pcb_logo = new System.Windows.Forms.PictureBox();
            this.btn_crearBanda = new System.Windows.Forms.Button();
            this.lbl_MensajeError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_VistaPrevia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_logo)).BeginInit();
            this.SuspendLayout();
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
            this.btn_SubirFoto.Location = new System.Drawing.Point(800, 447);
            this.btn_SubirFoto.Margin = new System.Windows.Forms.Padding(0);
            this.btn_SubirFoto.Name = "btn_SubirFoto";
            this.btn_SubirFoto.Size = new System.Drawing.Size(185, 23);
            this.btn_SubirFoto.TabIndex = 51;
            this.btn_SubirFoto.Text = "Subir Foto";
            this.btn_SubirFoto.UseVisualStyleBackColor = false;
            this.btn_SubirFoto.Click += new System.EventHandler(this.btn_SubirFoto_Click);
            // 
            // lbl_Foto_Perfil
            // 
            this.lbl_Foto_Perfil.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Foto_Perfil.Location = new System.Drawing.Point(684, 447);
            this.lbl_Foto_Perfil.Name = "lbl_Foto_Perfil";
            this.lbl_Foto_Perfil.Size = new System.Drawing.Size(113, 18);
            this.lbl_Foto_Perfil.TabIndex = 53;
            this.lbl_Foto_Perfil.Text = "Foto de Perfil:";
            // 
            // txt_nombreBanda
            // 
            this.txt_nombreBanda.AccessibleDescription = "";
            this.txt_nombreBanda.BackColor = System.Drawing.Color.DimGray;
            this.txt_nombreBanda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nombreBanda.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombreBanda.ForeColor = System.Drawing.Color.White;
            this.txt_nombreBanda.Location = new System.Drawing.Point(560, 381);
            this.txt_nombreBanda.Name = "txt_nombreBanda";
            this.txt_nombreBanda.Size = new System.Drawing.Size(143, 26);
            this.txt_nombreBanda.TabIndex = 56;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.Location = new System.Drawing.Point(402, 381);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(171, 18);
            this.lbl_nombre.TabIndex = 55;
            this.lbl_nombre.Text = "Nombre de la banda:";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.AccessibleDescription = "";
            this.txt_descripcion.BackColor = System.Drawing.Color.DimGray;
            this.txt_descripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_descripcion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descripcion.ForeColor = System.Drawing.Color.White;
            this.txt_descripcion.Location = new System.Drawing.Point(456, 445);
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(189, 176);
            this.txt_descripcion.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 447);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 18);
            this.label1.TabIndex = 57;
            this.label1.Text = "Descripcion de la banda:";
            // 
            // opfdperfil
            // 
            this.opfdperfil.FileName = "Subir foto";
            // 
            // pcb_VistaPrevia
            // 
            this.pcb_VistaPrevia.Location = new System.Drawing.Point(775, 489);
            this.pcb_VistaPrevia.Name = "pcb_VistaPrevia";
            this.pcb_VistaPrevia.Size = new System.Drawing.Size(242, 132);
            this.pcb_VistaPrevia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_VistaPrevia.TabIndex = 54;
            this.pcb_VistaPrevia.TabStop = false;
            this.pcb_VistaPrevia.Visible = false;
            this.pcb_VistaPrevia.WaitOnLoad = true;
            // 
            // pcb_logo
            // 
            this.pcb_logo.BackColor = System.Drawing.Color.Transparent;
            this.pcb_logo.Image = ((System.Drawing.Image)(resources.GetObject("pcb_logo.Image")));
            this.pcb_logo.Location = new System.Drawing.Point(275, 12);
            this.pcb_logo.Name = "pcb_logo";
            this.pcb_logo.Size = new System.Drawing.Size(710, 345);
            this.pcb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_logo.TabIndex = 52;
            this.pcb_logo.TabStop = false;
            // 
            // btn_crearBanda
            // 
            this.btn_crearBanda.BackColor = System.Drawing.Color.DimGray;
            this.btn_crearBanda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_crearBanda.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_crearBanda.FlatAppearance.BorderSize = 0;
            this.btn_crearBanda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_crearBanda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn_crearBanda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_crearBanda.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_crearBanda.ForeColor = System.Drawing.Color.White;
            this.btn_crearBanda.Location = new System.Drawing.Point(612, 631);
            this.btn_crearBanda.Margin = new System.Windows.Forms.Padding(0);
            this.btn_crearBanda.Name = "btn_crearBanda";
            this.btn_crearBanda.Size = new System.Drawing.Size(185, 23);
            this.btn_crearBanda.TabIndex = 59;
            this.btn_crearBanda.Text = "Crear banda";
            this.btn_crearBanda.UseVisualStyleBackColor = false;
            this.btn_crearBanda.Click += new System.EventHandler(this.btn_crearBanda_Click);
            // 
            // lbl_MensajeError
            // 
            this.lbl_MensajeError.BackColor = System.Drawing.Color.Transparent;
            this.lbl_MensajeError.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_MensajeError.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MensajeError.ForeColor = System.Drawing.Color.Red;
            this.lbl_MensajeError.Location = new System.Drawing.Point(164, 654);
            this.lbl_MensajeError.Name = "lbl_MensajeError";
            this.lbl_MensajeError.Size = new System.Drawing.Size(1098, 18);
            this.lbl_MensajeError.TabIndex = 60;
            this.lbl_MensajeError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // crearBanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.lbl_MensajeError);
            this.Controls.Add(this.btn_crearBanda);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nombreBanda);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.pcb_VistaPrevia);
            this.Controls.Add(this.lbl_Foto_Perfil);
            this.Controls.Add(this.pcb_logo);
            this.Controls.Add(this.btn_SubirFoto);
            this.Name = "crearBanda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "crearBanda";
            ((System.ComponentModel.ISupportInitialize)(this.pcb_VistaPrevia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SubirFoto;
        private System.Windows.Forms.PictureBox pcb_logo;
        private System.Windows.Forms.Label lbl_Foto_Perfil;
        private System.Windows.Forms.PictureBox pcb_VistaPrevia;
        private System.Windows.Forms.TextBox txt_nombreBanda;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog opfdperfil;
        private System.Windows.Forms.Button btn_crearBanda;
        private System.Windows.Forms.Label lbl_MensajeError;
    }
}
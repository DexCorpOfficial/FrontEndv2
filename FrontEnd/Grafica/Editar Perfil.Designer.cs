
namespace FrontEnd.Grafica
{
    partial class Editar_Perfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editar_Perfil));
            this.pcb_logo = new System.Windows.Forms.PictureBox();
            this.pcb_fotoPerfilGrande = new System.Windows.Forms.PictureBox();
            this.btn_confirmarEditar = new System.Windows.Forms.Button();
            this.btn_CancelarEditar = new System.Windows.Forms.Button();
            this.txt_NombreUsuarioEditar = new System.Windows.Forms.TextBox();
            this.txt_DescripcionEditar = new System.Windows.Forms.TextBox();
            this.opfdPerfil = new System.Windows.Forms.OpenFileDialog();
            this.pcb_busqueda = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_fotoPerfilGrande)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_busqueda)).BeginInit();
            this.SuspendLayout();
            // 
            // pcb_logo
            // 
            this.pcb_logo.BackColor = System.Drawing.Color.Transparent;
            this.pcb_logo.Image = global::FrontEnd.Properties.Resources.BandApp_Claro;
            this.pcb_logo.Location = new System.Drawing.Point(12, 12);
            this.pcb_logo.Name = "pcb_logo";
            this.pcb_logo.Size = new System.Drawing.Size(150, 40);
            this.pcb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_logo.TabIndex = 33;
            this.pcb_logo.TabStop = false;
            // 
            // pcb_fotoPerfilGrande
            // 
            this.pcb_fotoPerfilGrande.BackColor = System.Drawing.Color.Transparent;
            this.pcb_fotoPerfilGrande.Image = global::FrontEnd.Properties.Resources.Foto_de_Perfil_Por_Defecto;
            this.pcb_fotoPerfilGrande.Location = new System.Drawing.Point(49, 100);
            this.pcb_fotoPerfilGrande.Name = "pcb_fotoPerfilGrande";
            this.pcb_fotoPerfilGrande.Size = new System.Drawing.Size(142, 136);
            this.pcb_fotoPerfilGrande.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_fotoPerfilGrande.TabIndex = 36;
            this.pcb_fotoPerfilGrande.TabStop = false;
            this.pcb_fotoPerfilGrande.WaitOnLoad = true;
            // 
            // btn_confirmarEditar
            // 
            this.btn_confirmarEditar.BackColor = System.Drawing.Color.Black;
            this.btn_confirmarEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_confirmarEditar.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_confirmarEditar.FlatAppearance.BorderSize = 0;
            this.btn_confirmarEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_confirmarEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn_confirmarEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_confirmarEditar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirmarEditar.ForeColor = System.Drawing.Color.White;
            this.btn_confirmarEditar.Location = new System.Drawing.Point(975, 245);
            this.btn_confirmarEditar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_confirmarEditar.Name = "btn_confirmarEditar";
            this.btn_confirmarEditar.Size = new System.Drawing.Size(198, 43);
            this.btn_confirmarEditar.TabIndex = 44;
            this.btn_confirmarEditar.Text = "Guardar";
            this.btn_confirmarEditar.UseVisualStyleBackColor = false;
            this.btn_confirmarEditar.Click += new System.EventHandler(this.btn_confirmarEditar_Click);
            // 
            // btn_CancelarEditar
            // 
            this.btn_CancelarEditar.BackColor = System.Drawing.Color.Black;
            this.btn_CancelarEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_CancelarEditar.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_CancelarEditar.FlatAppearance.BorderSize = 0;
            this.btn_CancelarEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_CancelarEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn_CancelarEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_CancelarEditar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancelarEditar.ForeColor = System.Drawing.Color.White;
            this.btn_CancelarEditar.Location = new System.Drawing.Point(766, 245);
            this.btn_CancelarEditar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_CancelarEditar.Name = "btn_CancelarEditar";
            this.btn_CancelarEditar.Size = new System.Drawing.Size(198, 43);
            this.btn_CancelarEditar.TabIndex = 45;
            this.btn_CancelarEditar.Text = "Cancelar";
            this.btn_CancelarEditar.UseVisualStyleBackColor = false;
            this.btn_CancelarEditar.Click += new System.EventHandler(this.btn_CancelarEditar_Click);
            // 
            // txt_NombreUsuarioEditar
            // 
            this.txt_NombreUsuarioEditar.BackColor = System.Drawing.Color.Black;
            this.txt_NombreUsuarioEditar.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NombreUsuarioEditar.ForeColor = System.Drawing.Color.White;
            this.txt_NombreUsuarioEditar.Location = new System.Drawing.Point(197, 144);
            this.txt_NombreUsuarioEditar.Name = "txt_NombreUsuarioEditar";
            this.txt_NombreUsuarioEditar.Size = new System.Drawing.Size(267, 41);
            this.txt_NombreUsuarioEditar.TabIndex = 46;
            // 
            // txt_DescripcionEditar
            // 
            this.txt_DescripcionEditar.BackColor = System.Drawing.Color.Black;
            this.txt_DescripcionEditar.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DescripcionEditar.ForeColor = System.Drawing.Color.White;
            this.txt_DescripcionEditar.Location = new System.Drawing.Point(49, 313);
            this.txt_DescripcionEditar.Name = "txt_DescripcionEditar";
            this.txt_DescripcionEditar.Size = new System.Drawing.Size(1124, 41);
            this.txt_DescripcionEditar.TabIndex = 47;
            // 
            // opfdPerfil
            // 
            this.opfdPerfil.FileName = "Foto Perfil";
            // 
            // pcb_busqueda
            // 
            this.pcb_busqueda.BackColor = System.Drawing.Color.Transparent;
            this.pcb_busqueda.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            this.pcb_busqueda.IconColor = System.Drawing.Color.White;
            this.pcb_busqueda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pcb_busqueda.IconSize = 38;
            this.pcb_busqueda.Location = new System.Drawing.Point(103, 242);
            this.pcb_busqueda.Name = "pcb_busqueda";
            this.pcb_busqueda.Size = new System.Drawing.Size(38, 38);
            this.pcb_busqueda.TabIndex = 48;
            this.pcb_busqueda.TabStop = false;
            this.pcb_busqueda.Click += new System.EventHandler(this.pcb_busqueda_Click);
            // 
            // Editar_Perfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pcb_busqueda);
            this.Controls.Add(this.txt_DescripcionEditar);
            this.Controls.Add(this.txt_NombreUsuarioEditar);
            this.Controls.Add(this.btn_CancelarEditar);
            this.Controls.Add(this.btn_confirmarEditar);
            this.Controls.Add(this.pcb_logo);
            this.Controls.Add(this.pcb_fotoPerfilGrande);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Editar_Perfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BandApp";
            this.Load += new System.EventHandler(this.OnEditarPerfilLoad);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_fotoPerfilGrande)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_busqueda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcb_logo;
        private System.Windows.Forms.PictureBox pcb_fotoPerfilGrande;
        private System.Windows.Forms.Button btn_confirmarEditar;
        private System.Windows.Forms.Button btn_CancelarEditar;
        private System.Windows.Forms.TextBox txt_NombreUsuarioEditar;
        private System.Windows.Forms.TextBox txt_DescripcionEditar;
        private System.Windows.Forms.OpenFileDialog opfdPerfil;
        private FontAwesome.Sharp.IconPictureBox pcb_busqueda;
    }
}

namespace FrontEnd.Grafica
{
    partial class VerMensajeria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerMensajeria));
            this.pcb_logo = new System.Windows.Forms.PictureBox();
            this.btn_VolverFeed = new System.Windows.Forms.Button();
            this.pcb_imagenperfil = new System.Windows.Forms.PictureBox();
            this.lbl_nombrePerfil = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_imagenperfil)).BeginInit();
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
            this.pcb_logo.TabIndex = 46;
            this.pcb_logo.TabStop = false;
            // 
            // btn_VolverFeed
            // 
            this.btn_VolverFeed.BackColor = System.Drawing.Color.Black;
            this.btn_VolverFeed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_VolverFeed.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_VolverFeed.FlatAppearance.BorderSize = 0;
            this.btn_VolverFeed.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_VolverFeed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn_VolverFeed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_VolverFeed.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VolverFeed.ForeColor = System.Drawing.Color.White;
            this.btn_VolverFeed.Location = new System.Drawing.Point(184, 12);
            this.btn_VolverFeed.Margin = new System.Windows.Forms.Padding(0);
            this.btn_VolverFeed.Name = "btn_VolverFeed";
            this.btn_VolverFeed.Size = new System.Drawing.Size(135, 40);
            this.btn_VolverFeed.TabIndex = 49;
            this.btn_VolverFeed.Text = "Volver al Feed";
            this.btn_VolverFeed.UseVisualStyleBackColor = false;
            this.btn_VolverFeed.Click += new System.EventHandler(this.btn_VolverFeed_Click);
            // 
            // pcb_imagenperfil
            // 
            this.pcb_imagenperfil.BackColor = System.Drawing.Color.Transparent;
            this.pcb_imagenperfil.Image = global::FrontEnd.Properties.Resources.Foto_de_Perfil_Por_Defecto;
            this.pcb_imagenperfil.Location = new System.Drawing.Point(1035, 9);
            this.pcb_imagenperfil.Name = "pcb_imagenperfil";
            this.pcb_imagenperfil.Size = new System.Drawing.Size(45, 47);
            this.pcb_imagenperfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_imagenperfil.TabIndex = 50;
            this.pcb_imagenperfil.TabStop = false;
            this.pcb_imagenperfil.WaitOnLoad = true;
            // 
            // lbl_nombrePerfil
            // 
            this.lbl_nombrePerfil.AutoEllipsis = true;
            this.lbl_nombrePerfil.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nombrePerfil.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombrePerfil.Location = new System.Drawing.Point(1086, 9);
            this.lbl_nombrePerfil.Name = "lbl_nombrePerfil";
            this.lbl_nombrePerfil.Size = new System.Drawing.Size(166, 47);
            this.lbl_nombrePerfil.TabIndex = 51;
            this.lbl_nombrePerfil.Text = "(Nombre______Perfil)";
            this.lbl_nombrePerfil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VerMensajeria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.lbl_nombrePerfil);
            this.Controls.Add(this.pcb_imagenperfil);
            this.Controls.Add(this.btn_VolverFeed);
            this.Controls.Add(this.pcb_logo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "VerMensajeria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BandApp";
            this.Load += new System.EventHandler(this.OnVerMensajeriaLoad);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_imagenperfil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcb_logo;
        private System.Windows.Forms.Button btn_VolverFeed;
        private System.Windows.Forms.PictureBox pcb_imagenperfil;
        private System.Windows.Forms.Label lbl_nombrePerfil;
    }
}
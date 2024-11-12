
namespace FrontEnd.Grafica
{
    partial class BusquedaUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusquedaUsuarios));
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.datagrid_Busqueda = new System.Windows.Forms.DataGridView();
            this.btb_salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Busqueda)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.Black;
            this.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_buscar.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_buscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_buscar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.ForeColor = System.Drawing.Color.White;
            this.btn_buscar.Location = new System.Drawing.Point(286, 44);
            this.btn_buscar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(69, 26);
            this.btn_buscar.TabIndex = 22;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // txt_usuario
            // 
            this.txt_usuario.BackColor = System.Drawing.Color.Black;
            this.txt_usuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario.ForeColor = System.Drawing.Color.White;
            this.txt_usuario.Location = new System.Drawing.Point(9, 44);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(274, 26);
            this.txt_usuario.TabIndex = 23;
            this.txt_usuario.TextChanged += new System.EventHandler(this.txt_usuario_TextChanged);
            // 
            // datagrid_Busqueda
            // 
            this.datagrid_Busqueda.AllowUserToAddRows = false;
            this.datagrid_Busqueda.AllowUserToDeleteRows = false;
            this.datagrid_Busqueda.AllowUserToResizeColumns = false;
            this.datagrid_Busqueda.AllowUserToResizeRows = false;
            this.datagrid_Busqueda.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.datagrid_Busqueda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagrid_Busqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_Busqueda.ColumnHeadersVisible = false;
            this.datagrid_Busqueda.Location = new System.Drawing.Point(12, 76);
            this.datagrid_Busqueda.Name = "datagrid_Busqueda";
            this.datagrid_Busqueda.ReadOnly = true;
            this.datagrid_Busqueda.RowHeadersVisible = false;
            this.datagrid_Busqueda.Size = new System.Drawing.Size(343, 277);
            this.datagrid_Busqueda.TabIndex = 24;
            this.datagrid_Busqueda.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_Busqueda_CellClick);
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
            this.btb_salir.Location = new System.Drawing.Point(9, 369);
            this.btb_salir.Margin = new System.Windows.Forms.Padding(0);
            this.btb_salir.Name = "btb_salir";
            this.btb_salir.Size = new System.Drawing.Size(75, 23);
            this.btb_salir.TabIndex = 6;
            this.btb_salir.Text = "Salir";
            this.btb_salir.UseVisualStyleBackColor = false;
            this.btb_salir.Click += new System.EventHandler(this.btb_salir_Click);
            // 
            // BusquedaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(360, 401);
            this.Controls.Add(this.datagrid_Busqueda);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.btb_salir);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BusquedaUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Busqueda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.DataGridView datagrid_Busqueda;
        private System.Windows.Forms.Button btb_salir;
    }
}
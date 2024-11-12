
namespace FrontEnd.Grafica
{
    partial class Bandas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bandas));
            this.btn_buscarBanda = new System.Windows.Forms.Button();
            this.txt_bandas = new System.Windows.Forms.TextBox();
            this.datagrid_Busqueda = new System.Windows.Forms.DataGridView();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_crearBanda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Busqueda)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_buscarBanda
            // 
            this.btn_buscarBanda.BackColor = System.Drawing.Color.Black;
            this.btn_buscarBanda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_buscarBanda.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_buscarBanda.FlatAppearance.BorderSize = 0;
            this.btn_buscarBanda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_buscarBanda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn_buscarBanda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_buscarBanda.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscarBanda.ForeColor = System.Drawing.Color.White;
            this.btn_buscarBanda.Location = new System.Drawing.Point(285, 43);
            this.btn_buscarBanda.Margin = new System.Windows.Forms.Padding(0);
            this.btn_buscarBanda.Name = "btn_buscarBanda";
            this.btn_buscarBanda.Size = new System.Drawing.Size(69, 26);
            this.btn_buscarBanda.TabIndex = 23;
            this.btn_buscarBanda.Text = "Buscar";
            this.btn_buscarBanda.UseVisualStyleBackColor = false;
            this.btn_buscarBanda.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // txt_bandas
            // 
            this.txt_bandas.BackColor = System.Drawing.Color.Black;
            this.txt_bandas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bandas.ForeColor = System.Drawing.Color.White;
            this.txt_bandas.Location = new System.Drawing.Point(9, 43);
            this.txt_bandas.Name = "txt_bandas";
            this.txt_bandas.Size = new System.Drawing.Size(274, 26);
            this.txt_bandas.TabIndex = 24;
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
            this.datagrid_Busqueda.Location = new System.Drawing.Point(9, 72);
            this.datagrid_Busqueda.Name = "datagrid_Busqueda";
            this.datagrid_Busqueda.ReadOnly = true;
            this.datagrid_Busqueda.RowHeadersVisible = false;
            this.datagrid_Busqueda.RowHeadersWidth = 62;
            this.datagrid_Busqueda.Size = new System.Drawing.Size(343, 277);
            this.datagrid_Busqueda.TabIndex = 25;
            this.datagrid_Busqueda.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_Busqueda_CellClick);
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.Black;
            this.btn_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_salir.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_salir.FlatAppearance.BorderSize = 0;
            this.btn_salir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_salir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.ForeColor = System.Drawing.Color.White;
            this.btn_salir.Location = new System.Drawing.Point(9, 372);
            this.btn_salir.Margin = new System.Windows.Forms.Padding(0);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 26;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_crearBanda
            // 
            this.btn_crearBanda.BackColor = System.Drawing.Color.Black;
            this.btn_crearBanda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_crearBanda.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_crearBanda.FlatAppearance.BorderSize = 0;
            this.btn_crearBanda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_crearBanda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn_crearBanda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_crearBanda.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_crearBanda.ForeColor = System.Drawing.Color.White;
            this.btn_crearBanda.Location = new System.Drawing.Point(250, 372);
            this.btn_crearBanda.Margin = new System.Windows.Forms.Padding(0);
            this.btn_crearBanda.Name = "btn_crearBanda";
            this.btn_crearBanda.Size = new System.Drawing.Size(101, 23);
            this.btn_crearBanda.TabIndex = 27;
            this.btn_crearBanda.Text = "Crear Banda";
            this.btn_crearBanda.UseVisualStyleBackColor = false;
            this.btn_crearBanda.Click += new System.EventHandler(this.btn_crearBanda_Click);
            // 
            // Bandas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(372, 404);
            this.Controls.Add(this.btn_crearBanda);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.datagrid_Busqueda);
            this.Controls.Add(this.txt_bandas);
            this.Controls.Add(this.btn_buscarBanda);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Bandas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bandas";
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Busqueda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_buscarBanda;
        private System.Windows.Forms.TextBox txt_bandas;
        private System.Windows.Forms.DataGridView datagrid_Busqueda;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_crearBanda;
    }
}
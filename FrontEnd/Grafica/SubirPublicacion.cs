using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEnd.Grafica
{
    public partial class SubirPublicacion : Form
    {
        public SubirPublicacion()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ControlBox = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void btb_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

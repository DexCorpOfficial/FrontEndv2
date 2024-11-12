using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEnd
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Verificar si hay un UserId guardado
            int userId = Properties.Settings.Default.UserId;

            if (userId != 0) // Si hay un UserId guardado, redirigir al Feed
            {
                Feed feedForm = new Feed(userId);
                Application.Run(feedForm);
            }
            else // Si no hay UserId, mostrar el Login
            {
                Login loginForm = new Login();
                Application.Run(loginForm);
            }
        }
    }
}

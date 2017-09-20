using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NutrySAT
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

            Splash splash = new Splash();
            splash.ShowDialog();

            if (splash.DialogResult == DialogResult.OK)
            {
                Login login = new Login();
                login.ShowDialog();
                if (login.DialogResult == DialogResult.OK)
                {
                    //Application.Run(new Main(login.getUserAdmin()));
                }
            }

            Application.Run(new Main());
        }
    }
}

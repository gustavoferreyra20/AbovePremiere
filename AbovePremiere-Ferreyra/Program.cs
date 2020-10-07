using AbovePremiere_Ferreyra.DAOs;
using System;
using System.Windows.Forms;

namespace AbovePremiere_Ferreyra
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            UsuariosDAO.iniciar();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}

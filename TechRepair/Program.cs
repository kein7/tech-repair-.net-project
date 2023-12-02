using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechRepair.Models;
using TechRepair.Presenters;
using TechRepair._Repositories;
using TechRepair.Views;
using System.Configuration;
using ModernGUI;

namespace TechRepair
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string sqlConnectionString = ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;
            /*
            ISistemaNegocioForm sistemaNegocioForm = new SistemaNegocioForm();
            new SistemaNegocioPresenter(sistemaNegocioForm, sqlConnectionString);
            Application.Run((Form)sistemaNegocioForm);
            */

            /*
            ISistemaAtencionForm sistemaAtencionForm = new SistemaAtencionForm();
            new SistemaAtencionPresenter(sistemaAtencionForm, sqlConnectionString);
            Application.Run((Form)sistemaAtencionForm);
            */

            ILoginForm loginForm = new LoginForm();
            ILoginRepository loginRepository = new LoginRepository(sqlConnectionString);
            new LoginPresenter(loginForm, loginRepository, sqlConnectionString); 

            Application.Run((Form)loginForm);
            
        }
    }
}

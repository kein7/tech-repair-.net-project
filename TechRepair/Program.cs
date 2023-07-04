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
            IPrincipalForm principalForm = new PrincipalForm();

            new PrincipalPresenter(principalForm, sqlConnectionString);
            Application.Run((Form)principalForm);
        }
    }
}

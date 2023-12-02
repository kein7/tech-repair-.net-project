using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechRepair.Views;
using TechRepair._Repositories;
using TechRepair.Models;
using TechRepair.Presenters.Common;
using System.Windows.Forms;
using Microsoft.VisualBasic.PowerPacks.Printing;
using ModernGUI;

namespace TechRepair.Presenters
{
    public class MainPresenter
    {
        private IMainForm mainForm;
        private readonly string sqlConnectionString;
        

        public MainPresenter(IMainForm mainForm, string sqlConnectionString)
        {
            this.mainForm = mainForm;
            this.sqlConnectionString = sqlConnectionString;
            this.mainForm.ShowOrdenesForm += ShowOrdenesForm;
            this.mainForm.ShowPlanesForm += ShowPlanesForm;
            this.mainForm.ShowAdminUsuariosForm += ShowAdminUsuariosForm;
            this.mainForm.ShowProfileForm += ShowProfileForm;
        }

        private void ShowProfileForm(object sender, EventArgs e)
        {
            IProfileForm view = ProfileForm.GetInstance((MainForm)mainForm);
            IAdmUsuariosRepository repository = new AdmUsuariosRepository(sqlConnectionString);
            new ProfilePresenter(view, repository);
        }

        private void ShowAdminUsuariosForm(object sender, EventArgs e)
        {
            IAdminUsuariosForm view = AdminUsuariosForm.GetInstance((MainForm)mainForm);
            IAdmUsuariosRepository repository = new AdmUsuariosRepository(sqlConnectionString);
            ITecnicosRepository tecnicosRepository = new TecnicosRepository(sqlConnectionString);
            new AdmUsuariosPresenter(view, repository, tecnicosRepository);
        }

        private void ShowPlanesForm(object sender, EventArgs e)
        {
            IPlanesRepForm view = PlanesRepForm.GetInstance((MainForm)mainForm);
            //IPlanesRepForm view = new PlanesRepForm();
            IPlanesRepRepository repository = new PlanesRepRepository(sqlConnectionString);
            IGamasRepository repositoryGamas = new GamasRepository(sqlConnectionString);
            new PlanesRepPresenter(view, repository, repositoryGamas);
        }
        private void ShowOrdenesForm(object sender, EventArgs e)
        {
            IOrdenesForm view = OrdenesForm.GetInstance((MainForm)mainForm);
            //IPlanesRepForm view = new PlanesRepForm();
            //IPlanesRepRepository repository = new PlanesRepRepository(sqlConnectionString);
            IOrdenesRepository repository = new OrdenesRepository(sqlConnectionString);
            IGamasRepository repositoryGamas = new GamasRepository(sqlConnectionString);
            IEquiposCelularesRepository repositoryEquipos = new EquiposCelularesRepository(sqlConnectionString);
            IPlanesRepRepository repositoryPlanes = new PlanesRepRepository(sqlConnectionString);
            IClientesRepository repositoryClientes = new ClientesRepository(sqlConnectionString);
            IDireccionesRepository repositoryDirecciones = new DireccionesRepository(sqlConnectionString);
            ITercerosRepository repositoryTerceros = new TercerosRepository(sqlConnectionString);
            ITecnicosRepository repositoryTecnicos = new TecnicosRepository(sqlConnectionString);

            new OrdenesPresenter(view, repository, repositoryGamas, repositoryEquipos, repositoryPlanes, repositoryClientes, repositoryDirecciones, repositoryTerceros, repositoryTecnicos);
        }
    }
}

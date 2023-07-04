using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechRepair.Models;
using TechRepair._Repositories;
using TechRepair.Views;
using System.Windows.Forms;

namespace TechRepair.Presenters
{
    public class PrincipalPresenter
    {
        private IPrincipalForm principalForm;
        private readonly string sqlConnectionString;

        public PrincipalPresenter(IPrincipalForm principalForm, string sqlConnectionString)
        {
            this.principalForm = principalForm;
            this.sqlConnectionString = sqlConnectionString;
            this.principalForm.ShowPlanesForm += ShowPlanesForm;
        }
        private void ShowPlanesForm(object sender, EventArgs e)
        {
            IPlanesRepForm view = PlanesRepForm.GetInstance((PrincipalForm)principalForm);
            //IPlanesRepForm view = new PlanesRepForm();
            IPlanesRepRepository repository = new PlanesRepRepository(sqlConnectionString);
            new PlanesRepPresenter(view, repository);
        }
    }
}

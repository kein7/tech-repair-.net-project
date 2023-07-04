using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechRepair.Views
{
    public interface IPrincipalForm
    {
        event EventHandler ShowPlanesForm;
        event EventHandler ShowAdminUsuariosForm;
        event EventHandler ShowEquiposCelularesForm;
        event EventHandler ShowSistemaAtencionForm;

        void ShowChildFormInPanel(PlanesRepForm childForm);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechRepair.Views
{
    public interface ISistemaNegocioForm
    {
        event EventHandler ShowPlanesForm;
        event EventHandler ShowAdminUsuariosForm;

        void ShowPlanesFormInPanel(PlanesRepForm childForm);
    }
}

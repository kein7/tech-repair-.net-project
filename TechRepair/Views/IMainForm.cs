using ModernGUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechRepair.Views
{
    public interface IMainForm
    {
        event EventHandler ShowOrdenesForm;
        event EventHandler ShowClientesForm;
        event EventHandler ShowPlanesForm;
        event EventHandler ShowAdminUsuariosForm;
        event EventHandler ShowProfileForm;

        void ShowOrdenesFormInPanel(OrdenesForm childForm);
        void ShowPlanesFormInPanel(PlanesRepForm childForm);
        void ShowAdminUsuariosFormInPanel(AdminUsuariosForm childForm);
        void ShowProfileFormInPanel(ProfileForm childForm);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechRepair.Views
{
    public interface ISistemaAtencionForm
    {
        event EventHandler ShowOrdenesForm;
        event EventHandler ShowClientesForm;

        void ShowOrdenesFormInPanel(OrdenesForm childForm);
    }
}

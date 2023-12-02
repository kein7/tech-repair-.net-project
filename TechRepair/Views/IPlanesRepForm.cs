using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechRepair.Models;

namespace TechRepair.Views
{
    public interface IPlanesRepForm
    {
        string PlanId { get; set; }
        string PlanReparacion { get; set; }
        string PlanValor { get; set; }
        string PlanEstado { get; set; }
        string PlazoEntrega { get; set; }
        string Gama { get; set; }

        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSucessfull { get; set; }
        string Message { get; set; }

        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler DeleteEvent;
        event EventHandler EditEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        void SetPlanesListBindingSource(BindingSource planesList);
        void Show();
    }
}

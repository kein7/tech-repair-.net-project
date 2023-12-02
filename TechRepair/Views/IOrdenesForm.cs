using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechRepair
{
    public interface IOrdenesForm
    {
        string OrdenId { get; set; }
        string Marca { get; set; }
        string Gama { get; set; }
        string PlanReparacion { get; set; }
        string NumSerie { get; set; }
        string Modelo { get; set; }
        string Color { get; set; }

        string RutCliente { get; set; }
        string NombresCliente { get; set; }
        string ApellidoPatCliente { get; set; }
        string ApellidoMatCliente { get; set; }
        string NumTelefonoCliente { get; set; }
        string EmailCliente { get; set; }
        string DireccionId { get; set; }
        string DireccionCliente { get; set; }
        string ComunaCliente { get; set; }
        string RegionCliente { get; set; }
        string NumCalleCliente { get; set; }
        string NumDptoCliente { get; set; }

        string RutTercero { get; set; }
        string NombresTercero { get; set; }
        string ApellidoPatTercero { get; set; }
        string ApellidoMatTercero { get; set; }
        string CodigoTercero { get; set; }

        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSucessfull { get; set; }
        string Message { get; set; }

        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler DeleteEvent;
        event EventHandler EditEvent;
        event EventHandler SaveEvent;
        event EventHandler RefreshRegionCbx;

        void SetRegionesListBindingSource(BindingSource regionesList);
        void SetOrdenesListBindingSource(BindingSource ordenesList);
        void Show();
    }
}

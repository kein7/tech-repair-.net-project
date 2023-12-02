using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechRepair.Views
{
    public interface IAdminUsuariosForm
    {
        string ModificarCargo { get; set; }
        string CargoActual { get; set; }
        string UsuarioCargo { get; set; }
        string Usuario { get; set; }
        string PasswordUsuario { get; set; }
        string NombreUsuario { get; set; }
        string ApellidoPaternoUsuario { get; set; }
        string ApellidoMaternoUsuario { get; set; }
        string EmailUsuario { get; set; }
        string UsuarioTecnico { get; set; }
        string PasswordTecnico { get; set; }
        string NombreTecnico { get; set; }
        string ApellidoPaternoTecnico { get; set; }      
        string ApellidoMaternoTecnico { get; set; }
        string RutTecnico { get; set; }
        string TelefonoTecnico { get; set; }
        string EmailTecnico { get; set; }
        string Cargo { get; set; }


        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSucessfull { get; set; }
        string Message { get; set; }

        void Show();
        void SetUsuariosListBindingSource(BindingSource usuariosList);

        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler DeleteEvent;
        event EventHandler EditEvent;
        event EventHandler SaveCargoEvent;
        event EventHandler SaveUsuarioEvent;
        event EventHandler SaveTecnicoEvent;
    }
}

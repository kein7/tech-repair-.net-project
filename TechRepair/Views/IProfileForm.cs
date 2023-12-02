using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechRepair.Views
{
    public interface IProfileForm
    {
        string UsuarioLb { get; set; }
        string NombreLb { get; set; }
        string ApellidoLb { get; set; }
        string CargoLb { get; set; }
        string UsuarioId { get; set; }
        string Usuario { get; set; }
        string Password { get; set; }
        string ConfirmarPass { get; set; }
        string PassActual {  get; set; }
        string Nombre { get; set; }
        string ApellidoPaterno {  get; set; }
        string ApellidoMaterno {  get; set; }
        string Email {  get; set; }

        bool IsEdit { get; set; }
        bool IsSucessfull { get; set; }
        string Message { get; set; }
        bool ActualizaContra { get; set; }

        event EventHandler EditEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        void Show();
    }
}

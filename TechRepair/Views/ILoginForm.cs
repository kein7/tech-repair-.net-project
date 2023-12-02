using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechRepair.Views
{
    public interface ILoginForm
    {

        string Usuario { get; set; }
        string Password { get; set; }
        string MessageError { get; set; }
        bool IsSucessfull { get; set; }
        string Message { get; set; }

        event EventHandler ValidateLoginEvent;
        event EventHandler RecoverPassEvent;
        
        void Show();
        void Hide();
        void SetFocusToUsername();
        void SetDefaultPasswordTextbox();
        void LogOut();
    }
}

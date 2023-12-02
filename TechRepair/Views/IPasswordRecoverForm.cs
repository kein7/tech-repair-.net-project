using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechRepair.Views
{
    public interface IPasswordRecoverForm
    {
        string userOrEmail { get; set; }
        string result { get; set; }

        event EventHandler RecoverPasswordEvent;
        void Show();
    }
}

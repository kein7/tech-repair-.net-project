using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechRepair.Models
{
    public interface ILoginRepository
    {
        bool ValidateLogin(string username, string password);
        string recoverPassword(string userRequesting);
    }
}

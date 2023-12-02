using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechRepair.Models
{
    public interface IAdmUsuariosRepository
    {
        void AddUser(AdmUsuariosModel admUsuariosModel);
        void EditUser(AdmUsuariosModel admUsuariosModel);
        void EditUserCargo(AdmUsuarios2Model admUsuariosModel);
        void DeleteUser(int value);
        bool ValidatePassword(int userId, string password);
        IEnumerable<AdmUsuarios2Model> GetAllUsuarios();
        IEnumerable<AdmUsuarios2Model> GetByValueUsuario(string value);
    }
}

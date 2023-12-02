using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechRepair.Models
{
    public interface IClientesRepository
    {
        void Add(ClientesModel clientesModel);
        void Edit(ClientesModel clientesModel);
        void Delete(int cliente_id);
        IEnumerable<ClientesModel> GetAllClientes();
        IEnumerable<ClientesModel> GetByValueClientes(string value);
    }
}

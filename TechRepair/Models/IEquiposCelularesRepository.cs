using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechRepair.Models
{
    public interface IEquiposCelularesRepository
    {
        void Add(EquiposCelularesModel equiposCelularesModel);
        void Edit(EquiposCelularesModel equiposCelularesModel);
        void Delete(int telefonos_id);
        IEnumerable<EquiposCelularesModel> GetAllTelefonos();
        IEnumerable<EquiposCelularesModel> GetByValueTelefonos(string value);

        IEnumerable<EquiposCelularesModel> GetMarcaTelefono(string value);
    }
}

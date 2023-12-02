using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechRepair.Models
{
    public interface IDireccionesRepository
    {
        int Add(DireccionesModel direccionesModel);
        void Edit(DireccionesModel direccionesModel);
        void Delete(int planes_id);
        IEnumerable<DireccionesModel> GetAllDirecciones();
        IEnumerable<DireccionesModel> GetByValueDirecciones(string value);
        IEnumerable<DireccionesModel> GetComunaId(string value1, string value2);
        List<string> GetRegionByComuna(string value);
        List<string> GetRegiones(string value);
    }
}

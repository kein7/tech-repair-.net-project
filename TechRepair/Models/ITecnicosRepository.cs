using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechRepair.Models
{
    public interface ITecnicosRepository
    {
        void Add(TecnicosModel tecnicosModel);
        void Edit(TecnicosModel tecnicosModel);
        void Delete(int tecnicos_id);
        int GetTecnicoId(string email);
        IEnumerable<TecnicosModel> GetByValueTecnicos(string value);
        //IEnumerable<TecnicosModel> GetAllTecnicos();
    }
}

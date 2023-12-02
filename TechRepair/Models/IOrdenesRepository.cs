using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechRepair.Models
{
    public interface IOrdenesRepository
    {
        void Add(OrdenesModel ordenesModel);
        void Edit(OrdenesModel ordenesModel);
        void Delete(int orden_id);
        IEnumerable<OrdenesModel> GetAllOrdenes();
        IEnumerable<OrdenesModel> GetByValueOrdenes(string value);
        IEnumerable<OrdenesModel> GetByValueIdOrdenes(string value);
    }
}

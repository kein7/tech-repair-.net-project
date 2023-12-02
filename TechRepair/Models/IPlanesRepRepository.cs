using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechRepair.Models
{
    public interface IPlanesRepRepository
    {
        void Add(PlanesRepModel planesRepModel);
        void Edit(PlanesRepModel planesRepModel);
        void Delete(int planes_id);
        IEnumerable<PlanesRepModel> GetAllPlanes();
        IEnumerable<PlanesRepModel> GetByValuePlanes(string value);

        IEnumerable<PlanesRepModel> GetPlanId(string planReparacion, string gama);
    }
}

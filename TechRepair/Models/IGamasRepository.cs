using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechRepair.Models
{
    public interface IGamasRepository
    {
        IEnumerable<GamasModel> GetAllGamas();
        IEnumerable<GamasModel> GetByValueGamas(string value);
    }
}

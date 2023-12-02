using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechRepair.Models
{
    public interface ITercerosRepository
    {
        void Add(TercerosModel tercerosModel);
        void Edit(TercerosModel tercerosModel);
        void Delete(int value);
        IEnumerable<TercerosModel> GetAllTerceros();
        IEnumerable<TercerosModel> GetByValueTerceros(string value);

    }
}

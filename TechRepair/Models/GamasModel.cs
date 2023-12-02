using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechRepair.Models
{
    public class GamasModel
    {
        private int gama_id;
        private string tipo_gama;

        public int Gama_ID { get => gama_id; set => gama_id = value; }
        public string Tipo_Gama { get => tipo_gama; set => tipo_gama = value; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechRepair.Models
{
    public class PlanesRepModel
    {
        private int plan_id;
        private string plan_reparacion;
        private int valor_plan;
        private string estado_plan;
        private int plazo_entrega;
        private int gama_id;

        [DisplayName("Plan ID")]
        public int Plan_id { get => plan_id; set => plan_id = value; }

        [DisplayName("Nombre del Plan")]
        [Required(ErrorMessage = "El nombre del plan es requerido")]
        [StringLength(70, MinimumLength = 5, ErrorMessage = "El campo debe tener entre 5 y 70 caracteres")]
        public string Plan_reparacion { get => plan_reparacion; set => plan_reparacion = value; }

        [DisplayName("Valor del Plan")]
        public int Valor_plan { get => valor_plan; set => valor_plan = value; }

        [DisplayName("Estado del Plan")]
        public string Estado_plan { get => estado_plan; set => estado_plan = value; }

        [DisplayName("Plazo de entrega")]
        public int Plazo_entrega { get => plazo_entrega; set => plazo_entrega = value; }

        [DisplayName("Gama ID")]
        public int Gama_id { get => gama_id; set => gama_id = value; }
    }
}

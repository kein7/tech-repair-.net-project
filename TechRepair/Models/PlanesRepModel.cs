using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechRepair._Repositories;

namespace TechRepair.Models
{
    public class PlanesRepModel
    {
        private int plan_id;
        private string plan_reparacion;
        private int valor_plan;
        private string estado_plan;
        private int plazo_entrega;
        private string gama_planes;
        

        [DisplayName("Plan ID")]
        public int Plan_id { get => plan_id; set => plan_id = value; }

        [DisplayName("Nombre del Plan")]
        [Required(ErrorMessage = "El nombre del plan es requerido")]
        [StringLength(70, MinimumLength = 5, ErrorMessage = "El campo debe tener entre 5 y 70 caracteres")]
        public string Plan_reparacion { get => plan_reparacion; set => plan_reparacion = value; }

        [DisplayName("Valor del Plan")]
        [Required(ErrorMessage = "El valor del plan es requerido")]
        public int Valor_plan { get => valor_plan; set => valor_plan = value; }

        [DisplayName("Estado del Plan")]
        [Required(ErrorMessage = "El estado del plan es requerido")]
        public string Estado_plan { get => estado_plan; set => estado_plan = value; }

        [DisplayName("Plazo de entrega")]
        [Required(ErrorMessage = "El plazo de entrega es requerido")]
        public int Plazo_entrega { get => plazo_entrega; set => plazo_entrega = value; }

        [DisplayName("Nombre de la Gama")]
        [Required(ErrorMessage = "El nombre de la gama es requerido")]
        public string Gama { get => gama_planes; set => gama_planes = value; }

       
    }
}


    

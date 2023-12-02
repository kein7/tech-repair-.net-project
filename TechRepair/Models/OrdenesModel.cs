using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechRepair.Models
{
    public class OrdenesModel
    {
        private int orden_id;
        private string tecnico;
        private string estado;
        private string telefono;
        private string gama;
        private string cliente;
        private string plan;
        private string tercero;
        private string fecha_orden;


        [DisplayName("Orden ID")]
        public int Orden_id { get => orden_id; set => orden_id = value; }

        [DisplayName("Nombre del tecnico")]
        [Required(ErrorMessage = "El id del tecnico es requerido")]
        public string Tecnico { get => tecnico; set => tecnico = value; }

        [DisplayName("Estado de la orden")]
        [Required(ErrorMessage = "El estado de la orden es requerido")]
        public string Estado { get => estado; set => estado = value; }

        [DisplayName("Telefono")]
        [Required(ErrorMessage = "El telefono es requerido")]
        public string Telefono { get => telefono; set => telefono = value; }

        [DisplayName("Gama")]
        public string Gama { get => gama; set => gama = value; }

        [DisplayName("Cliente")]
        [Required(ErrorMessage = "El cliente es requerido")]
        public string Cliente { get => cliente; set => cliente = value; }

        [DisplayName("Plan")]
        [Required(ErrorMessage = "El plan es requerido")]
        public string Plan { get => plan; set => plan = value; }

        [DisplayName("Tercero")]
        [Required(ErrorMessage = "El tercero es requerido")]
        public string Tercero { get => tercero; set => tercero = value; }

        [DisplayName("Fecha de la orden")]
        [Required(ErrorMessage = "La fecha de la orden es requerida")]
        public string Fecha_orden { get => fecha_orden; set => fecha_orden = value; }

    }
}

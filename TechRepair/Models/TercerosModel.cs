using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechRepair.Models
{
    public class TercerosModel
    {
        private int tercero_id;
        private string codigo_tercero;
        private string nombres;
        private string apellido_pat;
        private string apellido_mat;
        private int rut_tercero;


        [DisplayName("Tercero ID")]
        public int Tercero_id { get => tercero_id; set => tercero_id = value; }

        [DisplayName("Codigo del tercero")]
        [Required(ErrorMessage = "El codigo del terceri es requerido")]
        [StringLength(70, MinimumLength = 5, ErrorMessage = "El campo debe tener entre 5 y 70 caracteres")]
        public string Codigo_tercero { get => codigo_tercero; set => codigo_tercero = value; }

        [DisplayName("Nombres del tercero")]
        [Required(ErrorMessage = "El nombre del tercero es requerido")]
        public string Nombres_tercero { get => nombres; set => nombres = value; }

        [DisplayName("Apellido Paterno del tercero")]
        [Required(ErrorMessage = "El apellido paterno es requerido")]
        public string Apellido_paterno { get => apellido_pat; set => apellido_pat = value; }

        [DisplayName("Apellido Materno del tercero")]
        [Required(ErrorMessage = "El apellido materno es requerido")]
        public string Apellido_materno { get => apellido_mat; set => apellido_mat = value; }

        [DisplayName("Rut del tercero")]
        [Required(ErrorMessage = "El rut del tercero es requerido")]
        public int Rut_tercero { get => rut_tercero; set => rut_tercero = value; }
    }
}

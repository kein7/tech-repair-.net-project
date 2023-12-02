using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechRepair.Models
{
    public class TecnicosModel
    {
        private int tecnicos_id;
        private string nombres;
        private string apellido_pat;
        private string apellido_mat;
        private int rut_tecnico;
        private string email;
        private int telefono;

        [DisplayName("Plan ID")]
        public int Tecnicos_id { get => tecnicos_id; set => tecnicos_id = value; }

        [DisplayName("Nombre del tecnico")]
        [Required(ErrorMessage = "El nombre del tecnico es requerido")]
        [StringLength(70, MinimumLength = 5, ErrorMessage = "El campo debe tener entre 5 y 70 caracteres")]
        public string Nombres { get => nombres; set => nombres = value; }

        [DisplayName("Apellido paterno del tecnico")]
        [Required(ErrorMessage = "El apellido paterno del tecnico es requerido")]
        public string Apellido_paterno { get => apellido_pat; set => apellido_pat = value; }

        [DisplayName("Apellido materno del tecnico")]
        [Required(ErrorMessage = "El apellido materno del tecnico es requerido")]
        public string Apellido_materno { get => apellido_mat; set => apellido_mat = value; }

        [DisplayName("Rut del tecnico")]
        [Required(ErrorMessage = "El rut del tecnico es requerido")]
        public int Rut_tecnico { get => rut_tecnico; set => rut_tecnico = value; }

        [DisplayName("Email del tecnico")]
        [Required(ErrorMessage = "El email del tecnico es requerido")]
        public string Email { get => email; set => email = value; }
        [DisplayName("Email del tecnico")]
        [Required(ErrorMessage = "El email del tecnico es requerido")]
        public int Telefono { get => telefono; set => telefono = value; }

    }
}

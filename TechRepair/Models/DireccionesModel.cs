using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechRepair.Models
{
    public class DireccionesModel
    {
        private int direccion_id;
        private string calle;
        private string num_calle;
        private string num_dpto;
        private string comuna;
        private string region;

        [DisplayName("Direccion ID")]
        public int Direccion_id { get => direccion_id; set => direccion_id = value; }

        [DisplayName("Nombre Calle")]
        [Required(ErrorMessage = "El nombre de la calle es requerida")]
        public string Calle { get => calle; set => calle = value; }

        [DisplayName("Numero de calle")]
        [Required(ErrorMessage = "El numero de calle es requerido")]
        public string Num_calle { get => num_calle; set => num_calle = value; }

        [DisplayName("Numero de departamento")]
        public string Num_dpto { get => num_dpto; set => num_dpto = value; }

        [DisplayName("Nombre de la comuna")]
        [Required(ErrorMessage = "El nombre de la comuna es requerido")]
        public string Comuna { get => comuna; set => comuna = value; }

        [DisplayName("Region")]
        [Required(ErrorMessage = "La region es requerida")]
        public string Region { get => region; set => region = value; }
    }
}

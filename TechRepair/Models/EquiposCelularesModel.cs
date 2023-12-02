using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechRepair.Models
{
    public class EquiposCelularesModel
    {
        private int telefonos_id;
        private string marca;
        private string modelo;
        private string gama;
        private string num_serie;
        private string color;


        [DisplayName("Telefono ID")]
        public int Telefonos_id { get => telefonos_id; set => telefonos_id = value; }

        [DisplayName("Marca del telefono")]
        [Required(ErrorMessage = "La marca del telefono es requerido")]
        public string Marca { get => marca; set => marca = value; }

        [DisplayName("Modelo del telefono")]
        [Required(ErrorMessage = "El valor del plan es requerido")]
        public string Modelo { get => modelo; set => modelo = value; }

        [DisplayName("Nombre de la Gama")]
        [Required(ErrorMessage = "El nombre de la gama es requerido")]
        public string Gama { get => gama; set => gama = value; }

        [DisplayName("Numero de serie del telefono")]
        [Required(ErrorMessage = "El numero de serie es requerido")]
        public string Numero_serie { get => num_serie; set => num_serie = value; }

        [DisplayName("Color del telefono")]
        [Required(ErrorMessage = "El color del telefono es requerido")]
        public string Color { get => color; set => color = value; }

    }
}

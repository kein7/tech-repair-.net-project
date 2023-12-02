using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechRepair.Models
{
    public class ClientesModel
    {
        private int cliente_id;
        private int direccion_id;
        private string nombres;
        private string apellido_pat;
        private string apellido_mat;
        private int rut_cliente;
        private string email;
        private int telefono_contacto;


        [DisplayName("Cliente ID")]
        public int Cliente_id { get => cliente_id; set => cliente_id = value; }

        [DisplayName("Direccion_id")]
        [Required(ErrorMessage = "La direccion es requerida")]
        public int Direccion_id { get => direccion_id; set => direccion_id = value; }

        [DisplayName("Nombre del cliente")]
        [Required(ErrorMessage = "El nombre del cliente es requerido")]
        public string Nombres { get => nombres; set => nombres = value; }

        [DisplayName("Apellido Paterno del cliente")]
        [Required(ErrorMessage = "El apellido paterno del cliente es requerido")]
        public string Apellido_paterno { get => apellido_pat; set => apellido_pat = value; }

        [DisplayName("Apellido Materno del cliente")]
        [Required(ErrorMessage = "El plazo de entrega es requerido")]
        public string Apellido_materno { get => apellido_mat; set => apellido_mat = value; }

        [DisplayName("Rut del cliente")]
        [Required(ErrorMessage = "El rut del cliente es requerido")]
        public int Rut { get => rut_cliente; set => rut_cliente = value; }

        [DisplayName("Email del cliente")]
        [Required(ErrorMessage = "El email del cliente es requerido")]
        public string Email { get => email; set => email = value; }

        [DisplayName("Telefono del cliente")]
        [Required(ErrorMessage = "El telefono del cliente es requerido")]
        public int Telefono_contacto { get => telefono_contacto; set => telefono_contacto = value; }
    }
}

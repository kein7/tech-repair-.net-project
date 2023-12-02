using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechRepair.Models
{
    public class AdmUsuarios2Model
    {
        private int user_id;
        private string userName;
        private string nombre;
        private string apellidoPat;
        private string apellidoMat;
        private string email;
        private string cargo;

        [DisplayName("User ID")]
        public int UserId { get => user_id; set => user_id = value; }

        [DisplayName("Nombre de usuario")]
        public string UserName { get => userName; set => userName = value; }

        [DisplayName("Primer nombre")]
        public string Nombre { get => nombre; set => nombre = value; }

        [DisplayName("Apellido paterno del usuario")]
        public string ApellidoPaterno { get => apellidoPat; set => apellidoPat = value; }

        [DisplayName("Apellido materno del usuario")]
        public string ApellidoMaterno { get => apellidoMat; set => apellidoMat = value; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "El email es requerido")]
        public string Email { get => email; set => email = value; }

        [DisplayName("Cargo")]
        [Required(ErrorMessage = "El cargo es requerido")]
        public string Cargo { get => cargo; set => cargo = value; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechRepair.Models
{
    public class AdmUsuariosModel
    {
        private int user_id;
        private string userName;
        private string password;
        private string nombre;
        private string apellidoPat;
        private string apellidoMat;
        private string email;
        private string cargo;

        [DisplayName("User ID")]
        public int UserId { get => user_id; set => user_id = value; }

        [DisplayName("Nombre de usuario")]
        [Required(ErrorMessage = "El nombre de usuario es requerido")]
        public string UserName { get => userName; set => userName = value; }

        [DisplayName("Contraseña del usuario")]
        [Required(ErrorMessage = "La contraseña es requerida")]
        public string Password { get => password; set => password = value; }

        [DisplayName("Primer nombre")]
        [Required(ErrorMessage = "El primer nombre es requerido")]
        public string Nombre { get => nombre; set => nombre = value; }

        [DisplayName("Apellido paterno del usuario")]
        [Required(ErrorMessage = "El apellido paterno es requerido")]
        public string ApellidoPaterno { get => apellidoPat; set => apellidoPat = value; }

        [DisplayName("Apellido materno del usuario")]
        public string ApellidoMaterno { get => apellidoMat; set => apellidoMat = value; }

        [DisplayName("Email")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        [Required(ErrorMessage = "El email es requerido")]
        public string Email { get => email; set => email = value; }

        [DisplayName("Cargo")]
        public string Cargo { get => cargo; set => cargo = value; }

    }
}

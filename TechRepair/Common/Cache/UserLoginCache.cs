using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechRepair.Common.Cache
{
    public class UserLoginCache
    {
        public static int UserId { get; set; }
        public static string Usuario { get; set; }
        public static string Nombre { get; set; }
        public static string ApellidoPaterno { get; set; }

        public static string ApellidoMaterno { get; set; }
        public static int CargoId { get; set; }
        public static string Email { get; set; }
    }
}

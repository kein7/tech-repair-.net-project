using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechRepair.EmailService
{
    class SystemSupportEmail : MasterEmailService
    {
        public SystemSupportEmail()
        {
            // estos datos como buena practica se deberian obtener desde una base de datos para administrar todo estos datos desde un solo lugar y que sea mas seguro
            senderMail = "pruebaparaservicio12@gmail.com";
            password = "asdqwe123_456";
            host = "smtp.gmail.com";
            port = 587;
            ssl = true;
            initializeSmtpClient(); 
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechRepair.Models;
using TechRepair.Common.Cache;
using TechRepair.EmailService;


namespace TechRepair._Repositories
{
    public class LoginRepository : BaseRepository, ILoginRepository
    {
        public LoginRepository(string connectionString) 
        {
            this.connectionString = connectionString;
        }

        public bool ValidateLogin(string username, string password)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM usuarios WHERE user_name = @UserName AND password = @Password";
                command.Parameters.Add("@UserName", SqlDbType.VarChar).Value = username;
                command.Parameters.Add("@Password", SqlDbType.VarChar).Value = password;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        UserLoginCache.UserId = reader.GetInt32(0);
                        UserLoginCache.Usuario = reader.GetString(1);
                        UserLoginCache.Nombre = reader.GetString(3);
                        UserLoginCache.ApellidoPaterno = reader.GetString(4);
                        UserLoginCache.ApellidoMaterno = reader.GetString(5);
                        UserLoginCache.CargoId = reader.GetInt32(6);
                        UserLoginCache.Email = reader.GetString(7);
                    }
                    return true;
                }
                else
                    return false;
            }
        }

        public string recoverPassword(string userRequesting)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM usuarios WHERE user_name = @UserName OR email = @Email";
                command.Parameters.AddWithValue("@UserName", userRequesting);
                command.Parameters.AddWithValue("@Email", userRequesting);
                command.CommandType = CommandType.Text;
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read() == true)
                {
                    string name = reader.GetString(3) + ", " + reader.GetString(4);
                    string email = reader.GetString(7);
                    string accountPassword = reader.GetString(2);

                    var emailService = new SystemSupportEmail();
                    emailService.sendMail(
                        subject: "System: Petición de recuperación de contraseña",
                        body: "Hola, " + name + "\n Has requerido recuperar tu contraseña \n" +
                        "tu nueva contraseña es: " + accountPassword +
                        "\n Te recomendamos que cambies esta contraseña inmediatamente una vez accedas al sistema",
                        recipientEmail: new List<string> { email });

                    return "Hola, " + name + "\n Has requerido recuperar tu contraseña \n" +
                        "Porfavor revise su email" + email +
                        "\n Te recomendamos que cambies esta contraseña inmediatamente una vez accedas al sistema";
                }
                else
                    return "Lo sentimos, no tiene una cuenta registrada con este email o usuario";
            }
        }

    }
}

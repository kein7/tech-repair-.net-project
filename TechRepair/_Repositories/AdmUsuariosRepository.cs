using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechRepair.Common.Cache;
using TechRepair.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TechRepair._Repositories
{
    public class AdmUsuariosRepository : BaseRepository, IAdmUsuariosRepository
    {
        public AdmUsuariosRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void AddUser(AdmUsuariosModel admUsuariosModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"INSERT INTO usuarios VALUES (@UserName, @Password, @Nombre, @ApellidoPaterno, @ApellidoMaterno, @CargoId, @Email)";
                command.Parameters.Add("@UserName", SqlDbType.VarChar).Value = admUsuariosModel.UserName;
                command.Parameters.Add("@Password", SqlDbType.VarChar).Value = admUsuariosModel.Password;
                command.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = admUsuariosModel.Nombre;
                command.Parameters.Add("@ApellidoPaterno", SqlDbType.VarChar).Value = admUsuariosModel.ApellidoPaterno;
                command.Parameters.Add("@ApellidoMaterno", SqlDbType.VarChar).Value = admUsuariosModel.ApellidoMaterno;
                command.Parameters.Add("@CargoId", SqlDbType.VarChar).Value = admUsuariosModel.Cargo;
                command.Parameters.Add("@Email", SqlDbType.VarChar).Value = admUsuariosModel.Email;
                command.ExecuteReader();
            }
        }
        public void EditUserCargo(AdmUsuarios2Model admUsuariosModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE usuarios SET cargo_id = @Cargo
                                        WHERE user_id = @UserId";
                command.Parameters.Add("@UserId", SqlDbType.Int).Value = admUsuariosModel.UserId;
                command.Parameters.Add("@Cargo", SqlDbType.Int).Value = admUsuariosModel.Cargo;
                command.ExecuteNonQuery();
            }
        }
        public void EditUser(AdmUsuariosModel admUsuariosModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE usuarios set user_name = @UserName, password = @Password, nombre = @Nombre, 
                                        apellido_paterno = @ApellidoPaterno, apellido_materno = @ApellidoMaterno, email = @Email 
                                        WHERE user_id = @UserId";
                command.Parameters.Add("@UserId", SqlDbType.VarChar).Value = admUsuariosModel.UserId;
                command.Parameters.Add("@UserName", SqlDbType.VarChar).Value = admUsuariosModel.UserName;
                command.Parameters.Add("@Password", SqlDbType.VarChar).Value = admUsuariosModel.Password;
                command.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = admUsuariosModel.Nombre;
                command.Parameters.Add("@ApellidoPaterno", SqlDbType.VarChar).Value = admUsuariosModel.ApellidoPaterno;
                command.Parameters.Add("@ApellidoMaterno", SqlDbType.VarChar).Value = admUsuariosModel.ApellidoMaterno;
                command.Parameters.Add("@Email", SqlDbType.VarChar).Value = admUsuariosModel.Email;
                SqlDataReader reader = command.ExecuteReader();
            }
        }
        public void DeleteUser(int value)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM usuarios WHERE user_id = @UserId";
                command.Parameters.Add("@UserId", SqlDbType.Int).Value = value;
                command.ExecuteNonQuery();
            }
        }

        public bool ValidatePassword(int userId, string password)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM usuarios WHERE user_id = @UserID AND password = @Password";
                command.Parameters.Add("@UserID", SqlDbType.VarChar).Value = userId;
                command.Parameters.Add("@Password", SqlDbType.VarChar).Value = password;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    return true;
                }
                else
                    return false;
            }
        }

        public IEnumerable<AdmUsuarios2Model> GetAllUsuarios()
        {
            var usuariosList = new List<AdmUsuarios2Model>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"Select DISTINCT usuarios.user_id AS 'Usuario ID', usuarios.user_name AS 'Usuario', 
                                        usuarios.nombre, usuarios.apellido_paterno, usuarios.apellido_materno, cargo.nombre_cargo, usuarios.email 
                                        FROM usuarios, cargo WHERE usuarios.cargo_id = cargo.cargo_id order by user_id asc";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var admUsuariosModel = new AdmUsuarios2Model();
                        admUsuariosModel.UserId = (int)reader[0];
                        admUsuariosModel.UserName = reader[1].ToString();
                        admUsuariosModel.Nombre = reader[2].ToString();
                        admUsuariosModel.ApellidoPaterno = reader[3].ToString();
                        admUsuariosModel.ApellidoMaterno = reader[4].ToString();
                        admUsuariosModel.Cargo = reader[5].ToString();
                        admUsuariosModel.Email = reader[6].ToString();
                        usuariosList.Add(admUsuariosModel);
                    }
                }
            }
            return usuariosList;
        }

        public IEnumerable<AdmUsuarios2Model> GetByValueUsuario(string value)
        {
            var usuariosList = new List<AdmUsuarios2Model>();
            int userId = int.TryParse(value, out _) ? Convert.ToInt32(value) : -1;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"Select DISTINCT usuarios.user_id AS 'Usuario ID', usuarios.user_name AS 'Usuario', 
		                                usuarios.nombre, usuarios.apellido_paterno, usuarios.apellido_materno, cargo.nombre_cargo, usuarios.email 
		                                FROM usuarios, cargo WHERE usuarios.cargo_id = cargo.cargo_id  AND (usuarios.user_id = @User_id OR 
		                                usuarios.user_name like @User_name) order by user_id asc";
                command.Parameters.Add("@User_id", SqlDbType.Int).Value = userId;
                command.Parameters.Add("@User_name", SqlDbType.VarChar).Value = value;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var admUsuariosModel = new AdmUsuarios2Model();
                        admUsuariosModel.UserId = (int)reader[0];
                        admUsuariosModel.UserName = reader[1].ToString();
                        admUsuariosModel.Nombre = reader[2].ToString();
                        admUsuariosModel.ApellidoPaterno = reader[3].ToString();
                        admUsuariosModel.ApellidoMaterno = reader[4].ToString();
                        admUsuariosModel.Cargo = reader[5].ToString();
                        admUsuariosModel.Email = reader[6].ToString();
                        usuariosList.Add(admUsuariosModel);
                    }
                }
            }
            return usuariosList;
        }

    }
}

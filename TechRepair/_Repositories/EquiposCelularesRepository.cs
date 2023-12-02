using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechRepair.Models;

namespace TechRepair._Repositories
{
    public class EquiposCelularesRepository : BaseRepository, IEquiposCelularesRepository
    {
        public EquiposCelularesRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void Add(EquiposCelularesModel equiposModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO telefonos values (@Gama, @Marca, @NumeroSerie, @Modelo, @Color)";
                command.Parameters.Add("@Gama", SqlDbType.Int).Value = equiposModel.Gama;
                command.Parameters.Add("@Marca", SqlDbType.NVarChar).Value = equiposModel.Marca;
                command.Parameters.Add("@NumeroSerie", SqlDbType.NVarChar).Value = equiposModel.Numero_serie;
                command.Parameters.Add("@Modelo", SqlDbType.NVarChar).Value = equiposModel.Modelo;
                command.Parameters.Add("@Color", SqlDbType.NVarChar).Value = equiposModel.Color;
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int telefono_id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM telefonos WHERE telefono_id = @TelefonosID";
                command.Parameters.Add("@TelefonosID", SqlDbType.Int).Value = telefono_id;
                command.ExecuteNonQuery();
            }
        }

        public void Edit(EquiposCelularesModel equiposModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "UPDATE telefonos SET gama_id = @Gama, marca_id = @Marca, numero_serie = @NumeroSerie, modelo = @Modelo, color = @Color WHERE telefono_id = @TelefonosID";
                command.Parameters.Add("@TelefonosID", SqlDbType.Int).Value = equiposModel.Telefonos_id;
                command.Parameters.Add("@Gama", SqlDbType.NVarChar).Value = equiposModel.Gama;
                command.Parameters.Add("@Marca", SqlDbType.NVarChar).Value = equiposModel.Marca;
                command.Parameters.Add("@NumeroSerie", SqlDbType.NVarChar).Value = equiposModel.Numero_serie;
                command.Parameters.Add("@Modelo", SqlDbType.NVarChar).Value = equiposModel.Modelo;
                command.Parameters.Add("@Color", SqlDbType.NVarChar).Value = equiposModel.Color;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<EquiposCelularesModel> GetAllTelefonos()
        {
            var telefonosList = new List<EquiposCelularesModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select telefonos.telefono_id, telefonos.gama_id, marcas.marca_telefono, telefonos.numero_serie, telefonos.modelo, telefonos.color , gamas.tipo_de_gama "
                    +"from telefonos, gamas, marcas " +
                    "WHERE telefonos.gama_id = gamas.gama_id AND telefonos.marca_id = marcas.marca_id order by gama_id desc ";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var equiposModel = new EquiposCelularesModel();
                        equiposModel.Telefonos_id = (int)reader[0];
                        equiposModel.Gama = reader[1].ToString();
                        equiposModel.Marca = reader[2].ToString();
                        equiposModel.Numero_serie = reader[3].ToString();
                        equiposModel.Modelo = reader[4].ToString();
                        equiposModel.Color = reader[5].ToString();
                        
                        telefonosList.Add(equiposModel);
                    }
                }
            }
            return telefonosList;
        }
        public IEnumerable<EquiposCelularesModel> GetByValueTelefonos(string value)
        {
            var telefonosList = new List<EquiposCelularesModel>();
            int telefonoId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string numSerie = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"Select * from telefonos WHERE telefono_id = @Telefono_id OR numero_serie = @Num_serie";
                command.Parameters.Add("@Telefono_id", SqlDbType.Int).Value = telefonoId;
                command.Parameters.Add("@Num_serie", SqlDbType.NVarChar).Value = numSerie;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var equiposModel = new EquiposCelularesModel();
                        equiposModel.Telefonos_id = (int)reader[0];
                        equiposModel.Gama = reader[1].ToString();
                        equiposModel.Marca = reader[2].ToString();
                        equiposModel.Numero_serie = reader[3].ToString();
                        equiposModel.Modelo = reader[4].ToString();
                        equiposModel.Color = reader[5].ToString();

                        telefonosList.Add(equiposModel);
                    }
                }
            }
            return telefonosList;
        }
        public IEnumerable<EquiposCelularesModel> GetMarcaTelefono(string value)
        {
            var telefonosList = new List<EquiposCelularesModel>();
            int marcaId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string nombreMarca = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT  marca_id, marca_telefono FROM marcas
                                        WHERE  marcas.marca_id = @Marca_id or marcas.marca_telefono = @Nombre_marca";
                command.Parameters.Add("@Marca_id", SqlDbType.Int).Value = marcaId;
                command.Parameters.Add("@Nombre_marca", SqlDbType.NVarChar).Value = nombreMarca;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var equiposModel = new EquiposCelularesModel();
                        if(nombreMarca == null)
                        {
                            equiposModel.Marca = reader[1].ToString();
                        }
                        else
                        {
                            equiposModel.Marca = reader[0].ToString();
                        }
                        telefonosList.Add(equiposModel);
                    }
                }
            }
            return telefonosList;
        }
    }
}

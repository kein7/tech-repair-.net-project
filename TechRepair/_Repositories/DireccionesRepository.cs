using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechRepair.Models;

namespace TechRepair._Repositories
{
    public class DireccionesRepository : BaseRepository, IDireccionesRepository
    {
        public DireccionesRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void Delete(int direccionId)
        { 
            //TODO
        }
        public int Add(DireccionesModel direccionesModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"INSERT INTO direcciones 
                                        values (@Calle, @NumCalle, @NumDpto, @ComunaId); SELECT SCOPE_IDENTITY();";
                command.Parameters.Add("@Calle", SqlDbType.NVarChar).Value = direccionesModel.Calle;
                command.Parameters.Add("@NumCalle", SqlDbType.NVarChar).Value = direccionesModel.Num_calle;
                command.Parameters.Add("@NumDpto", SqlDbType.NVarChar).Value = direccionesModel.Num_dpto;
                command.Parameters.Add("@ComunaId", SqlDbType.NVarChar).Value = direccionesModel.Comuna;
                int generatedId = Convert.ToInt32(command.ExecuteScalar());
                return generatedId;
            }
        }

        public void Edit(DireccionesModel direccionesModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE direcciones 
                                        SET nombre_calle = @Calle, 
                                        num_calle = @NumCalle, num_dpto = @NumDpto, comuna_id = @ComunaId WHERE direccion_id = @DireccionId";
                command.Parameters.Add("@DireccionId", SqlDbType.Int).Value = direccionesModel.Direccion_id;
                command.Parameters.Add("@Calle", SqlDbType.NVarChar).Value = direccionesModel.Calle;
                command.Parameters.Add("@NumCalle", SqlDbType.Int).Value = direccionesModel.Num_calle;
                command.Parameters.Add("@NumDpto", SqlDbType.Int).Value = direccionesModel.Num_dpto;
                command.Parameters.Add("@ComunaId", SqlDbType.Int).Value = direccionesModel.Comuna;
                command.ExecuteNonQuery();
            }
        }
        public IEnumerable<DireccionesModel> GetAllDirecciones()
        {
            var direccionesList  = new List<DireccionesModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = 
                    "Select direcciones.direccion_id ,direcciones.nombre_calle,direcciones.num_calle,direcciones.num_dpto," +
                    "comunas.nombre_comuna,comunas.region from direcciones, comunas WHERE direcciones.comuna_id = comunas.comuna_id order by direccion_id desc ";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var direccionesModel = new DireccionesModel();
                        direccionesModel.Direccion_id = (int)reader[0];
                        direccionesModel.Calle = reader[1].ToString();
                        direccionesModel.Num_calle = reader[2].ToString();
                        direccionesModel.Num_dpto = reader[3].ToString();
                        direccionesModel.Comuna = reader[4].ToString();
                        direccionesModel.Region = reader[5].ToString();
                        direccionesList.Add(direccionesModel);
                    }
                }
            }
            return direccionesList;
        }
        public IEnumerable<DireccionesModel> GetByValueDirecciones(string value)
        {
            var direccionesList = new List<DireccionesModel>();
            int direccionId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select *\r\nfrom direcciones\r\nWHERE direccion_id = @Direccion_id order by direccion_id desc ";
                command.Parameters.Add("@Direccion_id", SqlDbType.Int).Value = direccionId;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var direccionesModel = new DireccionesModel();
                        direccionesModel.Direccion_id = (int)reader[0];
                        direccionesModel.Calle = reader[1].ToString();
                        direccionesModel.Num_calle = reader[2].ToString();
                        direccionesModel.Num_dpto = reader[3].ToString();
                        direccionesModel.Comuna = reader[4].ToString();
                        direccionesList.Add(direccionesModel);
                    }
                }
            }
            return direccionesList;
        }
        public IEnumerable<DireccionesModel> GetComunaId(string value, string value2)
        {
            var comunasList = new List<DireccionesModel>();
            string nombreComuna = value;
            string nombreRegion = value2;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select * from comunas WHERE nombre_comuna = @Comuna AND region = @Region order by comuna_id desc ";
                command.Parameters.Add("@Comuna", SqlDbType.NVarChar).Value = nombreComuna;
                command.Parameters.Add("@Region", SqlDbType.NVarChar).Value = nombreRegion;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var direccionesModel = new DireccionesModel();
                        direccionesModel.Comuna = reader[0].ToString();
                        direccionesModel.Region = reader[2].ToString();
                        comunasList.Add(direccionesModel);
                    }
                }
            }
            return comunasList;
        }

        public List<string> GetRegionByComuna(string value)
        {
            var regionList = new List<string>();
            int comunaId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string nombreComuna = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select * from comunas WHERE comuna_id = @Comuna or nombre_comuna = @nombreComuna order by comuna_id desc ";
                command.Parameters.Add("@Comuna", SqlDbType.Int).Value = comunaId;
                command.Parameters.Add("@nombreComuna", SqlDbType.NVarChar).Value = nombreComuna;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string region;
                        region = reader[2].ToString();
                        regionList.Add(region);
                    }
                }
            }
            return regionList;
        }

        public List<string> GetRegiones(string value)
        {
            var regionList = new List<string>();
            int nombreComuna = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select distinct region from comunas ";
                command.Parameters.Add("@Comuna", SqlDbType.Int).Value = nombreComuna;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string region;
                        region = reader[0].ToString();
                        regionList.Add(region);
                    }
                }
            }
            return regionList;
        }
    }
}

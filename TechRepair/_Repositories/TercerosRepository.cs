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
    public class TercerosRepository : BaseRepository, ITercerosRepository
    {
        public TercerosRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Add(TercerosModel tercerosModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO planes values (@CodigoTercero, @Nombres, @ApellidoPat, @ApellidoMat, @Rut)";
                command.Parameters.Add("@CodigoTercero", SqlDbType.NVarChar).Value = tercerosModel.Codigo_tercero;
                command.Parameters.Add("@Nombres", SqlDbType.Int).Value = tercerosModel.Nombres_tercero;
                command.Parameters.Add("@ApellidoPat", SqlDbType.NVarChar).Value = tercerosModel.Apellido_paterno;
                command.Parameters.Add("@ApellidoMat", SqlDbType.Int).Value = tercerosModel.Apellido_materno;
                command.Parameters.Add("@Rut", SqlDbType.Int).Value = tercerosModel.Rut_tercero;
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int tercero_id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM terceros WHERE tercero_id = @TerceroId";
                command.Parameters.Add("@TerceroId", SqlDbType.Int).Value = tercero_id;
                command.ExecuteNonQuery();
            }
        }

        public void Edit(TercerosModel tercerosModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "UPDATE terceros SET codigo_tercero = @CodigoTercero, nombres=@Nombres, apellido_paterno=@ApellidoPat, apellido_materno=@ApellidoMat, rut_tercero=@Rut WHERE tercero_id=@TerceroId";
                command.Parameters.Add("@TerceroId", SqlDbType.Int).Value = tercerosModel.Tercero_id; //probar si sobra o no esta parte...
                command.Parameters.Add("@CodigoTercero", SqlDbType.NVarChar).Value = tercerosModel.Codigo_tercero;
                command.Parameters.Add("@Nombres", SqlDbType.NVarChar).Value = tercerosModel.Nombres_tercero;
                command.Parameters.Add("@ApellidoPat", SqlDbType.NVarChar).Value = tercerosModel.Apellido_paterno;
                command.Parameters.Add("@ApellidoMat", SqlDbType.NVarChar).Value = tercerosModel.Apellido_materno;
                command.Parameters.Add("@Rut", SqlDbType.NVarChar).Value = tercerosModel.Rut_tercero;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<TercerosModel> GetAllTerceros()
        {
            var tercerosList = new List<TercerosModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select planes.plan_id ,planes.plan_reparacion ,planes.valor_plan ,planes.estado_plan, planes.plazo_entrega,gamas.tipo_de_gama " +
                    "from planes, gamas " +
                    "WHERE planes.gama_id = gamas.gama_id order by plan_id desc ";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var tercerosModel = new TercerosModel();
                        tercerosModel.Tercero_id = (int)reader[0];
                        tercerosModel.Codigo_tercero = reader[1].ToString();
                        tercerosModel.Nombres_tercero = reader[2].ToString();
                        tercerosModel.Apellido_paterno = reader[3].ToString();
                        tercerosModel.Apellido_paterno = reader[4].ToString();
                        tercerosModel.Rut_tercero = (int)reader[5];
                        tercerosList.Add(tercerosModel);
                    }
                }
            }
            return tercerosList;
        }

        public IEnumerable<TercerosModel> GetByValueTerceros(string value)
        {
            var tercerosList = new List<TercerosModel>();
            int terceroId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            int rut = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"Select * from terceros
                                        where tercero_id=@TerceroId or rut_tercero like @Rut
                                        order by tercero_id desc";
                command.Parameters.Add("@TerceroId", SqlDbType.Int).Value = terceroId;
                command.Parameters.Add("@Rut", SqlDbType.Int).Value = rut;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var tercerosModel = new TercerosModel();
                        tercerosModel.Tercero_id = (int)reader[0];
                        tercerosModel.Codigo_tercero = reader[1].ToString();
                        tercerosModel.Nombres_tercero = reader[2].ToString();
                        tercerosModel.Apellido_paterno = reader[3].ToString();
                        tercerosModel.Apellido_materno = reader[4].ToString();
                        tercerosModel.Rut_tercero = (int)reader[5];
                        tercerosList.Add(tercerosModel);
                    }
                }
            }
            return tercerosList;
        }
    }
}

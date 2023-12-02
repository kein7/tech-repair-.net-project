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
    public class TecnicosRepository : BaseRepository, ITecnicosRepository
    {
        public TecnicosRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Add(TecnicosModel tecnicosModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"INSERT INTO tecnicos values (@NombresTecnico, @ApellidoPat, @ApellidoMat, @RutTecnico, @Email, @Telefono)";
                command.Parameters.Add("@NombresTecnico", SqlDbType.NVarChar).Value = tecnicosModel.Nombres;
                command.Parameters.Add("@ApellidoPat", SqlDbType.NVarChar).Value = tecnicosModel.Apellido_paterno;
                command.Parameters.Add("@ApellidoMat", SqlDbType.NVarChar).Value = tecnicosModel.Apellido_materno;
                command.Parameters.Add("@RutTecnico", SqlDbType.Int).Value = tecnicosModel.Rut_tecnico;
                command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = tecnicosModel.Email;
                command.Parameters.Add("@Telefono", SqlDbType.Int).Value = tecnicosModel.Telefono;
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int tecnico_id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM tecnicos WHERE tecnico_id = @TecnicoId";
                command.Parameters.Add("@TecnicoId", SqlDbType.Int).Value = tecnico_id;
                command.ExecuteNonQuery();
            }
        }

        public void Edit(TecnicosModel tecnicosModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "UPDATE planes SET plan_reparacion = @PlanReparacion, valor_plan=@PlanValor, estado_plan=@PlanEstado, plazo_entrega=@PlazoEntrega, gama_id=@GamaId WHERE plan_id=@PlanId";
                command.Parameters.Add("@NombresTecnico", SqlDbType.NVarChar).Value = tecnicosModel.Nombres;
                command.Parameters.Add("@ApellidoPat", SqlDbType.NVarChar).Value = tecnicosModel.Apellido_paterno;
                command.Parameters.Add("@ApellidoMat", SqlDbType.NVarChar).Value = tecnicosModel.Apellido_materno;
                command.Parameters.Add("@RutTecnico", SqlDbType.Int).Value = tecnicosModel.Rut_tecnico;
                command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = tecnicosModel.Email;
                command.Parameters.Add("@Telefono", SqlDbType.Int).Value = tecnicosModel.Telefono;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<TecnicosModel> GetByValueTecnicos(string value)
        {
            var tecnicosList = new List<TecnicosModel>();
            int tecnicoId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"Select tecnico_id, rut_tecnico
                                        from tecnicos
                                        WHERE tecnico_id = Tecnico_id";
                command.Parameters.Add("@Tecnico_id", SqlDbType.Int).Value = tecnicoId;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var tecnicosModel = new TecnicosModel();
                        tecnicosModel.Tecnicos_id = (int)reader[0];
                        tecnicosModel.Rut_tecnico = (int)reader[1];

                        tecnicosList.Add(tecnicosModel);
                    }
                }
            }
            return tecnicosList;
        }
        public int GetTecnicoId(string email)
        {
            int idTecnico = -1;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"Select tecnico_id
                                        from tecnicos
                                        WHERE email = @EmailTecnico";
                command.Parameters.Add("@EmailTecnico", SqlDbType.VarChar).Value = email;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        idTecnico = (int)reader[0];
                    }
                }
            }
            return idTecnico;
        }

        /*
        public IEnumerable<TecnicosModel> GetAllTecnicos()
        {
            var tecnicosList = new List<TecnicosModel>();
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
                        var tecnicosModel = new TecnicosModel();
                        tecnicosModel. = (int)reader[0];
                        tecnicosModel. = reader[1].ToString();
                        tecnicosModel. = (int)reader[2];
                        tecnicosModel. = reader[3].ToString();
                        tecnicosModel. = (int)reader[4];
                        tecnicosModel. = reader[5].ToString();
                        tecnicosList.Add(tecnicosModel);
                    }
                }
            }
            return tecnicosList;
        }
        */
    }
}

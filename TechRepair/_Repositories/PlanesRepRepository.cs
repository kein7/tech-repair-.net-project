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
    public class PlanesRepRepository : BaseRepository, IPlanesRepRepository
    {

        public PlanesRepRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Add(PlanesRepModel planesModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO planes values (@PlanReparacion, @PlanValor, @PlanEstado, @PlazoEntrega, @GamaId)";
                command.Parameters.Add("@PlanReparacion", SqlDbType.NVarChar).Value = planesModel.Plan_reparacion;
                command.Parameters.Add("@PlanValor", SqlDbType.Int).Value = planesModel.Valor_plan;
                command.Parameters.Add("@PlanEstado", SqlDbType.NVarChar).Value = planesModel.Estado_plan;
                command.Parameters.Add("@PlazoEntrega", SqlDbType.Int).Value = planesModel.Plazo_entrega;
                command.Parameters.Add("@GamaId", SqlDbType.Int).Value = planesModel.Gama;
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int planes_id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM planes WHERE plan_id = @PlanId";
                command.Parameters.Add("@PlanId", SqlDbType.Int).Value = planes_id;
                command.ExecuteNonQuery();
            }
        }

        public void Edit(PlanesRepModel planesModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "@UPDATE planes SET plan_reparacion = @PlanReparacion, valor_plan=@PlanValor, estado_plan=@PlanEstado, plazo_entrega=@PlazoEntrega, " +
                    "                   gama_id=@GamaId WHERE plan_id=@PlanId";
                command.Parameters.Add("@PlanId", SqlDbType.Int).Value = planesModel.Plan_id; //probar si sobra o no esta parte... R: aweonao no sobra, de hecho es fundamental
                command.Parameters.Add("@PlanReparacion", SqlDbType.NVarChar).Value = planesModel.Plan_reparacion;
                command.Parameters.Add("@PlanValor", SqlDbType.Int).Value = planesModel.Valor_plan;
                command.Parameters.Add("@PlanEstado", SqlDbType.NVarChar).Value = planesModel.Estado_plan;
                command.Parameters.Add("@PlazoEntrega", SqlDbType.NVarChar).Value = planesModel.Plazo_entrega;
                command.Parameters.Add("@GamaId", SqlDbType.NVarChar).Value = planesModel.Gama;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<PlanesRepModel> GetAllPlanes()
        {
            var planesList = new List<PlanesRepModel>();
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
                        var planesRepModel = new PlanesRepModel();
                        planesRepModel.Plan_id = (int)reader[0];
                        planesRepModel.Plan_reparacion = reader[1].ToString();
                        planesRepModel.Valor_plan = (int)reader[2];
                        planesRepModel.Estado_plan = reader[3].ToString();
                        planesRepModel.Plazo_entrega = (int)reader[4];
                        planesRepModel.Gama = reader[5].ToString();
                        planesList.Add(planesRepModel);
                    }
                }
            }
            return planesList;
        }

        public IEnumerable<PlanesRepModel> GetByValuePlanes(string value)
        {
            var planesList = new List<PlanesRepModel>();
            int planId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string planReparacion = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"Select *from planes
                                        where plan_id=@Plan_id or plan_reparacion like @Plan_reparacion+'%'
                                        order by plan_id desc";
                command.Parameters.Add("@Plan_id", SqlDbType.Int).Value = planId;
                command.Parameters.Add("@Plan_reparacion", SqlDbType.NVarChar).Value = planReparacion;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var planesModel = new PlanesRepModel();
                        planesModel.Plan_id = (int)reader[0];
                        planesModel.Plan_reparacion = reader[1].ToString();
                        planesModel.Valor_plan = (int)reader[2];
                        planesModel.Estado_plan = reader[3].ToString();
                        planesModel.Plazo_entrega = (int)reader[4];
                        planesModel.Gama = reader[5].ToString();
                        planesList.Add(planesModel);
                    }
                }
            }
            return planesList;
        }

        public IEnumerable<PlanesRepModel> GetPlanId(string value, string value2)
        {
            var planesList = new List<PlanesRepModel>();
            string planReparacion = value;
            string gama = value2;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"Select * from planes
                                        where plan_reparacion=@Plan_reparacion AND gama_id=@Gama_id
                                        order by plan_id desc";
                command.Parameters.Add("@Plan_reparacion", SqlDbType.NVarChar).Value = planReparacion;
                command.Parameters.Add("@Gama_id", SqlDbType.NVarChar).Value = gama;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var planesModel = new PlanesRepModel();
                        planesModel.Plan_id = (int)reader[0];
                        planesModel.Plan_reparacion = reader[1].ToString();
                        planesModel.Valor_plan = (int)reader[2];
                        planesModel.Estado_plan = reader[3].ToString();
                        planesModel.Plazo_entrega = (int)reader[4];
                        planesModel.Gama = reader[5].ToString();
                        planesList.Add(planesModel);
                    }
                }
            }
            return planesList;
        }
    }
}

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
    public class GamasRepository : BaseRepository, IGamasRepository
    {
        public GamasRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public IEnumerable<GamasModel> GetAllGamas()
        {
            var gamasList = new List<GamasModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select * FROM gamas ";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var gamasModel = new GamasModel();
                        gamasModel.Gama_ID = (int)reader[0];
                        gamasModel.Tipo_Gama = reader[1].ToString();
                        gamasList.Add(gamasModel);
                    }
                }
            }
            return gamasList;
        }
        public IEnumerable<GamasModel> GetByValueGamas(string value)
        {
            var gamasList = new List<GamasModel>();
            int gamaId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string gamaName = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select * from gamas WHERE gama_id = @Gama_id or tipo_de_gama like @Nombre_gama+'%' order by gama_id desc ";
                command.Parameters.Add("@Gama_id", SqlDbType.Int).Value = gamaId;
                command.Parameters.Add("@Nombre_gama", SqlDbType.NVarChar).Value = gamaName;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var gamasModel = new GamasModel();
                        gamasModel.Gama_ID = (int)reader[0];
                        gamasModel.Tipo_Gama = reader[1].ToString();
                        gamasList.Add(gamasModel);
                    }
                }
            }
            return gamasList;
        }
    }
}

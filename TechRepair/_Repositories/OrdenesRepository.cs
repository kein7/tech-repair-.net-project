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
    public class OrdenesRepository : BaseRepository, IOrdenesRepository
    {
        public OrdenesRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Add(OrdenesModel ordenesModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO ordenes values (@TecnicoId, @EstadoId, @TelefonoId, @ClienteId, @PlanId, @TerceroId, DEFAULT)";
                command.Parameters.Add("@TecnicoId", SqlDbType.Int).Value = ordenesModel.Tecnico;
                command.Parameters.Add("@EstadoId", SqlDbType.Int).Value = ordenesModel.Estado;
                command.Parameters.Add("@TelefonoId", SqlDbType.Int).Value = ordenesModel.Telefono;
                command.Parameters.Add("@ClienteId", SqlDbType.Int).Value = ordenesModel.Cliente;
                command.Parameters.Add("@PlanId", SqlDbType.Int).Value = ordenesModel.Plan;
                SqlParameter param = new SqlParameter("@TerceroId", SqlDbType.Int);
                if (ordenesModel.Tercero == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = ordenesModel.Tercero;
                }
                command.Parameters.Add("@TerceroId", SqlDbType.Int).Value = param.Value;
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int orden_id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM ordenes WHERE orden_id = @OrdenId";
                command.Parameters.Add("@OrdenId", SqlDbType.Int).Value = orden_id;
                command.ExecuteNonQuery();
            }
        }

        public void Edit(OrdenesModel ordenesModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE ordenes SET tecnico_id = @TecnicoId, estado_id=@EstadoId, telefono_id=@TelefonoId, 
                                        cliente_id=@ClienteId, plan_id=@PlanId, tercero_id=@TerceroId WHERE orden_id = @OrdenId";
                command.Parameters.Add("@OrdenId", SqlDbType.Int).Value = ordenesModel.Orden_id;
                command.Parameters.Add("@TecnicoId", SqlDbType.Int).Value = ordenesModel.Tecnico;
                command.Parameters.Add("@EstadoId", SqlDbType.Int).Value = ordenesModel.Estado;
                command.Parameters.Add("@TelefonoId", SqlDbType.Int).Value = ordenesModel.Telefono;
                command.Parameters.Add("@ClienteId", SqlDbType.Int).Value = ordenesModel.Cliente;
                command.Parameters.Add("@PlanId", SqlDbType.Int).Value = ordenesModel.Plan;
                command.Parameters.Add("@TerceroId", SqlDbType.Int).Value = ordenesModel.Tercero;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<OrdenesModel> GetAllOrdenes()
        {
            var ordenesList = new List<OrdenesModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select DISTINCT ordenes.orden_id ,tecnicos.nombres AS 'Nombres tecnico' ,estados.estado_telefono ,telefonos.modelo, gamas.tipo_de_gama, clientes.nombres AS 'Nombres cliente'"+
                    ", planes.plan_reparacion, CASE WHEN ordenes.tercero_id IS NOT NULL THEN terceros.nombres ELSE CAST(ordenes.tercero_id AS VARCHAR)"+
                    " END AS result, ordenes.fecha_orden FROM ordenes, tecnicos, estados, telefonos, clientes, planes, terceros, gamas"+
                    " WHERE tecnicos.tecnico_id = ordenes.tecnico_id AND estados.estado_id = ordenes.estado_id AND telefonos.telefono_id = ordenes.telefono_id"+
                    " AND telefonos.gama_id = gamas.gama_id AND clientes.cliente_id = ordenes.cliente_id AND planes.plan_id = ordenes.plan_id AND"+
                    " (terceros.tercero_id = ordenes.tercero_id OR ordenes.tercero_id IS NULL) order by orden_id asc";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var ordenesModel = new OrdenesModel();
                        ordenesModel.Orden_id = (int)reader[0];
                        ordenesModel.Tecnico = reader[1].ToString();
                        ordenesModel.Estado = reader[2].ToString();
                        ordenesModel.Telefono = reader[3].ToString();
                        ordenesModel.Gama = reader[4].ToString();
                        ordenesModel.Cliente = reader[5].ToString();
                        ordenesModel.Plan = reader[6].ToString();
                        ordenesModel.Tercero = reader[7].ToString();
                        ordenesModel.Fecha_orden = reader[8].ToString();
                        ordenesList.Add(ordenesModel);
                    }
                }
            }
            return ordenesList;
        }

        public IEnumerable<OrdenesModel> GetByValueOrdenes(string value)
        {
            var ordenesList = new List<OrdenesModel>();
            int ordenId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"Select DISTINCT ordenes.orden_id ,tecnicos.nombres AS 'Nombres tecnico' ,estados.estado_telefono ,telefonos.modelo, 
                                        gamas.tipo_de_gama, clientes.nombres AS 'Nombres cliente', 
                                        planes.plan_reparacion, CASE WHEN ordenes.tercero_id IS NOT NULL THEN terceros.nombres ELSE CAST(ordenes.tercero_id AS VARCHAR) END AS 
                                        Nombre_Tercero, ordenes.fecha_orden
                                        from ordenes, tecnicos, estados, telefonos, clientes, planes, terceros, gamas
                                        WHERE tecnicos.tecnico_id = ordenes.tecnico_id AND estados.estado_id = ordenes.estado_id AND telefonos.telefono_id = ordenes.telefono_id AND 
                                        telefonos.gama_id = gamas.gama_id AND
                                        clientes.cliente_id = ordenes.cliente_id AND planes.plan_id = ordenes.plan_id AND 
                                        (terceros.tercero_id = ordenes.tercero_id OR ordenes.tercero_id IS NULL) AND orden_id = @Orden_id";
                command.Parameters.Add("@Orden_id", SqlDbType.Int).Value = ordenId;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var ordenesModel = new OrdenesModel();
                        ordenesModel.Orden_id = (int)reader[0];
                        ordenesModel.Tecnico = reader[1].ToString();
                        ordenesModel.Estado = reader[2].ToString();
                        ordenesModel.Telefono = reader[3].ToString();
                        ordenesModel.Gama = reader[4].ToString();
                        ordenesModel.Cliente = reader[5].ToString();
                        ordenesModel.Plan = reader[6].ToString();
                        ordenesModel.Tercero = reader[7].ToString();
                        ordenesModel.Fecha_orden = reader[8].ToString();
                        ordenesList.Add(ordenesModel);
                    }
                }
            }
            return ordenesList;
        }
        public IEnumerable<OrdenesModel> GetByValueIdOrdenes(string value)
        {
            var ordenesList = new List<OrdenesModel>();
            int ordenId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"Select *
                                        from ordenes
                                        WHERE orden_id = @Orden_id";
                command.Parameters.Add("@Orden_id", SqlDbType.Int).Value = ordenId;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var ordenesModel = new OrdenesModel();
                        ordenesModel.Orden_id = (int)reader[0];
                        ordenesModel.Tecnico = reader[1].ToString();
                        ordenesModel.Estado = reader[2].ToString();
                        ordenesModel.Telefono = reader[3].ToString();
                        ordenesModel.Cliente = reader[4].ToString();
                        ordenesModel.Plan = reader[5].ToString();
                        ordenesModel.Tercero = reader[6].ToString();
                        ordenesModel.Fecha_orden = reader[7].ToString();
                        ordenesList.Add(ordenesModel);
                    }
                }
            }
            return ordenesList;
        }
    }
}

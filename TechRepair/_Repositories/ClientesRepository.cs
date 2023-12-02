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
    public class ClientesRepository : BaseRepository, IClientesRepository
    {
        public ClientesRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Add(ClientesModel clientesModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO clientes values (@DireccionId, @Nombres, @ApellidoPat, @ApellidoMat, @RutCliente, @Email, @Telefono); SELECT SCOPE_IDENTITY();";
                command.Parameters.Add("@DireccionId", SqlDbType.Int).Value = clientesModel.Direccion_id;
                command.Parameters.Add("@Nombres", SqlDbType.NVarChar).Value = clientesModel.Nombres;
                command.Parameters.Add("@ApellidoPat", SqlDbType.NVarChar).Value = clientesModel.Apellido_paterno;
                command.Parameters.Add("@ApellidoMat", SqlDbType.NVarChar).Value = clientesModel.Apellido_materno;
                command.Parameters.Add("@RutCliente", SqlDbType.Int).Value = clientesModel.Rut;
                command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = clientesModel.Email;
                command.Parameters.Add("@Telefono", SqlDbType.Int).Value = clientesModel.Telefono_contacto;

                command.ExecuteNonQuery();
            }
        }

        public void Delete(int cliente_id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM clientes WHERE cliente_id = @ClienteId";
                command.Parameters.Add("@ClienteId", SqlDbType.Int).Value = cliente_id;
                command.ExecuteNonQuery();
            }
        }

        public void Edit(ClientesModel clientesModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "UPDATE clientes SET direccion_id = @DireccionId, nombres=@Nombres, apellido_paterno=@ApellidoPat, apellido_materno=@ApellidoMat, rut_cliente=@RutCliente, email=@Email ,telefono_contacto=@Telefono WHERE cliente_id=@ClienteId";
                command.Parameters.Add("@ClienteId", SqlDbType.Int).Value = clientesModel.Cliente_id; //probar si sobra o no esta parte...
                command.Parameters.Add("@DireccionId", SqlDbType.NVarChar).Value = clientesModel.Direccion_id;
                command.Parameters.Add("@Nombres", SqlDbType.NVarChar).Value = clientesModel.Nombres;
                command.Parameters.Add("@ApellidoPat", SqlDbType.NVarChar).Value = clientesModel.Apellido_paterno;
                command.Parameters.Add("@ApellidoMat", SqlDbType.NVarChar).Value = clientesModel.Apellido_materno;
                command.Parameters.Add("@RutCliente", SqlDbType.Int).Value = clientesModel.Rut;
                command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = clientesModel.Email;
                command.Parameters.Add("@Telefono", SqlDbType.Int).Value = clientesModel.Telefono_contacto;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<ClientesModel> GetAllClientes()
        {
            var clientesList = new List<ClientesModel>();
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
                        var clientesModel = new ClientesModel();
                        clientesModel.Cliente_id = (int)reader[0];
                        clientesModel.Direccion_id = (int)reader[1];
                        clientesModel.Nombres = reader[2].ToString();
                        clientesModel.Apellido_paterno = reader[3].ToString();
                        clientesModel.Apellido_materno = reader[4].ToString();
                        clientesModel.Rut = (int)reader[5];
                        clientesModel.Email = reader[6].ToString();
                        clientesModel.Telefono_contacto = (int)reader[7];
                        clientesList.Add(clientesModel);
                    }
                }
            }
            return clientesList;
        }

        public IEnumerable<ClientesModel> GetByValueClientes(string value)
        {
            var clientesList = new List<ClientesModel>();
            int clienteId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string rutCliente = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"Select * from clientes
                                        where cliente_id=@Cliente_id or rut_cliente like @Rut_cliente+'%'
                                        order by cliente_id desc";
                command.Parameters.Add("@Cliente_id", SqlDbType.Int).Value = clienteId;
                command.Parameters.Add("@Rut_cliente", SqlDbType.NVarChar).Value = rutCliente;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var clientesModel = new ClientesModel();
                        clientesModel.Cliente_id = (int)reader[0];
                        clientesModel.Direccion_id = (int)reader[1];
                        clientesModel.Nombres = reader[2].ToString();
                        clientesModel.Apellido_paterno = reader[3].ToString();
                        clientesModel.Apellido_materno = reader[4].ToString();
                        clientesModel.Rut = (int)reader[5];
                        clientesModel.Email = reader[6].ToString();
                        clientesModel.Telefono_contacto = (int)reader[7];
                        clientesList.Add(clientesModel);
                    }
                }
            }
            return clientesList;
        }
    }
}

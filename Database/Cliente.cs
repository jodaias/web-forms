using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class Cliente
    {
        public int Id;
        public string Nome;
        public static DataTable Buscar()
        {
            string connectionString = ConfigurationManager.AppSettings["SqlConnection"];
            using (SqlConnection connection = new SqlConnection(
                connectionString))
            {
                string queryString = "Select * from clientes";
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;

                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }
        public static DataTable BuscarPorId(int id)
        {
            string connectionString = ConfigurationManager.AppSettings["SqlConnection"];
            using (SqlConnection connection = new SqlConnection(
                connectionString))
            {
                //string queryString = "Select * from clientes c inner join pedidos p on c.idCliente = p.idCliente where p.idCliente =" + id;
                string queryString = "Select * from clientes where idCliente =" + id;
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;

                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }


        public static DataTable BuscarPorProcedureId(int id)
        {
            string connectionString = ConfigurationManager.AppSettings["SqlConnection"];
            using (SqlConnection connection = new SqlConnection(
                connectionString))
            {
                SqlParameter parameter = new SqlParameter();

                SqlCommand command = new SqlCommand("sp_clienteBuscar", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@id_Cliente", SqlDbType.Int).Value = id;
                command.Connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;

                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

    }
}

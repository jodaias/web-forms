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
    public class Produto
    {
        public static DataTable Buscar()
        {
            string connectionString = ConfigurationManager.AppSettings["SqlConnection"];
            using(SqlConnection connection = new SqlConnection(
                connectionString))
            {
                string queryString = "Select * from Produtos";
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;

                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        public static DataTable BuscarPorPedidoId(int idPedido)
        {
            string connectionString = ConfigurationManager.AppSettings["SqlConnection"];
            using (SqlConnection connection = new SqlConnection(
                connectionString))
            {
                string queryString = "Select distinct * from Produtos p inner join pedidos_produtos pp on pp.idProduto = p.idProduto where pp.idPedido ="+idPedido;
                SqlCommand command = new SqlCommand(queryString, connection);
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

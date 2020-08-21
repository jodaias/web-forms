using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Pedido
    {
        public int Id;
        public int IdCliente;
        public double ValorTotal;
        
        public Cliente cliente;
        private List<Produto> produtos;

        public List<Produto> Produtos
        {
            get
            {
                if (produtos != null) return produtos;
                produtos = Produto.BuscaPorPedidoId(this.Id);
                return produtos;
            }
        }

        public Cliente Cliente
        {
            get
            {
                if (cliente != null) return cliente;
                cliente = Cliente.BuscaPorId(this.IdCliente);
                return cliente;
            }
        }

        public static List<Pedido> Busca()
        {
            var pedidos = new List<Pedido>();
            var dados = Database.Pedido.Buscar();
            
            foreach(DataRow row in dados.Rows)
            {
                var pedido = new Pedido();
                pedido.Id = int.Parse(row["IdPedido"].ToString());
                pedido.IdCliente = int.Parse(row["IdCliente"].ToString());
                pedido.ValorTotal = double.Parse(row["ValorTotal"].ToString());
                pedidos.Add(pedido);
            }
            return pedidos;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Produto
    {
        public int Id;
        public string Nome;
        public double Valor;
        public int IdFornecedor;
        public Fornecedor fornecedor;

        public Fornecedor Fornecedor
        {
            get
            {
                if (fornecedor != null) return fornecedor;
                fornecedor = Fornecedor.BuscaPorId(this.IdFornecedor);
                return fornecedor;
            }

        }

        public static List<Produto> BuscaPorPedidoId(int idPedido)
        {

            var dados = Database.Produto.BuscarPorPedidoId(idPedido);
            var produtos = new List<Produto>();
            
            foreach (DataRow row in dados.Rows)
            {
                var produto = new Produto();
                produto.Id = int.Parse(row["IdProduto"].ToString());
                produto.Nome = row["Nome"].ToString();
                produto.IdFornecedor = int.Parse(row["IdFornecedor"].ToString());
                produto.Valor = double.Parse(row["Valor"].ToString());
                produtos.Add(produto);
            }
            return produtos;
        }

        public static List<Produto> Busca()
        {
            var produtos = new List<Produto>();
            var dados = Database.Produto.Buscar();
            
            foreach (DataRow row in dados.Rows)
            {
                var produto = new Produto();
                produto.Id = int.Parse(row["IdProduto"].ToString());
                produto.Nome = row["Nome"].ToString();
                produto.IdFornecedor = int.Parse(row["idFornecedor"].ToString());
                produto.Valor = double.Parse(row["Valor"].ToString());
                produtos.Add(produto);
            }
            return produtos;
        }
    }
}

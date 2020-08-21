using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Fornecedor
    {
        public int Id;
        public string Nome;
        public string cnpj;

        public static List<Fornecedor> Busca()
        {
            var fornecedors = new List<Fornecedor>();
            var dados = Database.Fornecedor.Buscar();
            foreach (DataRow row in dados.Rows)
            {
                var fornecedor = new Fornecedor();
                fornecedor.Id = int.Parse(row["idFornecedor"].ToString());
                fornecedor.Nome = row["Nome"].ToString();
                fornecedor.cnpj = row["cnpj"].ToString();
                fornecedors.Add(fornecedor);
            }
            return fornecedors;
        }

        public static Fornecedor BuscaPorId(int id)
        {
            var dados = Database.Fornecedor.BuscarPorIdFornecedor(id);
            var fornecedor = new Fornecedor();
            foreach (DataRow row in dados.Rows)
            {
                fornecedor.Id = int.Parse(row["idFornecedor"].ToString());
                fornecedor.Nome = row["Nome"].ToString();
                fornecedor.cnpj = row["cnpj"].ToString();
            }

            return fornecedor;
        }

    }
}

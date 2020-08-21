using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            var pedidos = Pedido.Busca();

            foreach (var pedido in pedidos)
            {
                Console.WriteLine("======== Pedido ======");
                Console.WriteLine("Cliente: " + pedido.Cliente.Nome);
                foreach (var produto in pedido.Produtos)
                {
                    Console.WriteLine("Produto: " + produto.Nome);
                    Console.WriteLine("Valor: " + produto.Valor);
                    Console.WriteLine("Fornecedor do produto: " + produto.Fornecedor.Nome);
                }
                Console.WriteLine("Valor total: " + pedido.ValorTotal);
            }

            Console.ReadKey();
        }
    }
}

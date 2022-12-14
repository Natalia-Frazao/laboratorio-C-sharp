using ProjetoOO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoOO.Testes
{
    public class TesteProdutoIsento
    {
        public static void Main(String[] args)
        {
            List<ProdutoIsento> listaProdutoIsento = new List<ProdutoIsento>();

            ProdutoIsento produtoIsento = new ProdutoIsento();
            produtoIsento.Id = 1;
            produtoIsento.Nome = "Vacina";
            produtoIsento.PrecoUnitario = 250;
            produtoIsento.Quantidade = 1000;
            produtoIsento.Categoria = new Categoria() { Nome = "Saúde (Isento)" };

            listaProdutoIsento.Add(produtoIsento);

            produtoIsento = new ProdutoIsento();
            produtoIsento.Id = 2;
            produtoIsento.Nome = "Use a Cabeça: Java";
            produtoIsento.PrecoUnitario = 112.9F;
            produtoIsento.Quantidade = 5;
            produtoIsento.Categoria = new Categoria() { Nome = "Livros (Isento)" };

            listaProdutoIsento.Add(produtoIsento);

            produtoIsento = new ProdutoIsento();
            produtoIsento.Id = 3;
            produtoIsento.Nome = "Macbook Pro";
            produtoIsento.PrecoUnitario = 20000.00F;
            produtoIsento.Quantidade = 11;
            produtoIsento.Categoria = new Categoria() { Nome = "Informática" };

            listaProdutoIsento.Add(produtoIsento);

            foreach (var item in listaProdutoIsento)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}

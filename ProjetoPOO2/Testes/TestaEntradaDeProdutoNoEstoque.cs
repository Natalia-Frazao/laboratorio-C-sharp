using ProjetoOO.Model;
using ProjetoPOO2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPOO2.Testes
{
    public class TestaEntradaDeProdutoNoEstoque
    {
        public static void Main(String[] args)
        {
            Estoque estoque = new Estoque();

            Produto produto = new Produto();
            produto.Id = 4;
            produto.Nome = "Bala 7 Belo";
            produto.PrecoUnitario = 0.1F;
            produto.Quantidade = 5000;
            produto.Categoria = new Categoria() { Nome = "Alimentos" };

            try
            {
                estoque.RegistrarEntrada(produto);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                estoque.RegistrarSaida(produto);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
        
    }
}

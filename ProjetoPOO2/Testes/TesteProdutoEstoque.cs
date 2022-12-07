using Microsoft.Win32;
using ProjetoOO.Model;
using ProjetoPOO2.Model;
using System;
using System.Data;

public class TestaEntradadeProdutoEmEstoque
{
        public static void Main(String[] args)
        {
            Estoque estoque = new Estoque();

            Produto produto = new Produto();
            produto.Id = 3;
            produto.Nome = "MacBook Pro";
            produto.PrecoUnitario = 112.9F;
            produto.Quantidade = 5;
            produto.Categoria = new Categoria() { Nome = "Livros (Isento)" };

            estoque.RegistrarEntrada(produto);

            Console.WriteLine(estoque.ToString());

            
            produto = new Produto();
            produto.Id = 2;
            produto.Nome= "Vacina";
            produto.PrecoUnitario = 112.9F;
            produto.Quantidade = 5;
            produto.Categoria = new Categoria() { Nome = "Livros (Isento)" };

            estoque.RegistrarEntrada(produto);

            Console.WriteLine(estoque.ToString());



            produto = new Produto();
            produto.Id =1 ;
            produto.Nome = "Vacina";
            produto.PrecoUnitario = 112.9F;
            produto.Quantidade = 5;
            produto.Categoria = new Categoria() { Nome = "Livros (Isento)" };

            estoque.RegistrarEntrada(produto);

            Console.WriteLine(estoque.ToString());
            Console.WriteLine("Tecle enter para fechar..");
            Console.ReadKey();
        }
    
}
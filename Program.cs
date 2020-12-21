using System;
using OBJComoArgumentos.Classes;

namespace OBJComoArgumentos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            
            Produto p1 = new Produto(14, "GTA", 45.99f);
            Produto p2 = new Produto(021, "Fifa", 109f);
            Produto p3 = new Produto(14, "GTA", 45.99f);
            Produto p4 = new Produto(14, "GTA", 45.99f);

            Carrinho carrinho = new Carrinho();
            carrinho.AdicionarProduto(p1);
            carrinho.AdicionarProduto(p2);
            carrinho.AdicionarProduto(p3);
            carrinho.AdicionarProduto(p4);

            carrinho.MostrarProduto();

            
        }
    }
}

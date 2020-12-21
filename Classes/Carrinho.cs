using System;
using System.Collections.Generic;

namespace OBJComoArgumentos.Classes
{
    public class Carrinho
    {
          public float ValorTotal { get; set; }

          List<Produto> carrinho = new List<Produto>();

          public void AdicionarProduto(Produto produto){
              carrinho.Add(produto);
          }

          public void RemoverProduto(Produto produto){
              carrinho.Remove(produto);
          }

          public void MostrarProduto(Produto produto){
              if( carrinho != null){
                  foreach (var item in carrinho)
                  {
                      Console.ForegroundColor = ConsoleColor.Magenta;
                      Console.WriteLine($"R$ {item.Preco.ToString("n2")} -> {item.Nome}");
                      Console.ResetColor();
                  }
              }
          }
                

      }
     }
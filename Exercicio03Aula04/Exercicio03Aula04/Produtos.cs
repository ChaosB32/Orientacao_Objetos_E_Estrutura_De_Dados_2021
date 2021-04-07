using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio03Aula04
{
    class Produtos
    {
        public Produtos(string nome, float quantidade, float preco)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public float Preco { get; private set; }
        public float Quantidade { get; private set; }
        public string Nome { get; private set; }

        public void InformarEstoqueAtual()
        {
            if(Quantidade>0)
                Console.WriteLine($"Atualmente temos {Quantidade} unidade(s)");
            else
                Console.WriteLine("Estamos com o estoque zerado");
        }
        public void ReduzirEstoque(int quantidadeRetirada)
        {
            Quantidade -= quantidadeRetirada;
        }
    }
    
}

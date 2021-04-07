using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio03Aula04
{
    class ItemPedido
    {
        public ItemPedido(Produtos produtos, int quantidadeItens)
        {
            Produtos = produtos;
            QuantidadeItens = quantidadeItens;
        }

        public Produtos Produtos { get; private set; } 
        public int QuantidadeItens { get; private set; }
    }
}

using System;

namespace Exercicio03Aula04
{
    class Program
    {
        static void Main(string[] args)
        {
            Produtos pacotePipoca = new Produtos("Pipoca", 10, 2.99f);
            Produtos pacoteMacarrao = new Produtos("Macarrao", 20, 5.99f);
            Produtos garrafaAzeite = new Produtos("Azeite", 14, 14.99f);

            Cliente bob = new Cliente("Bob Nelson", "111.222.333-99");
            Cliente testolfo = new Cliente("Testolfo Rocha", "999.888.777-66");

            ItemPedido pipoca = new ItemPedido(pacotePipoca,4);
            ItemPedido macarrao = new ItemPedido(pacoteMacarrao, 10);
            ItemPedido azeite = new ItemPedido(garrafaAzeite, 2);
            ItemPedido[] itens = { pipoca, macarrao,azeite };
            Pedido pedidoBob = new Pedido(itens, bob, TipoPagamento.Cartão);
            pedidoBob.RealizarCompra();
            pacotePipoca.InformarEstoqueAtual();
            pacoteMacarrao.InformarEstoqueAtual();
            garrafaAzeite.InformarEstoqueAtual();
            Console.ReadLine();
        }
    }
}

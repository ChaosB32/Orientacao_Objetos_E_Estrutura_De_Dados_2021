using System;

namespace Lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            Bebida cafe = new Bebida(2,3,4,"Café");
            Bebida cerveja = new Bebida(4, 6, 8, "Cerveja");
            Bebida refrigerante = new Bebida(3, 5, 8, "Refrigerante");
            Aperitivo salgadinho = new Aperitivo(5, "Salgadinho");
            Aperitivo salame = new Aperitivo(4, "Salame");


            ItemMenu[] cardapio = { cafe,cerveja,refrigerante,salgadinho,salame };

            Console.WriteLine("-----Cardápio-----");
            foreach (ItemMenu item in cardapio)
            {
                item.ImprimirNome();
                item.ImprimirPreco();
                Console.WriteLine("*_*_*_*_*_*_*");
                Console.ReadLine();
            }
        }
    }
}

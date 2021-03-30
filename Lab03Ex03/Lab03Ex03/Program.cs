using System;

namespace Lab03Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto jogoRE = new JogoDigital("Resident Evil Village", 179, "PS5");
            Produto jogoNR = new JogoDigital("Naruto Ultimate Ninja Storm 4", 130, "PC");
            Produto livro1 = new Livro("Game of Thrones", 80, "Georger R.R. Martin");
            Produto livro2 = new Livro("Harry Potter", 60, "J.K. Rowlling");

            Produto[] produtos = { jogoRE, jogoNR, livro1, livro2 };

            foreach (Produto item in produtos)
            {
                item.InformarDescricao();
                item.InformarPreco();
                Console.WriteLine("-------------");
                Console.ReadLine();
            }
        }
    }
}

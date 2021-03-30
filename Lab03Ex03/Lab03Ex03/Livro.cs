using System;
using System.Collections.Generic;
using System.Text;

namespace Lab03Ex03
{
    class Livro :Produto
    {
        public Livro(string titulo, double preco, string autor) : base(titulo, preco)
        {
            Autor = autor;
        }

        public string Autor { get; private set; }

        public override void InformarDescricao()
        {
            Console.WriteLine($"{Titulo} escrito por {Autor}.");
        }
    }
}

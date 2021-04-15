using System;
using System.Collections.Generic;
using System.Text;

namespace ProvaP1
{
    class Livro:ItemLoja
    {
        public Livro(long id, string titulo, enumGenero genero, string autor, string editora, PessoaJuridica fornecedor, float precoCompra, float precoVenda) :base(id,fornecedor,precoCompra,precoVenda)
        {
            this.titulo = titulo;
            this.genero = genero;
            this.autor = autor;
            this.editora = editora;
        }
        public string titulo { get; private set; }
        public enumGenero genero { get; private set; }
        public string autor { get; private set; }
        public string editora { get; private set; }

        public override void MostrarDescricao()
        {
            Console.WriteLine("ID: "+id+ " Título: " + titulo + " Gênero: "+ genero + " Autor: "+ autor + 
                "\n"+" Editora: "+ editora +" Fornecedor: "+ fornecedor.nome + " Preço de Compra: R$" + precoCompra + " Preço de Venda: R$" + precoVenda);
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
        }
    }
}

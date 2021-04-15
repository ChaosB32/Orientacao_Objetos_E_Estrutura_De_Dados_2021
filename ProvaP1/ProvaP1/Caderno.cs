using System;
using System.Collections.Generic;
using System.Text;

namespace ProvaP1
{
    class Caderno : ItemLoja 
    {
        public Caderno(long id,string nome, int quantidadeFolhas, PessoaJuridica fornecedor, float precoCompra, float precoVenda) :base(id,fornecedor, precoCompra, precoVenda)
        {
            this.nome = nome;
            this.quantidadeFolhas = quantidadeFolhas;
        }

        public string nome { get; private set; }
        public int quantidadeFolhas { get; private set; }

        public override void MostrarDescricao()
        {
            Console.WriteLine("ID: "+id+" Nome: " + nome+ " NºFolhas: "+quantidadeFolhas + "\n"+" Fornecedor: "+ fornecedor.nome + " Preço de compra: R$"+ precoCompra + " Preço de venda: R$"+ precoVenda);
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
        }
    }
}

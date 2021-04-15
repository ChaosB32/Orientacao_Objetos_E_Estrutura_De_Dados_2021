using System;
using System.Collections.Generic;
using System.Text;

namespace ProvaP1
{
    class ItemLoja:IItemRelatorio
    {
        public ItemLoja(long id, PessoaJuridica fornecedor, float precoCompra, float precoVenda)
        {
            this.id = id;
            this.fornecedor = fornecedor;
            this.precoCompra = precoCompra;
            this.precoVenda = precoVenda;
        }

        public long id { get; protected set; }
        public PessoaJuridica fornecedor { get; protected set; }
        public float precoCompra { get; protected set; }
        public float precoVenda { get; protected set; }

        public virtual void MostrarDescricao()
        {
            Console.WriteLine(id +" " + fornecedor.nome + " "+ precoCompra + " "+ precoVenda);
        }
    }
}

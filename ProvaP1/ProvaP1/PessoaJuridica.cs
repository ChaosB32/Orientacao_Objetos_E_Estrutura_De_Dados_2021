using System;
using System.Collections.Generic;
using System.Text;

namespace ProvaP1
{
    class PessoaJuridica : Pessoa
    {
        public PessoaJuridica(string nome,long id, string cnpj, Endereco endereco, string email) :base(nome,id,endereco,email)
        {
            this.cnpj = cnpj;
        }
        public string cnpj { get; private set; }

        public override void MostrarDescricao()
        {
            Console.WriteLine("Nome: "+nome +" ID: " + id + " CNPJ: "+ cnpj + " Endereço: " +endereco.cidade.nome + "-" + endereco.cidade.estado.sigla +" "+ endereco.bairro.Nome + " "+ endereco.rua + " "+ endereco.numero + "\n E-Mail: "+ email);
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
        }
    }
}

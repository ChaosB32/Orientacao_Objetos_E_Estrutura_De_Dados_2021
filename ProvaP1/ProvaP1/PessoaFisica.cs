using System;
using System.Collections.Generic;
using System.Text;

namespace ProvaP1
{
    class PessoaFisica: Pessoa
    {
        public PessoaFisica(string nome,long id, string cpf, Endereco endereco, bool vip, string email):base(nome,id,endereco,email)
        {
            this.cpf = cpf;
            this.vip = vip;
        }
        public string cpf { get; private set; }
        public bool vip { get; private set; }

        public override void MostrarDescricao()
        {
            if(vip == true)
            {
                Console.WriteLine("VIP!!!");
            }
            if(vip == false)
            {
                Console.WriteLine("Não é VIP!!!");
            }
            Console.WriteLine("Nome: "+nome+ " ID: "+ id + " CPF: "+cpf+ " Endereço: " + endereco.cidade.nome+ "-" + endereco.cidade.estado.sigla +" " +endereco.bairro.Nome+ " "+endereco.rua+ " "+ endereco.numero + "\n E-Mail: "+ email);
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
        }
    }
}

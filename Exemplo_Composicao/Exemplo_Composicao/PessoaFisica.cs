using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplo_Composicao
{
    class PessoaFisica:Pessoa
    {
        public PessoaFisica(string nome, string cPF, Sexo sexo, Emprego emprego):base(nome)
        {
            CPF = cPF;
            Sexo = sexo;
            Emprego = emprego;
        }

        public string CPF { get; private set; }
        public Sexo Sexo { get; private set; }
        public Emprego Emprego { get;private set; }
        
    }
    enum Sexo
    {
        Masculino,
        Feminino
    }
}

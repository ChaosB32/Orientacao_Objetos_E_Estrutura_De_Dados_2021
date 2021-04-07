using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio03Aula04
{
    class Cliente
    {
        public Cliente(string nome, string cPF)
        {
            Nome = nome;
            CPF = cPF;
        }

        public string Nome { get; set; }
        public string CPF { get; set; }
    }
}

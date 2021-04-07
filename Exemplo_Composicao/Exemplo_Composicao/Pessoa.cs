using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplo_Composicao
{
    abstract class Pessoa
    {
        public Pessoa(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; protected set; }
    }
}

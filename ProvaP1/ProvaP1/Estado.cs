using System;
using System.Collections.Generic;
using System.Text;

namespace ProvaP1
{
    class Estado
    {
        public Estado(string nome, string sigla)
        {
            this.nome = nome;
            this.sigla = sigla;
        }

        public string nome { get; private set; }
        public string sigla { get; private set; }
    }
}

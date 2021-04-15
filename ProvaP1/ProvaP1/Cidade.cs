using System;
using System.Collections.Generic;
using System.Text;

namespace ProvaP1
{
    class Cidade
    {
        public Cidade(string nome, Estado estado)
        {
            this.nome = nome;
            this.estado = estado;
        }
        public string nome { get; private set; }
        public Estado estado { get; private set; }
    }
}

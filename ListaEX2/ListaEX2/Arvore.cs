using System;
using System.Collections.Generic;
using System.Text;

namespace ListaEX2
{
    class Arvore
    {
        public Arvore(Arvore esquerda, int dado, Arvore direita)
        {
            Esquerda = esquerda;
            Dado = dado;
            Direita = direita;
        }

        public Arvore Esquerda { get; set; }
        public int Dado { get; set; }
        public Arvore Direita { get; set; }
    }
}

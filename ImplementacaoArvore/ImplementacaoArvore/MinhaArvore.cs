﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ImplementacaoArvore
{
    class MinhaArvore
    {
        public MinhaArvore(MinhaArvore esquerda, char dado, MinhaArvore direita)
        {
            Esquerda = esquerda;
            Dado = dado;
            Direita = direita;
        }
        public MinhaArvore Esquerda { get; set; }
        public char Dado { get; set; }
        public MinhaArvore Direita { get; set; }
    }
}

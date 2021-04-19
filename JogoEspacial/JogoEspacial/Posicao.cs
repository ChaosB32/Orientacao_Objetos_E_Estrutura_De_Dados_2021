using System;
using System.Collections.Generic;
using System.Text;

namespace JogoEspacial
{
    class Posicao
    {
        public int Posicao_x { get; set; }
        public int Posicao_y { get; set; }

        public Posicao() { }

        public Posicao(int posicao_x, int posicao_y)
        {
            Posicao_x = posicao_x;
            Posicao_y = posicao_y;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace JogoEspacial
{
    class Asteroide: IObjetoDestrutivel, IObjetoMovel
    {
        public int Energia { get; set; }
        public Posicao Posicao { get; set; }

        public Asteroide(int _energia, Posicao _posicao)
        {
            Energia = _energia;
            Posicao = _posicao;
        }

        public void DanoGrave()
        {
            Energia = Energia - 30;
        }

        public void DanoMedio()
        {
            Energia = Energia - 20;
        }

        public void DanoLeve()
        {
            Energia = Energia - 10;
        }

        public void Movimentar()
        {
            Posicao.Posicao_x = Posicao.Posicao_x + 20;
            Posicao.Posicao_y = Posicao.Posicao_y + 20;
        }
    }
}

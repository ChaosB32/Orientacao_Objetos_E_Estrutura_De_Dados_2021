using System;
using System.Collections.Generic;
using System.Text;

namespace JogoEspacial
{
    class Nave: IObjetoMovel, IObjetoDestrutivel
    {
        public string Nome { get; set; }
        public int Combustivel { get; set; }
        public int Energia { get; set; }
        public int Velocidade { get; set; }
        public Posicao Posicao { get; set; }

        public virtual void Movimentar()
        {
            Posicao.Posicao_x = Posicao.Posicao_x + Velocidade;
            Posicao.Posicao_y = Posicao.Posicao_y + Velocidade;
        }

        public void DanoGrave()
        {
            Energia = Energia - 50;
        }
        public void DanoLeve()
        {
            Energia = Energia - 10;
        }
        public void DanoMedio()
        {
            Energia = Energia - 30;
        }
    }
}

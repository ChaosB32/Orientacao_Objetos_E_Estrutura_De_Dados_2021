using System;
using System.Collections.Generic;
using System.Text;

namespace JogoEspacial
{
    class Tiro: IObjetoMovel
    {
        public Posicao Posicao { get; set; }
        public int VelocidadeTiro { get; set; }
        public int PotenciaTiro { get; set; }

        public Tiro(Posicao _posicao, int _velocidadeTiro, int _potenciaTiro)
        {
            Posicao = _posicao;
            VelocidadeTiro = _velocidadeTiro;
            PotenciaTiro = _potenciaTiro;
        }

        public void Movimentar()
        {
            Posicao.Posicao_x = Posicao.Posicao_x + VelocidadeTiro;
            Posicao.Posicao_y = Posicao.Posicao_y + VelocidadeTiro;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace JogoEspacial
{
    class NaveAtaque: Nave
    {
        public int VelocidadeTiro { get; set; }
        public int PotenciaTiro { get; set; }

        public NaveAtaque(string _nome, int _velocidade, int _energia, int _combustivel,
            Posicao _posicao, int _velocidadeTiro, int _potenciaTiro)
        {
            Nome = _nome;
            Velocidade = _velocidade;
            Energia = _energia;
            Combustivel = _combustivel;
            Posicao = _posicao;
            VelocidadeTiro = _velocidadeTiro;
            PotenciaTiro = _potenciaTiro;
        }
        public NaveAtaque() { }

        public void Atirar()
        {
            Tiro tiro = new Tiro(this.Posicao, this.VelocidadeTiro, this.PotenciaTiro);
        }
    }
}

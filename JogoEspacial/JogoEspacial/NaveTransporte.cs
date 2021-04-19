using System;
using System.Collections.Generic;
using System.Text;

namespace JogoEspacial
{
    class NaveTransporte:Nave
    {
        public int Carga { get; set; }

        public NaveTransporte(string _nome, int _velocidade, int _energia, int _combustivel,
           Posicao _posicao, int _carga)
        {
            Nome = _nome;
            Velocidade = _velocidade;
            Energia = _energia;
            Combustivel = _combustivel;
            Posicao = _posicao;
            Carga = _carga;
        }
        public NaveTransporte() { }

        public override void Movimentar()
        {
            Posicao.Posicao_x = Posicao.Posicao_x + Velocidade - Carga;
            Posicao.Posicao_y = Posicao.Posicao_y + Velocidade - Carga;
        }
    }
}

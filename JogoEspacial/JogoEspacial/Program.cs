using System;

namespace JogoEspacial
{
    class Program
    {
        static void Main(string[] args)
        {
            NaveAtaque naveBob = new NaveAtaque();
            Posicao posInicial = new Posicao();
            posInicial.Posicao_x = 0;
            posInicial.Posicao_y = 0;
            naveBob.Nome = "NaveBob";
            naveBob.Velocidade = 40;
            naveBob.Energia = 100;
            naveBob.Combustivel = 50;
            naveBob.Posicao = posInicial;
            naveBob.PotenciaTiro = 10;
            naveBob.VelocidadeTiro = 60;

            Posicao posicaoNaveTranporteBob = new Posicao();
            NaveTransporte naveTransporteBob = new NaveTransporte("Blue", 20, 120, 70, posInicial, 10);

            Posicao posicaoInicialNavePirata = new Posicao();
            posicaoInicialNavePirata.Posicao_x = 20;
            posicaoInicialNavePirata.Posicao_y = 0;
            NaveAtaque navePirata1 = new NaveAtaque("Pirata 1", 20, 80, 50, posicaoInicialNavePirata, 3, 20);
            NaveAtaque navePirata2 = new NaveAtaque();
            navePirata2.Nome = "Pirata 2";
            navePirata2.Velocidade = 30;
            navePirata2.Energia = 80;
            navePirata2.Combustivel = 60;
            navePirata2.Posicao = posicaoInicialNavePirata;
            navePirata2.PotenciaTiro = 5;
            navePirata2.VelocidadeTiro = 40;

            

            Posicao posicaoInicialAsteroides = new Posicao(0, 0);
            Asteroide asteroidePequeno = new Asteroide(20, posicaoInicialAsteroides);
            naveBob.Movimentar();
            asteroidePequeno.Movimentar();
            navePirata1.Movimentar();
            navePirata1.Atirar();
            naveBob.DanoLeve();
            naveBob.Atirar();
            navePirata1.DanoGrave();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploEncapsulamento
{
    class Carro
    {
        private string modelo;
        private string cor;
        private int anoFabricacao;
        private int velocidadeMaxima;
        private int velocidadeAtual;
        private bool seLigado = false;

        public Carro(string modelo, string cor, int anoFabricacao, int velocidadeMaxima)
        {
            this.modelo = modelo;
            this.cor = cor;
            this.anoFabricacao = anoFabricacao;
            this.velocidadeMaxima = velocidadeMaxima;
        }

        public string Modelo { get => modelo;}
        public string Cor { get => cor;}
        public int AnoFabricacao { get => anoFabricacao;}
        public int VelocidadeMaxima { get => velocidadeMaxima;}
        public int VelocidadeAtual { get => velocidadeAtual;}
        public bool SeLigado { get => seLigado;}

        public Carro()
        {

        }

        

        //métodos
        public void Ligar()
        {
            if (seLigado)
                Console.WriteLine("Carro já está ligado!");
            else
            {
                this.seLigado = true;
                Console.WriteLine("Carro ligado!");
                Console.ReadLine();
            }
        }
        public void Desligar()
        {
            if (seLigado==false)
                Console.WriteLine("Carro já está desligado!");
            else
            {
                this.seLigado = false;
                Console.WriteLine("Carro desligado!");
            }
        }
        public void Acelerar()
        {
            if (seLigado)
            {
                if (velocidadeAtual <= velocidadeMaxima)
                {
                    this.velocidadeAtual = VelocidadeAtual + 10;
                    Console.WriteLine($"Sua velocidade atual é: {velocidadeAtual}");
                }
                else if (velocidadeAtual > velocidadeMaxima)
                {
                    Console.WriteLine("Limite de Velocidade");
                }
            }
            else
            {
                Console.WriteLine("O carro precisa estar ligado!");
            }
        }
        public void Freiar()
        {
            if (velocidadeAtual >= 0)
            {
                this.velocidadeAtual = VelocidadeAtual - 10;
                Console.WriteLine($"Sua velocidade atual é: {velocidadeAtual}");
            }
            else if (velocidadeAtual <0)
            {
                Console.WriteLine("Carro Parado");
            }
        }
    }
}

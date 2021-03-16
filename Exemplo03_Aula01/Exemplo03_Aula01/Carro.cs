using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo03_Aula01
{
    class Carro
    {
        //atributos
        public string modelo;
        public string cor;
        public int anoFabricacao;
        public int velocidadeMaxima;
        public int velocidadeAtual;
        public bool seLigado;

        //construtores
        public Carro(string _modelo,
            string _cor,
            int _anoFabricacao,
            int _velocidadeMaxima)
        {
            this.modelo = _modelo;
            this.cor = _cor;
            this.anoFabricacao = _anoFabricacao;
            this.velocidadeAtual = 0;
            this.velocidadeMaxima = _velocidadeMaxima;
            this.seLigado = false;

        }
        public Carro()
        {

        }
        //métodos
        public void Ligar()
        {
            this.seLigado = true;
            Console.WriteLine("Carro ligado!");
            Console.ReadLine();
        }
        public void Acelerar()
        {
            this.velocidadeAtual = velocidadeAtual + 10;

        }
        public void Freiar()
        {
            this.velocidadeAtual = velocidadeAtual - 10;
        }

    }
}

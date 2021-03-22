using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio02
{
    class ContaCorrente
    {
        private float numero;
        private string nome;
        private float saldo;

        public float Numero { get => numero;}
        public string Nome { get => nome;}
        public float Saldo { get => saldo;}

        public void Sacar()
        {
            if(saldo <= 0)
            {
                Console.WriteLine("Saldo Insuficiente");
                Console.ReadLine();
            }
            else if()
        }

    }
}

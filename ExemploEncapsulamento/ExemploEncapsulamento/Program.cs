using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploEncapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carroBob = new Carro("Fusca","Azul",1978,120);
            
            carroBob.Acelerar();
            Console.ReadLine();
        }
    }
}

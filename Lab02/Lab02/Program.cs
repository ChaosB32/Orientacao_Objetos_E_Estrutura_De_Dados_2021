using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente bob = new ContaCorrente(0.37f, 0.10f, 12345, "Bob", 0);

            bob.VerificarSaldo();
            Console.ReadLine();
            bob.Depositar(5000);
            Console.ReadLine();
            bob.VerificarSaldo();
            Console.ReadLine();


        }
    }
}

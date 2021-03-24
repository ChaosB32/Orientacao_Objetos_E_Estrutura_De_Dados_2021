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
            Contas bob = new Contas(123456, "Bob Nelson", 0, "ContaCorrente");
            Contas testolfo = new Contas(717171, "Testolfo Rocha", 0, "ContaPoupanca");
            Contas lisa = new Contas(654321, "Lisa Leite", 0, "ContaCorrente");

            Console.WriteLine("Bob Depositou R$5000. ", bob.Depositar(5000));
            Console.Write("Saldo Atual: R$");
            bob.VerificarSaldo();
            Console.ReadLine();
            Console.WriteLine("Testolfo Depositou R$1500. ", testolfo.Depositar(1500));
            Console.Write("Saldo Atual: R$");
            testolfo.VerificarSaldo();
            Console.ReadLine();
            Console.WriteLine("Lisa Depositou R$2000. ", lisa.Depositar(2000));
            Console.Write("Saldo Atual: R$");
            lisa.VerificarSaldo();
            Console.ReadLine();
            Console.WriteLine("Bob Transferiu R$600 para a conta {0}. ", testolfo.Numero,bob.Tranferir(600));
            Console.Write("Saldo Atual: R$");
            bob.VerificarSaldo();
            Console.ReadLine();
            Console.WriteLine("Testolfo recebeu R$600 da conta {0}. ", bob.Numero, testolfo.Receber(600));
            Console.Write("Saldo Atual: R$");
            testolfo.VerificarSaldo();
            Console.ReadLine();
            Console.WriteLine("Lisa sacou R$250. ", lisa.Sacar(250));
            Console.Write("Saldo Atual: R$");
            lisa.VerificarSaldo();
            Console.ReadLine();
            Console.WriteLine("Lisa transferiu R$400 para a conta {0}. ", testolfo.Numero, lisa.Tranferir(400));
            Console.Write("Saldo Atual: R$");
            lisa.VerificarSaldo();
            Console.ReadLine();
            Console.WriteLine("Testolfo recebeu R$400 da conta {0}. ", lisa.Numero, testolfo.Receber(400));
            Console.Write("Saldo Atual: R$");
            testolfo.VerificarSaldo();
            Console.ReadLine();
            Console.WriteLine("Testolfo transferiu R$1000 para a conta {0}. ", bob.Numero, testolfo.Tranferir(1000));
            Console.Write("Saldo Atual: R$");
            testolfo.VerificarSaldo();
            Console.ReadLine();
            Console.WriteLine("Bob recebeu R$1000 da conta {0}. ", testolfo.Numero, bob.Receber(1000));
            Console.Write("Saldo Atual: R$");
            bob.VerificarSaldo();
            Console.ReadLine();
            Console.WriteLine("Bob sacou R$900. ", bob.Sacar(900));
            Console.Write("Saldo Atual: R$");
            bob.VerificarSaldo();
            Console.ReadLine();
            Console.WriteLine("Bob transferiu R$1500 para a conta {0}. ", lisa.Numero, bob.Tranferir(1500));
            Console.Write("Saldo Atual: R$");
            bob.VerificarSaldo();
            Console.ReadLine();
            Console.WriteLine("Lisa recebeu R$1500 da conta {0}. ", bob.Numero, lisa.Receber(1500));
            Console.Write("Saldo Atual: R$");
            lisa.VerificarSaldo();
            Console.ReadLine();
            Console.WriteLine("Testolfo transferiu R$1200 para a conta {0}. ", lisa.Numero, testolfo.Tranferir(1200));
            Console.Write("Saldo Atual: R$");
            testolfo.VerificarSaldo();
            Console.ReadLine();
            Console.WriteLine("Lisa recebeu R$1200 da conta {0}. ", testolfo.Numero, lisa.Receber(1200));
            Console.Write("Saldo Atual: R$");
            lisa.VerificarSaldo();
            Console.ReadLine();
            Console.WriteLine("Bob sacou R$2000. ", bob.Sacar(2000));
            Console.Write("Saldo Atual: R$");
            bob.VerificarSaldo();
            Console.ReadLine();
            Console.WriteLine("Lisa depositou R$100. ", lisa.Depositar(100));
            Console.Write("Saldo Atual: R$");
            lisa.VerificarSaldo();
            Console.ReadLine();
            Console.WriteLine("Testolfo transferiu R$700 para a conta {0}. ",bob.Numero, testolfo.Tranferir(700));
            Console.Write("Saldo Atual: R$");
            testolfo.VerificarSaldo();
            Console.ReadLine();
            Console.WriteLine("Bob recebeu R$700 da conta {0}. ",testolfo.Numero, bob.Receber(700));
            Console.Write("Saldo Atual: R$");
            bob.VerificarSaldo();
            Console.ReadLine();
        }
    }
}

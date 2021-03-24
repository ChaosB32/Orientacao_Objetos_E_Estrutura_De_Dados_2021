using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    class Contas
    {
        protected float numero;
        protected string nome;
        protected float saldoAtual;
        protected string tipoConta;

        public Contas(float numero, string nome, float saldoAtual, string tipoConta)
        {
            this.numero = numero;
            this.nome = nome;
            this.saldoAtual = saldoAtual;
            this.tipoConta = tipoConta;
        }
        public float Numero { get => numero; }
        public string Nome { get => nome; }
        public float SaldoAtual { get => saldoAtual; }

        public float Depositar(float x)
        {
            return saldoAtual = saldoAtual + x;
        }

        public float Tranferir(float x)
        {
            if (tipoConta == "ContaPoupanca" && saldoAtual > 0)
            {
                return saldoAtual = saldoAtual - x - (0.15f * (x / 100));
            }
            if (tipoConta == "ContaCorrente" && saldoAtual > 0)
            {
                return saldoAtual = saldoAtual - x - (0.10f * (x / 100));
            }
            return 0;
        }

        public void VerificarSaldo()
        {
            Console.WriteLine(saldoAtual);
        }
        public float Sacar(float x)
        {

            if (tipoConta == "ContaCorrente" && saldoAtual > 0)

            {
                return saldoAtual = saldoAtual - x - (0.37f * (x / 100));
            }
            if (tipoConta == "ContaPoupanca" && saldoAtual > 0)
            {
                return saldoAtual = saldoAtual - x - (0.20f * (x / 100));
            }
            return 0;
        }
        public float Receber(float x)
        {
            return saldoAtual = saldoAtual + x;
        }
    }
}

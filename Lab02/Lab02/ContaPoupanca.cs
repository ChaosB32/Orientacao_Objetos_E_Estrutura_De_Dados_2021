using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    class ContaPoupanca : Contas
    {
        private float tarifaSaqueP;
        private float tarifaTransferenciaP;
        private float valorDepositoP;
        private float valorTransferenciaP;

        public ContaPoupanca(float tarifaSaqueP, float tarifaTransferenciaP, float numero, string nome, float saldoAtual) : base(numero, nome, saldoAtual)
        {
            this.tarifaSaqueP = tarifaSaqueP;
            this.tarifaTransferenciaP = tarifaTransferenciaP;
        }

        public void Depositar()
        {
            saldoAtual = saldoAtual + valorDepositoP;
        }

        public void Tranferir()
        {
            saldoAtual = saldoAtual - valorTransferenciaP;

        }

        public void VerificarSaldo()
        {
            Console.WriteLine(saldoAtual);
        }
        public void Sacar()
        {
            if (saldoAtual <= 0)
            {
                Console.WriteLine("Saldo Insuficiente");
                Console.ReadLine();
            }
        }
    }
}

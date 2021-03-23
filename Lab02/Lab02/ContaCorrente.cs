using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    class ContaCorrente : Contas
    {
        public float tarifaSaqueC;
        public float tarifaTransferenciaC;
        private float valorDepositoC;
        private float valorTransferenciaC;

        public ContaCorrente(float tarifaSaqueC, float tarifaTransferenciaC, float numero, string nome, float saldoAtual) : base(numero, nome, saldoAtual)
        {
            this.tarifaSaqueC = tarifaSaqueC;
            this.tarifaTransferenciaC = tarifaTransferenciaC;
        }
        public float Depositar(float x)
        {
            return saldoAtual = saldoAtual + x;
        }

        public float Tranferir(float x)
        {
            return saldoAtual = saldoAtual - x;

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

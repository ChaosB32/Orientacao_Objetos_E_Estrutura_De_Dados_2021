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

        public Contas(float numero, string nome, float saldoAtual)
        {
            this.numero = numero;
            this.nome = nome;
            this.saldoAtual = saldoAtual;
        }
        public float Numero { get => numero; }
        public string Nome { get => nome; }
        public float SaldoAtual { get => saldoAtual; }
    }
}

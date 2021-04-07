using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplo_Composicao
{
    class Emprego
    {
        public Emprego(string descricao, PessoaJuridica empresa, double salario)
        {
            Descricao = descricao;
            Empresa = empresa;
            Salario = salario;
        }

        public string Descricao { get; private set; }
        public PessoaJuridica Empresa { get; private set; }
        public double Salario { get; private set; }

        public void ReajustarSalarioComPercentual(float taxaPercentual)
        {
            Salario = Salario * (1 + taxaPercentual / 100);
        }
    }
}

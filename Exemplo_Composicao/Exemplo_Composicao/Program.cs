using System;

namespace Exemplo_Composicao
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaJuridica estudioTop = new PessoaJuridica("Bad Minions", "0001.765.123-90", PorteEmpresa.PequenoPorte);
            Emprego empregoDesign = new Emprego("Design Gráfico", estudioTop, 4500);
            Emprego empregoDesenvolvedor = new Emprego("Desenvolvedor", estudioTop, 7000);
            PessoaFisica bob = new PessoaFisica("Bob Nelson", "012.345.678-90", Sexo.Masculino,empregoDesign);
            PessoaFisica testolfo = new PessoaFisica("Testolfo Rocha", "111.222.333-99", Sexo.Masculino, empregoDesenvolvedor);

            Console.WriteLine($"{bob.Nome}({bob.CPF}) trabalha na empresa {bob.Emprego.Empresa.Nome}" +
                $" como {bob.Emprego.Descricao} com o salário de {bob.Emprego.Salario:c}");
            Console.WriteLine($"{testolfo.Nome}({testolfo.CPF}) trabalha na empresa {testolfo.Emprego.Empresa.Nome}" +
                $" como {testolfo.Emprego.Descricao} com o salário de {testolfo.Emprego.Salario:c}");
            Console.ReadLine();
            Console.WriteLine("Após Negociação, o salário do Bob Nelson foi reajustado em 7%");
            bob.Emprego.ReajustarSalarioComPercentual(7);
            Console.WriteLine($"{bob.Nome}({bob.CPF}) trabalha na empresa {bob.Emprego.Empresa.Nome}" +
               $" como {bob.Emprego.Descricao} com o salário de {bob.Emprego.Salario:c}");
            Console.ReadLine();

        }
    }
}

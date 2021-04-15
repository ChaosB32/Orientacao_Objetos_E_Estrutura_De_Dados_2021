using System;
using System.Collections.Generic;
using System.Text;

namespace ProvaP1
{
    class Cadastro
    {
        public  List<PessoaFisica> clientes { get; private set; }
        public  List<PessoaJuridica> fornecedores { get; private set; }

        public Cadastro(List<PessoaFisica> clientes, List<PessoaJuridica> fornecedores)
        {
            this.clientes = clientes;
            this.fornecedores = fornecedores;
        }

        public void AdicionarCliente(PessoaFisica cliente)
        {
            clientes.Add(cliente);
            Console.WriteLine(clientes);
            Console.ReadLine();
        }

        public void RemoverCliente(PessoaFisica cliente)
        {
            clientes.Remove(cliente);
            Console.WriteLine(clientes);
            Console.ReadLine();
        }
        
        public void AdicionarFornecedor(PessoaJuridica fornecedor)
        {
            fornecedores.Add(fornecedor);
            Console.WriteLine(fornecedores);
            Console.ReadLine();
        }

        public void RemoverFornecedor(PessoaJuridica fornecedor)
        {
            fornecedores.Remove(fornecedor);
            Console.WriteLine(fornecedores);
            Console.ReadLine();
        }
    }
}

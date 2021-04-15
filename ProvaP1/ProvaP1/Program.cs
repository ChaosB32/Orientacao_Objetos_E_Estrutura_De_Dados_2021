using System.Collections.Generic;
using System;

namespace ProvaP1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Estado LaEstado = new Estado("Rio de Janeiro", "RJ");
            Cidade LaCidade = new Cidade("Rio de Janeiro", LaEstado);
            Bairro LaBairro = new Bairro("Copacabana");
            Endereco LaE = new Endereco(45, "Edifício Gaveta", LaBairro, LaCidade);
            PessoaJuridica La = new PessoaJuridica("Livros Associados", 300, "99.8888.7777-77"
                , LaE, "faleconosco@associados.com");

            Livro domCasmurro = new Livro(100, "Dom Casmurro", enumGenero.Ficção, "Machado de Assis", "Universal",La, 19.99f, 31.99f);
            Livro unity = new Livro(150, "Unity: design e desenvolvimento de jogos", enumGenero.Games, "William Pereira Alves", "Universal", La, 24.35f, 58.99f);

            Caderno caderno100 = new Caderno(170, "Caderno Capa Dura - Jaspion", 100, La, 10.99f, 25.99f);

            Estado bobEstado = new Estado("Brasília", "DF");
            Cidade bobCidade = new Cidade("Brasília", bobEstado);
            Bairro bobBairro = new Bairro("Bairro Jardim das Oliveiras");
            Endereco bobE = new Endereco(23, "Rua das Classes", bobBairro, bobCidade);
            PessoaFisica bob = new PessoaFisica("Bob Nelson",100, "111.222.333 - 99"
                , bobE, false, "bobNelson@gmail.com");

            Estado testolfoEstado = new Estado("Rio Verde", "GO");
            Cidade testolfoCidade = new Cidade("Rio Verde", testolfoEstado);
            Bairro testolfoBairro = new Bairro("Bairro Operarios");
            Endereco testolfoE = new Endereco(4, "Avenida Abstrata", testolfoBairro, testolfoCidade);
            PessoaFisica testolfo = new PessoaFisica("Testolfo Rocha", 200, "444.555.666-11"
                , testolfoE, true, "testolfoRocha26@gmail.com");

            Estado beloEstado = new Estado("Belo Horizonte", "MG");
            Cidade beloCidade = new Cidade("Belo Horizonte", beloEstado);
            Bairro beloBairro = new Bairro("Bairro Monges Unidos");
            Endereco beloE = new Endereco(26, "Vale das Heranças", beloBairro, beloCidade);
            PessoaFisica belo = new PessoaFisica("Belo Teste", 200, "999.888.777-72"
                , beloE, true, "Testebelo@gmail.com");

            domCasmurro.MostrarDescricao();
            unity.MostrarDescricao();
            caderno100.MostrarDescricao();
            bob.MostrarDescricao();
            testolfo.MostrarDescricao();
            belo.MostrarDescricao();
            La.MostrarDescricao();
        }
    }
}

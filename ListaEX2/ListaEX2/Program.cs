using System;
using System.Collections.Generic;

namespace ListaEX2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arvores = new List<int> { 59, 103, 48, 33, 51, 38, 79, 1, 235, 121, 223, 161 };

            Arvore arvore161 = new Arvore(null, arvores[11], null);
            Arvore arvore223 = new Arvore(arvore161, arvores[10], null);
            Arvore arvore121 = new Arvore(null, arvores[9], null);
            Arvore arvore235 = new Arvore(arvore121, arvores[8], arvore223);
            Arvore arvore1 = new Arvore(null, arvores[7], null);
            Arvore arvore79 = new Arvore(null, arvores[6], null);
            Arvore arvore38 = new Arvore(arvore1, arvores[5], null);
            Arvore arvore51 = new Arvore(null, arvores[4], null);
            Arvore arvore33 = new Arvore(null, arvores[3], arvore38);
            Arvore arvore48 = new Arvore(arvore33, arvores[2], arvore51);
            Arvore arvore103 = new Arvore(arvore79, arvores[1], arvore235);
            Arvore arvore59 = new Arvore(arvore48, arvores[0], arvore103);
            Console.WriteLine("Percorrimento Pré-fixado:");
            PercorrimentoPreFixado(arvore59);
            Console.WriteLine();
            Console.WriteLine("Percorrimento In-fixado:");
            PercorrimentoInFixado(arvore59);
            Console.WriteLine();
            Console.WriteLine("Percorrimento Pós-fixado:");
            PercorrimentoPosFixado(arvore59);
            Console.ReadLine();
            RetornarQtdeDeNos(arvores);
            Console.ReadLine();
            RetornarMaiorValor(arvores);
            Console.ReadLine();
        }

        static void PercorrimentoPreFixado(Arvore arvore)
        {
            if (arvore != null)
            {
                Console.Write($"{arvore.Dado}   ");
                PercorrimentoPreFixado(arvore.Esquerda);
                PercorrimentoPreFixado(arvore.Direita);
            }
        }

        static void PercorrimentoInFixado(Arvore arvore)
        {
            if (arvore != null)
            {
                PercorrimentoInFixado(arvore.Esquerda);
                Console.Write($"{arvore.Dado}   ");
                PercorrimentoInFixado(arvore.Direita);
            }
        }

        static void PercorrimentoPosFixado(Arvore arvore)
        {
            if (arvore != null)
            {
                PercorrimentoPosFixado(arvore.Esquerda);
                PercorrimentoPosFixado(arvore.Direita);
                Console.Write($"{arvore.Dado}   ");
            }
        }
        static void RetornarQtdeDeNos(List<int> arvores)
        {
            Console.WriteLine($"Tem {arvores.Count} nós na arvore");
        }
        static void RetornarMaiorValor(List<int> arvores)
        {
            if (arvores.Count == 0)
            {
                throw new InvalidOperationException("Empty list");
            }
            int max = int.MinValue;
            foreach (int type in arvores)
            {
                if (type > max)
                {
                    max = type;
                }
            }
            Console.WriteLine(max);
        }
    }
}

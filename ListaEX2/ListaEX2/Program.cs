using System;

namespace ListaEX2
{
    class Program
    {
        static void Main(string[] args)
        {

            Arvore arvore161 = new Arvore(null, 161, null);
            Arvore arvore223 = new Arvore(arvore161, 223, null);
            Arvore arvore121 = new Arvore(null, 121, null);
            Arvore arvore235 = new Arvore(arvore121, 235, arvore223);
            Arvore arvore1 = new Arvore(null, 1, null);
            Arvore arvore79 = new Arvore(null, 79, null);
            Arvore arvore38 = new Arvore(arvore1, 38, null);
            Arvore arvore51 = new Arvore(null, 51, null);
            Arvore arvore33 = new Arvore(null, 33, arvore38);
            Arvore arvore48 = new Arvore(arvore33, 48, arvore51);
            Arvore arvore103 = new Arvore(arvore79, 103, arvore235);
            Arvore arvore59 = new Arvore(arvore48, 59, arvore103);
            Console.WriteLine("Percorrimento Pré-fixado:");
            PercorrimentoPreFixado(arvore59);
            Console.WriteLine();
            Console.WriteLine("Percorrimento In-fixado:");
            PercorrimentoInFixado(arvore59);
            Console.WriteLine();
            Console.WriteLine("Percorrimento Pós-fixado:");
            PercorrimentoPosFixado(arvore59);
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
    }
}

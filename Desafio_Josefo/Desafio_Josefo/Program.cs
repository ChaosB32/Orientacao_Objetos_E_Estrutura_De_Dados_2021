using System;
using System.Collections.Generic;

namespace Desafio_Josefo
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciar a fila
            Queue<int> filaJudeus = new Queue<int>();

            for (int i = 1; i <= 41; i++)
            {
                filaJudeus.Enqueue(i);
            }

            while(filaJudeus.Count > 2)
            {
                filaJudeus.Enqueue(filaJudeus.Dequeue());
                filaJudeus.Enqueue(filaJudeus.Dequeue());
                Console.WriteLine($"Será sacrificado o número {filaJudeus.Peek()}");
                filaJudeus.Dequeue();
            }
            Console.ReadLine();
            foreach (var item in filaJudeus)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}

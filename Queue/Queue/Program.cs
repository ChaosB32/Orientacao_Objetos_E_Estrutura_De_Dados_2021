using System;
using System.Collections.Generic;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomeCriancas = {"Alice","BobNelson","Charlie","Dani",
            "Eva","Franz","Gal","Helo","Eve","Juka"};

            Queue<string> filaCantina = new Queue<string>();

            foreach (var item in nomeCriancas)
            {
                filaCantina.Enqueue(item);
            }

            while (filaCantina.Count > 0)
            {
                Console.WriteLine($"O lanche do(a) aluno(a){filaCantina.Peek()}");
                filaCantina.Dequeue();
                Console.ReadLine();
            }
        }
    }
}

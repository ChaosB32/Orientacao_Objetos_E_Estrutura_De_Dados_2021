using System;

namespace ImplementarPilhaPorArray
{
    class Program
    {
        static void Main(string[] args)
        {
            MinhaPilha primeiraPilha = new MinhaPilha(3);
            primeiraPilha.Pop();
            primeiraPilha.Push("Goccom");
            primeiraPilha.Push("Kazuto");
            primeiraPilha.Push("Sr.M");
            primeiraPilha.Pop();
            primeiraPilha.Push("Bob Nelson");
            Console.WriteLine("\nElementos na Pilha:");
            primeiraPilha.ImprimirPilha();
            primeiraPilha.Peek();
            Console.ReadLine();
        }
    }
}

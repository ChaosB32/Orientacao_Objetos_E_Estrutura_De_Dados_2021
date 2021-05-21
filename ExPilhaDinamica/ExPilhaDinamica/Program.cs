using System;

namespace ExPilhaDinamica
{
    class Program
    {
        static void Main(string[] args)
        {
            PilhaDinamica pilhaNumeros = new PilhaDinamica();
            pilhaNumeros.Pop();
            pilhaNumeros.Push(2);
            pilhaNumeros.Push(4);
            pilhaNumeros.Push(6);
            pilhaNumeros.Push(8);
            pilhaNumeros.Push(10);
            Console.WriteLine(pilhaNumeros.Pop());
            Console.WriteLine(pilhaNumeros.Pop());
            Console.WriteLine(pilhaNumeros.Pop());
            Console.WriteLine(pilhaNumeros.Pop());
            Console.WriteLine(pilhaNumeros.Pop());
            pilhaNumeros.ElementosPilha();
            pilhaNumeros.Push(2);
            pilhaNumeros.Push(4);
            pilhaNumeros.Push(6);
            pilhaNumeros.Push(8);
            pilhaNumeros.Push(10);
            Console.ReadLine();
            pilhaNumeros.ElementosPilha();
            Console.ReadLine();
        }
    }
}

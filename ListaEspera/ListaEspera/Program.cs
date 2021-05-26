using System;

namespace ListaEspera
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fila com 4 números:");
            FilaEstatica minhaFila = new FilaEstatica(4);
            minhaFila.Enfileirar(5);
            minhaFila.Enfileirar(10);
            minhaFila.Enfileirar(12);
            minhaFila.Enfileirar(6);
            Console.WriteLine("Imprimir os valores da fila:");
            minhaFila.Imprimir();
            Console.ReadLine();
        }
    }
}

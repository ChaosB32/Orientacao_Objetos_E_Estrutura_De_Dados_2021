using System;
using System.Collections.Generic;
using System.Text;

namespace ListaEspera
{
    class FilaEstatica
    {
        public FilaEstatica(int elementos)
        {
            Dados = new int[elementos];
            Inicio = 0;
            Fim = -1;
        }

        public int Inicio { get; set; }
        public int Fim { get; set; }
        public int[] Dados { get; set; }

        public void Enfileirar(int numero)
        {
            if (Fim >= Dados.Length - 1)
            {
                Console.WriteLine("A fila está cheia!");
                return;
            }
            else
            {
                Fim++;
                Dados[Fim] = numero;
                Console.WriteLine($"Elemento {numero} foi inserido!");
            }
        }

        public void Imprimir()
        {
            if (Fim == -1)
            {
                Console.WriteLine("A fila está vazia!");
                return;
            }
            for (int i = Inicio; i <= Fim; i++)
            {
                Console.WriteLine(Dados[i]);
            }
        }
    }
}

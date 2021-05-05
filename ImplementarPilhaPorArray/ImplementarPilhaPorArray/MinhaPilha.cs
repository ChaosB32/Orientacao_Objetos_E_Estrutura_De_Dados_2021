using System;
using System.Collections.Generic;
using System.Text;

namespace ImplementarPilhaPorArray
{
    class MinhaPilha
    {
        public int Tamanho { get; set; }
        public int Topo { get; set; }
        public string[] Dados { get; set; }

        public MinhaPilha(int tamanho)
        {
            Tamanho = tamanho;
            Topo = -1;
            Dados = new string[tamanho];
        }

        public void Push(string elemento)
        {
            if(Topo < Tamanho-1)
            {
                Topo = Topo + 1;
                Dados[Topo] = elemento;
                Console.WriteLine("Push: " + elemento);
            }
            else
            {
                Console.WriteLine("Pilha já está cheia!");
            }
        }
        public void Pop()
        {
            if(Topo == -1)
            {
                Console.WriteLine("A pilha está vazia!");
            }
            else
            {
                Console.WriteLine("Pop: " + Dados[Topo]);
                Topo = Topo - 1;
            }
        }
        public void ImprimirPilha()
        {
            if(Topo == -1)
            {
                Console.WriteLine("A pilha está vazia!");
            }
            else
            {
                for (int i = Topo; i >= 0; i--)
                {
                    Console.WriteLine(Dados[i]);
                }
            }
        }
        public string Peek()
        {
            return Dados[Topo];
        }
    }
}

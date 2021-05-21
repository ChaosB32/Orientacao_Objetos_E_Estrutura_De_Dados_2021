using System;
using System.Collections.Generic;
using System.Text;

namespace ExPilhaDinamica
{
    class Nodo
    {
        public int Dado { get; set; }
        public Nodo Elo { get; set; } = null;

    }
    class PilhaDinamica
    {
        public PilhaDinamica()
        {
            Topo = null;
        }

        public Nodo Topo { get; set; }

        public void Push(int dado)
        {
            Nodo novoNodo = new Nodo();
            novoNodo.Dado = dado;
            novoNodo.Elo = Topo;
            Topo = novoNodo;
        }

        public int Pop()
        {
            Nodo auxiliar;
            if (Topo == null)
            {
                Console.WriteLine("Pilha vazia!");
                return -1;
            }
            else
            {
                auxiliar = Topo;
                Topo = auxiliar.Elo;
                return auxiliar.Dado;
            }
        }

        public int Peek()
        {
            if (Topo == null)
            {
                Console.WriteLine("Pilha vazia!");
                return -1;
            }
            else
            {
                return Topo.Dado;
            }
        }

        public void ElementosPilha()
        {
            Nodo auxiliar;
            auxiliar = Topo;
            if (Topo == null)
            {
                Console.WriteLine("Pilha vazia!");
                return;
            }
            while (auxiliar != null)
            {
                Console.WriteLine(auxiliar.Dado);
                auxiliar = auxiliar.Elo;
            }
        }
    }
}

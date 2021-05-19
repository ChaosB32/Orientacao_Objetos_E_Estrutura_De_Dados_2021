using System;
using System.Collections.Generic;
using System.Text;

namespace PilhaDinamica
{
    class MinhaPilhaDinamica
    {
        public MinhaPilhaDinamica()
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
            if(Topo == null)
            {
                Console.WriteLine("A pilha está vazia");
                return -1;
            }
            else
            {
                auxiliar = Topo;
                Topo = auxiliar.Elo;
                return auxiliar.Dado;
            }
        }
    }
}

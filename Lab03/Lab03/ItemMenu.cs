using System;
using System.Collections.Generic;
using System.Text;

namespace Lab03Ex05
{
    class ItemMenu
    {
        public ItemMenu(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; protected set; }


        public virtual void ImprimirPreco()
        {
        }
        public void ImprimirNome()
        {
            Console.WriteLine($"---{Nome}---");
        }
    }
}

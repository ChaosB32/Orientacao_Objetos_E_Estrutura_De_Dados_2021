using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio03
{
    abstract class ItemMenu
    {
        public string Nome { get; private set; }

        public ItemMenu(string nome)
        {
            Nome = nome;
        }
        public virtual void ImprimirNome()
        {
            Console.WriteLine($">>>> {Nome}");
        }
        public abstract void ImprimirPreco();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio03
{
    class ItemMenu
    {
        public ItemMenu (string nome)
        {
            Nome = nome;
        }

        public string Nome { get; protected set; }


        protected void ImprimirPreco()
        {

        }
        protected void ImprimirNome()
        {

        }

    }
}

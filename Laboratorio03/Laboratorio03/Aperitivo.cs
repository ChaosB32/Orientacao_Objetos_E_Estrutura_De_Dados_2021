using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio03
{
    class Aperitivo : ItemMenu
    {
        public Aperitivo(float precoA) : base(nome)
        {
            PrecoA = precoA;
        }

        public float PrecoA { get; protected set; }

    }
}

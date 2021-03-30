using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio03
{
    class Bebida : ItemMenu
    {
        public Bebida(float precoP, float precoM, float precoG) : base(nome)
        {
            PrecoP = precoP;
            PrecoM = precoM;
            PrecoG = precoG;
        }

        public float PrecoP { get; protected set; }
        public float PrecoM { get; protected set; }
        public float PrecoG { get; protected set; }


    }
}

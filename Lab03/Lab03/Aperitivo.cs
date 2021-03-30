using System;
using System.Collections.Generic;
using System.Text;

namespace Lab03Ex05
{
    class Aperitivo:ItemMenu
    {
        public Aperitivo(float precoA,string nome) : base(nome)
        {
            PrecoA = precoA;
        }

        public float PrecoA { get; protected set; }

        public override void ImprimirPreco()
        {
            Console.WriteLine($"{PrecoA.ToString("C")}");
        }
    }
}

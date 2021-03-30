using System;
using System.Collections.Generic;
using System.Text;

namespace Lab03
{
    class Bebida:ItemMenu
    {
        public Bebida(float precoP, float precoM, float precoG,string nome) : base(nome)
        {
            PrecoP = precoP;
            PrecoM = precoM;
            PrecoG = precoG;
        }

        public float PrecoP { get; protected set; }
        public float PrecoM { get; protected set; }
        public float PrecoG { get; protected set; }

        public override void ImprimirPreco()
        {
            Console.WriteLine($"Pequeno: {PrecoP.ToString("C")}");
            Console.WriteLine($"Médio: {PrecoM.ToString("C")}");
            Console.WriteLine($"Grande: {PrecoG.ToString("C")}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio03
{
    class Bebida : ItemMenu
    {
        public double PrecoPequena { get; set; }
        public double PrecoMedia { get; set; }
        public double PrecoGrande { get; set; }

        public Bebida(string nome,double precoPequena, double precoMedia, double precoGrande):base(nome)
        {
            PrecoPequena = precoPequena;
            PrecoMedia = precoMedia;
            PrecoGrande = precoGrande;
        }
        public override void ImprimirPreco()
        {
            ImprimirNome();
            Console.WriteLine($"P: {PrecoPequena:C}");
            Console.WriteLine($"M: {PrecoMedia:C}");
            Console.WriteLine($"G: {PrecoGrande:C}");
        }
    }
}

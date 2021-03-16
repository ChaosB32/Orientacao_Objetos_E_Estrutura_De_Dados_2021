using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio01
{
    class Program
    {
        static void Main(string[] args)
        {
            var Usuario1 = new Usuario();
            Usuario1.nome = "Bob Nelson";
            Usuario1.idade = 37;
            Usuario1.altura = 1.70f;
            Usuario1.peso = 78f;

            var Usuario2 = new Usuario();
            Usuario2.nome = "Testolfo Rocha";
            Usuario2.idade = 43;
            Usuario2.altura = 1.65f;
            Usuario2.peso = 60f;

            var Usuario3 = new Usuario();
            Usuario3.nome = "Lisa Leite";
            Usuario3.idade = 22;
            Usuario3.altura = 1.72f;
            Usuario3.peso = 92f;

            Usuario1.CalcularImc();
            Usuario2.CalcularImc();
            Usuario3.CalcularImc();
        }
    }
}

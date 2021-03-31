using System;

namespace ExercicioFormasGeometricas
{
    class Program
    {
        static void Main(string[] args)
        {
            TrianguloEquilatero triangulo = new TrianguloEquilatero(9,"Triângulo");
            Hexagono hexagono = new Hexagono(9,"Hexagono");
            Quadrado quadrado = new Quadrado(9,"Quadrado");
            Circulo circulo = new Circulo(9,"Círculo");

            FormaGeometrica[] formasCriadas = { triangulo, hexagono, quadrado, circulo };

            foreach (FormaGeometrica item in formasCriadas)
            {
                Console.WriteLine($"{item.Descricao}:");
                Console.WriteLine("");
                Console.WriteLine($"Área:{item.CalcularArea()}");
                Console.WriteLine($"Perímetro: {item.CalcularPerimetro()}");
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}

using System;

namespace ExemploEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o número do mês que deseja fazer a reserva: ");
            //int mesReserva = int.Parse(Console.ReadLine());
            string mesReserva = Console.ReadLine();
            switch (mesReserva)
            {
                case ((int)MesesAltaEstacao.Dezembro):
                    Console.WriteLine($"{MesesAltaEstacao.Dezembro} é um mês de alta temporada.");
                    break;
            }
            Console.ReadLine();

        }
    }
    enum MesesAltaEstacao
    {
        Dezembro = 12,
        Janeiro = 1,
        Fevereiro = 2,
        Junho = 6,
        Julho = 7
    }
}

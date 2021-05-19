using System;

namespace ExPalindromo
{
    class Program
    {
        public static bool Palindromo(string letras)
        {
            int min = 0;
            int max = letras.Length - 1;
            while (true)
            {
                if (min > max)
                {
                    return true;
                }

                char a = letras[min];
                char b = letras[max];

                while (!char.IsLetterOrDigit(a))
                {
                    min++;
                    if (min > max)
                    {
                        return true;
                    }
                    a = letras[min];
                }

                while (!char.IsLetterOrDigit(b))
                {
                    max--;
                    if (min > max)
                    {
                        return true;
                    }
                    b = letras[max];
                }

                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;                
                }
                min++;
                max--;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Insira uma palavra: (Resultado true = É um palíndromo. Resultado false = Não é um palíndromo.)");
            string palavra = Console.ReadLine();
            Console.WriteLine("{0} = {1}", palavra, Palindromo(palavra));
        }
    }
}

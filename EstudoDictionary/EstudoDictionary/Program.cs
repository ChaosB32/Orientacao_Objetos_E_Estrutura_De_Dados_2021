using System;
using System.Collections.Generic;

namespace EstudoDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            string textoAnalizado = "Minha terra tem palmeiras, Onde canta o Sabiá; As aves, que aqui gorjeiam," +
                "Não gorjeiam como lá. Nosso céu tem mais estrelas, Nossas várzeas têm mais flores, " +
                "Nossos bosques tèm mais vida, Nossa vida mais amores.";

            Dictionary<string, int> resultado = VerificarQuantidadePalavras(textoAnalizado);
            foreach (var item in resultado)
            {
                Console.WriteLine($"A palavra [{item.Key}] se repete {item.Value} vez(es)");
            }
            Console.ReadLine();
            Console.WriteLine("Agora com o SortDictionary");
            SortedDictionary<string, int> resultadoOrdenado = VerificarQuantidadePalavrasOrdenadas(textoAnalizado);
            foreach (var item in resultadoOrdenado)
            {
                Console.WriteLine($"A palavra [{item.Key}] se repete {item.Value} vez(es)");
            }
            Console.ReadLine();
        }

        static Dictionary<string,int> VerificarQuantidadePalavras(string texto)
        {
            Dictionary<string, int> palavrasColetadas = new Dictionary<string, int>();
            string[] palavras = texto.Split(' ', ',', ';', '.');

            foreach (var item in palavras)
            {
                if(item.Length != 0)
                {
                    int count;
                    if(!palavrasColetadas.TryGetValue(item.ToLower(),out count))
                    {
                        count = 0;
                    }
                        palavrasColetadas[item.ToLower()] = count + 1;
                }
            }
            return palavrasColetadas;
        }

        static SortedDictionary<string, int> VerificarQuantidadePalavrasOrdenadas(string texto)
        {
            SortedDictionary<string, int> palavrasColetadas = new SortedDictionary<string, int>();
            string[] palavras = texto.Split(' ', ',', ';', '.');

            foreach (var item in palavras)
            {
                if (item.Length != 0)
                {
                    int count;
                    if (!palavrasColetadas.TryGetValue(item.ToLower(), out count))
                    {
                        count = 0;
                    }
                    palavrasColetadas[item.ToLower()] = count + 1;
                }
            }
            return palavrasColetadas;
        }
    }
}

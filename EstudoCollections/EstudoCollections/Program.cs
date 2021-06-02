using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace EstudoCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            // ArrayList
            ArrayList meuPrimeiroArrayList = new ArrayList();
            meuPrimeiroArrayList.Add("Bob Nelson");
            meuPrimeiroArrayList.Add(32);
            meuPrimeiroArrayList.Add(false);
            int elementoArrayList = (int) meuPrimeiroArrayList[1];
            Console.WriteLine(meuPrimeiroArrayList.Contains(false));
            Console.ReadKey();

            //List
            List<string> listaNomes = new List<string>();


            // Exercicio Listas
            // Criar 2 listas com 20 números aleatórios entre 0 e 50
            
            Random r = new Random();
            List<int> listaAleatoria1 = new List<int>();
            List<int> listaAleatoria2 = new List<int>();

            // Criação das listas
            for (int i = 0; i < 20; i++)
            {
                listaAleatoria1.Add(r.Next(0,51));
                listaAleatoria2.Add(r.Next(0,51));
            }

            List<int> listaElementosEmComum = new List<int>();
            // Realizar a união das duas listas
            foreach (var item in listaAleatoria2)
            {
                if (listaAleatoria1.Contains(item))
                {
                    listaAleatoria1.Add(item);
                }
                else
                {
                    listaElementosEmComum.Add(item);
                }
            }

            Console.WriteLine($"Tamanho da lista acumuldada: {listaAleatoria1.Count()}");
            Console.WriteLine("Elementos em comum nas duas listas: ");
            foreach (var item in listaElementosEmComum)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}

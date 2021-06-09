using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEX3
{
    class Program
    {
        static void Main(string[] args)
        {
            //QUESTÃO 1
            string textoAnalisado = "...Uma atividade livre, conscientemente tomada como “não-séria” e exterior à vida habitual" +
                ", mas ao mesmo tempo capaz de absorver o jogador de maneira intensa e total. É uma atividade desligada de todo" +
                " e qualquer interesse material, com a qual não se pode obter qualquer lucro, praticada dentro de limites espaciais" +
                " e temporais próprios, segundo uma certa ordem e certas regras. Promove a formação de grupos sociais com tendência" +
                " a rodearem-se de segredo e a sublinharem sua diferença em relação ao resto do mundo por meio de disfarces ou outros meios semelhantes.";
            VerificarQuantidadePalavras(textoAnalisado);

            //QUESTÃO 4
            //string textoAnalisado = EnviarTexto();

            //QUESTÃO 2
            /*Dictionary<string, int> resultado = VerificarQuantidadePalavras(textoAnalisado);
            foreach (var item in resultado)
            {
                Console.WriteLine($"A palavra [{item.Key}] se repete {item.Value} vez(es)");
            }*/
            Console.ReadLine();
        }

        //QUESTÃO 4
        private static string EnviarTexto()
        {
            Console.WriteLine("Digite o Texto:");
            string textoAnalisado = Console.ReadLine();
            return textoAnalisado;
        }
        //QUESTÃO 2
        static Dictionary<string, int> VerificarQuantidadePalavras(string texto)
        {
            Dictionary<string, int> palavrasColetadas = new Dictionary<string, int>();
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
            //QUESTÃO 1
            Console.WriteLine($"Há {palavrasColetadas.Count()} palavras diferentes.");
            return palavrasColetadas;
        }
        
    }
}

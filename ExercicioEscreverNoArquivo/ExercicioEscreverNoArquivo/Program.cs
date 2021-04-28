using System;
using System.IO;
using System.Linq;

namespace ExercicioEscreverNoArquivo
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeArquivo = ConfiguraArquivo();
            StreamWriter writer = new StreamWriter(nomeArquivo);
            int ptBob = 5678;
            int ptTestolfo = 5432;
            int ptClaudio = 6655;
            int ptMario = 5109;
            int[] pt = { ptBob, ptTestolfo, ptClaudio, ptMario };
            
            writer.WriteLine("Bob Nelson "+ptBob);
            writer.WriteLine("Testolfo Rocha " + ptTestolfo);
            writer.WriteLine("Cláudio Castelo " + ptClaudio);
            writer.WriteLine("Mário Armário " + ptMario);
            writer.WriteLine("Maior Pontuação: "+ pt.Max());
            writer.Close();

        }
        private static string ConfiguraArquivo()
        {
            string pathDiretorio = "..//..//arquivos/";
            string nomeArquivo = "pontuacao.txt";
            if (!Directory.Exists(pathDiretorio))
            {
                CriarDiretorio(pathDiretorio);
                CriarArquivo(pathDiretorio, nomeArquivo);
            }
            else
            {
                if (!File.Exists(pathDiretorio + nomeArquivo))
                {
                    CriarArquivo(pathDiretorio, nomeArquivo);
                }
            }
            return pathDiretorio + nomeArquivo;
        }

        private static void CriarArquivo(string pathDiretorio, string nomeArquivo)
        {
            File.Create(pathDiretorio + nomeArquivo).Close();
            Console.WriteLine($"Arquivo{nomeArquivo} criado.");
        }

        private static void CriarDiretorio(string pathDiretorio)
        {
            Directory.CreateDirectory(pathDiretorio);
            Console.WriteLine($"Diretório{pathDiretorio} criado.");
        }
    }
}

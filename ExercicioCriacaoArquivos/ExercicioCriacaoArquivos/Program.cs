using System;
using System.IO;

namespace ExercicioCriacaoArquivos
{
    class Program
    {
        static void Main(string[] args)
        {
           string nomeArquivoCriado = ConfiguraArquivo();
            // Primeira forma de leitura
           string[] jogos = File.ReadAllLines(nomeArquivoCriado);
            foreach (var item in jogos)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

            // Segunda forma de Leitura usando o StreamReader
            StreamReader reader = new StreamReader(nomeArquivoCriado);
            string linhaArquivo;
            while((linhaArquivo = reader.ReadLine())!= null)
            {
                Console.WriteLine(linhaArquivo);
            }
            Console.ReadLine();

            // Terceira forma de leitura usando File.OpenText
            StreamReader readerOpenText = File.OpenText(nomeArquivoCriado);
            while (!readerOpenText.EndOfStream)
            {
                Console.WriteLine(readerOpenText.ReadLine());
            }
            Console.ReadLine();
            

            

        }

        private static string ConfiguraArquivo()
        {
            string pathDiretorio = "..//..//arquivos/";
            string nomeArquivo = "configuracoes.txt";
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
            return pathDiretorio+ nomeArquivo;
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

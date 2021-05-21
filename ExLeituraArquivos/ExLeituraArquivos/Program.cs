using System;
using System.IO;


namespace ExLeituraArquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeArquivoCriado = ConfigurarArquivo();

            StreamReader reader = new StreamReader(nomeArquivoCriado);
            string linhaArquivo;
            while ((linhaArquivo = reader.ReadLine()) != null)
            {
                Console.WriteLine(linhaArquivo);
            }
            Console.ReadLine();
        }

        private static string ConfigurarArquivo()
        {
            string pathDiretorio = "..//..//ListaEspera/";
            string nomeArquivo = "listaEspera.txt";
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
            Console.WriteLine($"Arquivo {nomeArquivo} criado.");
        }

        private static void CriarDiretorio(string pathDiretorio)
        {
            Directory.CreateDirectory(pathDiretorio);
            Console.WriteLine($"Diretório {pathDiretorio} criado.");
        }

    }
}


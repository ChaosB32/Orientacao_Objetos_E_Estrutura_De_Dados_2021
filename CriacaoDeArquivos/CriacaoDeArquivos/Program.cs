using System;
using System.IO;

namespace CriacaoDeArquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criar passando um caminho absoluto
            string path = @"D:\Documentos\Programaçao\ProjetosOOED\CriacaoDeArquivos";
            string nomeArquivo = "primeiroArquivo.txt";
            Stream arquivo = File.Create(path+nomeArquivo);

            // Obter diretório destino a partir da basta "Debug" do projeto
            string nomeDiretorioExecucao = System.Environment.CurrentDirectory;
            Console.WriteLine(nomeDiretorioExecucao);
            string pathDiretorio = "..//..//";
            string nomeOutroArquivo = "arquivoCriadoPastaEspecifica.txt";
            Stream outroArquivo = File.Create(pathDiretorio + nomeOutroArquivo);

            //Criar um diretório
            string nomeDiretorio = "Arquivos";
            Directory.CreateDirectory(pathDiretorio+nomeDiretorio);

            string nomeDiretorioArquivos = "ArquivosProjeto2/";
            Directory.CreateDirectory(pathDiretorio + nomeDiretorioArquivos);
            string pathDiretorioArquivos = "..//..//" + nomeDiretorioArquivos;
            string nomeNovoArquivo = "arquivoCriadoPastaEspecificaProjeto.txt";
            File.Create(pathDiretorioArquivos + nomeNovoArquivo);

            //Verificar se arquivo já existe
            string nomeArquivoVerificado = "primeiroArquivo.txt";
            if (File.Exists(nomeArquivoVerificado))
            {
                Console.WriteLine("Arquivo existente...");
            }
            else
            {
                Console.WriteLine("Arquivo não existe");
                Stream streamArquivo = File.Create(nomeArquivoVerificado);
                streamArquivo.Close();
            }

            //verificar se um diretorio já existe
            string nomeDiretorioVerificado = pathDiretorioArquivos;
            if (Directory.Exists(nomeDiretorioVerificado))
            {
                Console.WriteLine("Diretório existente...");
            }
            else
            {
                Console.WriteLine("Diretório não existe");
                Directory.CreateDirectory(nomeDiretorioVerificado);
            }

            // criar um novo diretorio sem chamar explicitamente a classe directory
            string pathNovoDiretorio = "..//..//NovaPasta/";
            Directory.CreateDirectory(pathNovoDiretorio);
            string nomeNovoArquivo2 = "arquivoNovoPastaEspecifica.txt";
            Stream stream = File.Create(pathNovoDiretorio + nomeNovoArquivo2);
            stream.Close();

            //deletar
            File.Delete(pathNovoDiretorio + nomeNovoArquivo2);

            //Alterar nome do arquivo "primeiroArquivo.txt" para "novoPrimeiroArquivo"
            string novoNomeArquivo = "novoPrimeiroArquivo.txt";
            File.Move(nomeArquivoVerificado, novoNomeArquivo);

            Console.ReadLine();
        }
    }
}

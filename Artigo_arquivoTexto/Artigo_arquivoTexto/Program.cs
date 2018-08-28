using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //declarando a biblioteca de entrada e saída de arquivos
                 //a biblioteca IO

namespace Artigo_arquivoTexto
{
    class Program
    {
        private static void Main(string[] args)
        {
            CriaArquivoeEscreve();
        }

        private static void CriaArquivo()
        {
            //declarando a variavel do tipo StreamWriter para 
            //abrir ou criar um arquivo para escrita 
            StreamWriter x;

            //Colocando o caminho fisico e o nome do arquivo a ser criado
            //finalizando com .txt
            string CaminhoArquivo = "C:\\PROJETO-CARLOS\\Artigo_arquivoTexto\\recibo.txt";


            //utilizando o método para criar um arquivo texto
            //e associando o caminho e nome ao metodo
            x = File.CreateText(CaminhoArquivo);
            Console.ReadKey();
        }

        private static void CriaArquivoeEscreve() {
            ////declarando a variavel do tipo StreamWriter para 
            //abrir ou criar um arquivo para escrita 
            StreamWriter x;

            ////Colocando o caminho fisico e o nome do arquivo a ser criado
            //finalizando com .txt
            string CaminhoNome = "C:\\PROJETO-CARLOS\\Artigo_arquivoTexto\\arq01.txt";

            //utilizando o metodo para criar um arquivo texto
            //e associando o caminho e nome ao metodo
            x = File.CreateText(CaminhoNome);

            //aqui, exemplo de escrever no arquivo texto
            //como se fossemos criar um recibo de pagamento

            //escrevendo o titulo
            x.WriteLine("Recibo de Pagamanto");
            //pulando linha sem escrita
            x.WriteLine();
            x.WriteLine();
            //escrevendo conteúdo do recibo
            x.WriteLine("Recebi do Sr: Nome do Pagador");
            x.WriteLine("a quantia de VALOR DO RECIBO (VALOR POR EXTENSO),");
            x.WriteLine("referente ao DESCRIÇÃO DO QUE FOI PAGO... ");
            x.WriteLine("CIDADE, DATA");
            x.WriteLine();
            x.WriteLine();
            x.WriteLine("__________________________________________________");
            x.WriteLine("Nome do pagador");
            x.WriteLine("CPF do pagador: CPF");
            x.WriteLine();

            //fechando o arquivo texto com o método .Close()
            x.Close();
        }


    }
}

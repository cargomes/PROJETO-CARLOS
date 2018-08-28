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
            //CriaArquivo();
            //CriarEscreverArquivo();
            //AbrirArquivo();
            //LendoArquivo();
            AbrirTodoArquivo();
            //AbrirArquivoEditor();
            //DeletaArquivo();
            //Console.BackgroundColor = ConsoleColor.Blue;
            //Console.ForegroundColor = ConsoleColor.Red;
            
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

        //Criando e escrevendo no arquivo

        private static void CriarEscreverArquivo()
        {

            ////declarando a variavel do tipo StreamWriter para 
            //abrir ou criar um arquivo para escrita 
            StreamWriter x;

            ////Colocando o caminho fisico e o nome do arquivo a ser criado
            //finalizando com .txt
            string CaminhoArquivo = "C:\\PROJETO-CARLOS\\Artigo_arquivoTexto\\recibo2.txt";

            //utilizando o metodo para criar um arquivo texto
            //e associando o caminho e nome ao metodo
            x = File.CreateText(CaminhoArquivo);

            //aqui, exemplo de escrever no arquivo texto
            //como se fossemos criar um recibo de pagamento
            x.WriteLine("Recibo de Pagamento");
            x.WriteLine();
            x.WriteLine();
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

            x.Close();
        }

        //Abrir Arquivo
        private static void AbrirArquivo()
        {
            //declarando a variavel do tipo StreamWriter para 
            //abrir ou criar um arquivo para escrita 
            StreamWriter x;

            //Colocando o caminho fisico e o nome do arquivo a ser criado
            //finalizando com .txt
            string CaminhoArquivo = "C:\\PROJETO-CARLOS\\Artigo_arquivoTexto\\recibo2.txt";


            //utilizando o método para criar um arquivo texto
            //e associando o caminho e nome ao metodo
            x = File.AppendText(CaminhoArquivo);

            x.WriteLine();
            x.WriteLine("____________________________________");
            x.WriteLine("Nome do Recebedor");
            x.WriteLine("CPF do Recebedor:");

            x.Close();

        }

        private static void LendoArquivo()
        {
            // declara variável StreamReader
            //que é a variável usada para abrir um arquivo texto para leitura
            StreamReader x;
            string CaminhoArquivo = "C:\\PROJETO-CARLOS\\Artigo_arquivoTexto\\recibo2.txt";

            //abrindo um arquivo texto indicado
            x = File.OpenText(CaminhoArquivo);

            //lendo conteúdo da linha do arquivo texto
            string linha = x.ReadLine();

            //escrevendo este conteúdo na tela
            //mais podemos salvar esse conteúdo em uma variável
            //do tipo string, para utilização no nosso código
            Console.WriteLine(linha);

            //fechar arquivo texto
            x.Close();

            Console.ReadKey();
        }




        // Como não sabemos quantas linhas tem um arquivo texto
        // precisamos de algo que nos avise quando acabar, e isso 
        // é o que o método EndOfStream da variável do tipo StreamReader faz.
        // Este método retorna um valor booleano, no qual retorna “true” 
        // caso esteja na última linha deste arquivo.Então criaremos um loop, 
        // no qual enquanto o método EndOfStream retornar valor booleano “false”, 
        // ele lê o conteúdo da linha, e se ele retornar valor booleano “true”, 
        // quer dizer que chegou ao fim do arquivo, então para de ler e saiu do loop
        // criado.Para isso ser feito, utilizaremos a função while passando 
        // como parâmetro o método EndOfStream da variável StremReader com o simbolo “!=”, 
        // que significa “diferente”, e o valor booleano “true”.

        private static void AbrirTodoArquivo()
        {

            Console.ForegroundColor = ConsoleColor.Yellow;

            //declarando variavél do tipo StreamReader
            StreamReader x;

            //colocando o caminho físico
            string CaminhoArquivo = "C:\\PROJETO-CARLOS\\Artigo_arquivoTexto\\recibo2.txt";

            //abrindo um arquivo
            x = File.OpenText(CaminhoArquivo);

            //enquanto nao retornar valor booleano true 
            //quer dizer que não chegou no fim do arquivo
            while (x.EndOfStream != true)
            { 
                //Lê conteúdo da linha
                string linha = x.ReadLine();

                //escreve na tela o conteudo da linha
                Console.WriteLine(linha);
          
            }
            //após sair do while(enquando), é porque leu todo conteudo
            //então temos q fechar o arquivo q tá aberto
            x.Close();

            Console.ReadKey();
            //esse comando é para não fechar a tela do console
            // fechar só após usuário clicar em uma tecla
        }

        //ABRINDO NUM EDITOR DE TEXTO
        private static void AbrirArquivoEditor()
        {

            //Colocando o endereço físico (caminho do arquivo texto) 
            string CaminhoArquivo = "C:\\PROJETO-CARLOS\\Artigo_arquivoTexto\\recibo2.txt";

            //Abrindo o arquivo texto em um leitor de texto, no caso, 
            //o bloco de notas(notepad)

            System.Diagnostics.Process.Start("notepad", CaminhoArquivo);
            //feito isso, será aperto o bloco de notas com o conteúdo do 
            //arquivo txt

            
        }

        private static void DeletaArquivo()
        {
            //Colocando o endereço físico (caminho do arquivo texto) 
            string CaminhoArquivo = "C:\\PROJETO-CARLOS\\Artigo_arquivoTexto\\recibo2.txt";

            //usando o método para deletar o arquivo texto
            //passando como parâmetro o caminho físico do arquivo
            //que deseja apagar
            File.Delete(CaminhoArquivo);

            //o arquivo texto foi deletado
        }

    }
}

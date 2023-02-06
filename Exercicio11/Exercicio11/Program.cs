using System;
using System.IO; //Biblioteca aonde estão as classes File e FileInfo;

namespace Exercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            string caminhoDeOrigem = @"C:\temp\file1.txt"; //acessando um arquivo existente;
            string caminhoDeDestino = @"C:\temp\file2.txt"; //esse arquivo ainda não existe;
            string caminhoDeDestino2 = @"C:\temp\file3.txt";

            try //bloco de tratamento de exceção
            {
                FileInfo fileInfo = new FileInfo(caminhoDeOrigem); //Instanciamos um objeto que está associado a var caminho de origem;
                fileInfo.CopyTo(caminhoDeDestino);//FileInfo é uma classe que pertence a lib System.IO. Por ser uma classe, pode possuir métodos. Estamos utilizando o método CoyTo();
                // O método CopyTo() serve para copiar o conteúdo de uma variável que ele está associado para outra variável;
                // Neste momento, o método copyto estará criando uma cópia do arquivo associado para o destino informado na variável caminhoDeDestino;

                
                string[] lines = File.ReadAllLines(caminhoDeOrigem); //Associando uma variável para esse objeto
                foreach (string line in lines) //percorrendo o caminhodeorigem
                {
                    File.Copy(caminhoDeOrigem, caminhoDeDestino2); //copiando o conteudo de uma variável para outra                   
                } //Utilizando a class File e fazendo a mesma tarefa de FileInfo;
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
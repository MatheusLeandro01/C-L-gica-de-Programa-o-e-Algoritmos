using System;
using System.IO;
using System.Collections.Generic;

namespace Exercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            string caminho = @"c:\temp\myfolder";            

            try
            {                
                IEnumerable<string> folders = Directory.EnumerateDirectories(caminho, ".", SearchOption.AllDirectories); //ler pastas
                Console.WriteLine("Folders: ");                
                foreach (string folder in folders)
                {
                    Console.WriteLine(folder);
                }

                var files = Directory.EnumerateFiles(caminho, ".", SearchOption.AllDirectories); //ler arquivos
                Console.WriteLine("Files: ");                
                foreach (string file in files)
                {
                    Console.WriteLine(file);
                }

                Directory.CreateDirectory(caminho + @"\newfolder"); //criando pasta
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
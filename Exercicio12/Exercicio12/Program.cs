using System;
using System.IO;

namespace Exercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\file1.txt";

            FileStream fs = null; //stream genérica para acessar recurso de entrada e saída;
            StreamReader sr = null; //stream particular otimazada para o que eu quero;

            try
            {
                fs = new FileStream(path, FileMode.Open); //aqui eu informo o caminho do arquivo e o que eu quero fazer com ele
                //Filestream trabalha em baixo nível
                sr = new StreamReader(fs); //preciso do streamReader para transformar em string
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine(); //transformando o conteúdo de FileStream em string
                    Console.WriteLine(line);
                }                
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
                if (fs != null) fs.Close();
            }
        }
    }
}
using System;
using System.IO;
using System.Collections.Generic;

namespace Exercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            string caminho = @"c:\temp\myfolder\test1.txt";

            try
            {
                Console.WriteLine("Directory Separetor Char: " + Path.DirectorySeparatorChar);
                Console.WriteLine("Path Separetor: " + Path.PathSeparator);
                Console.WriteLine("Get Directory Name: " + Path.GetDirectoryName(caminho)); //informa o diretório
                Console.WriteLine("Get File Name: " + Path.GetFileName(caminho));
                Console.WriteLine("Get Extension: " + Path.GetExtension(caminho));
                Console.WriteLine("Get File Name Without Extension: " + Path.GetFileNameWithoutExtension(caminho));
                Console.WriteLine("Get Full Path: " + Path.GetFullPath(caminho));
                Console.WriteLine("Get Temp Path: " + Path.GetTempPath());
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
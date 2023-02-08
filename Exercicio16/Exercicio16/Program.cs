using System;
using System.IO;
using Entities;

namespace Exercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourceFilePath = @"c:\temp\myfolder\summary.csv";

            try
            {
                string[] lines = File.ReadAllLines(sourceFilePath); // com esse vetor, consilo ler as linhas do meu arquivo .csv

                string sourceFolderPath = Path.GetDirectoryName(sourceFilePath); //esta variável está obtendo o a caminho até a pasta que contém o arquivo                
                string targetFolderPath = sourceFolderPath + @"\out"; // caminho da nova pasta 'out'
                string targetFilePath = targetFolderPath + @"\summary.csv"; // caminho do arquivo novo 'summary.csv'

                Directory.CreateDirectory(targetFolderPath);

                using (StreamWriter sw = File.AppendText(targetFilePath)) //criando o arquivo;
                {
                    foreach (string line in lines)
                    {
                        string[] fields = line.Split(','); //aqui estamos com listas aninhadas
                        string name = fields[0]; //lines[0] fields[0], lines[1] fields[0], lines[2] fields[0]
                        double price = double.Parse(fields[1]); //lines[0] fields[1], lines[1] fields[1], lines[2] fields[1]
                        int quantity = int.Parse(fields[2]); //lines[0] fields[2], lines[1] fields[2], lines[2] fields[2]

                        Product prod = new Product(name, price, quantity);

                        sw.WriteLine($"{prod.Name}, {prod.Total().ToString("F2")}"); //escrevendo os dados no arquivo novo
                    }
                }
                
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
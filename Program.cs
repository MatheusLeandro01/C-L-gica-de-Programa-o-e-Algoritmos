using System; // Foi usado o comando "dotnet new console" para criar este projeto c#.

namespace FirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!"); // comando para printar na tela com quebra de linha.
            Console.Write("Olá Mundo"); // Comando para printar na tela sem quebra de linha.    
            double x = 10.3543; // Criando uma variável do tipo double cujo nome é "x" e valor armazenado nessa variável é "10.3543".
            Console.Writeline(x);  //Imprimindo uma variável.      
        }
    }
}
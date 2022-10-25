using System; // Biblioteca padrão. //Foi usado o comando "dotnet new console" para criar este projeto c#.
using System.Globalization; //importanto biblioteca para utilizar -> "CultureInfo.InvarianteCulture"

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

            Console.Writeline(x.ToString("F4")); // Função ToString serve para definir o limite de tamanho de numeros após o ponto. Ex: "F4" é igual a até 4 numeros após a virgula.
            Console.Writeline(x.ToString("F2", CultureInfo.InvarianteCulture)); //
        }
    }
}
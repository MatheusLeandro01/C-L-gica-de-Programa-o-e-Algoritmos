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

            //Concatenando elementos.
            string nome = "Matheus";
            int idade = 24;
            int anoDeNascimento = 1998;
            Console.WriteLine("Olá meu nome é " + nome + ", tenho " + idade + " anos e nasci no ano de " + anoDeNascimento); // Concatenação pode ser feito utilizando o sinal +.

            int x, y;
            x = 5;
            y = 2 * x;

            Console.WriteLine(x); // exercitando
            Console.WriteLine(y);

            double b, B, h, area;

            b = 6.0;
            B = 8.0;
            h = 5.0;
            area = ((b + B) / 2) * h;

            Console.WriteLine(area);   


            //Exemplo
            int a, b; //defindo o nome e o tipo das variáveis
            double resultado;

            a = 5; //atribuindo valor a variável
            B = 2;

            resultado = (double) a / B; // dividindo as variáveis e o resultado vai para uma nova variável - Adicionando (double) para o resultado ser do tipo double.'
            Console.WriteLine(resultado); // imprimindo variável.

             //CASTING -> Conversão explícita de um tipo para outro. é necessário quando o compilador não é capaz de "advinhar" que o resultado
             // de uma expressão deve ser de outro tipo

        }
    }
}
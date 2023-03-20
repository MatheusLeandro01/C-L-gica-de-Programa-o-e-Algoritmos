using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu(); 
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Calculadora: ");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtrção");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");

            Console.Write("Informe a opção Desejada: ");
            int opcaoEscolhida = int.Parse(Console.ReadLine());

            switch (opcaoEscolhida)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }
        static void Soma()
        {
            Console.Write("Valor 1: ");
            double valor1 = double.Parse(Console.ReadLine());

            Console.Write("valor 2: ");
            double valor2 = double.Parse(Console.ReadLine());

            double resultado = valor1 + valor2;

            Console.WriteLine($"Resultado: {resultado}");
            Console.ReadKey();
            Menu();
        }
        static void Subtracao()
        {
            Console.Write("Valor 1: ");
            double valor1 = double.Parse(Console.ReadLine());

            Console.Write("valor 2: ");
            double valor2 = double.Parse(Console.ReadLine());

            double resultado = valor1 - valor2;

            Console.WriteLine($"Resultado: {resultado}");
            Console.ReadKey();
            Menu();
        }
        static void Divisao()
        {
            Console.Write("Valor 1: ");
            double valor1 = double.Parse(Console.ReadLine());

            Console.Write("valor 2: ");
            double valor2 = double.Parse(Console.ReadLine());

            double resultado = valor1 / valor2;

            Console.WriteLine($"Resultado: {resultado}");
            Console.ReadKey();
            Menu();
        }
        static void Multiplicacao()
        {
            Console.Write("Valor 1: ");
            double valor1 = double.Parse(Console.ReadLine());

            Console.Write("valor 2: ");
            double valor2 = double.Parse(Console.ReadLine());

            double resultado = valor1 * valor2;

            Console.WriteLine($"Resultado: {resultado}");
            Console.ReadKey();
            Menu();
        }
    }
}
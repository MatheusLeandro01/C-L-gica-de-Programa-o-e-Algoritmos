using Exercicio10.Entities;
using Exercicio10.Entities.Exception;
using System;

namespace Exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data:");

                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Holder: ");
                string holder = Console.ReadLine();

                Console.Write("Initial Balance: ");
                double balance = double.Parse(Console.ReadLine());

                Console.Write("Withdraw Limit: ");
                double withDrawLimit = double.Parse(Console.ReadLine());
                Account account = new Account(number, holder, balance, withDrawLimit);

                Console.WriteLine();

                Console.Write("Enter amount for withdraw: ");
                double n = double.Parse(Console.ReadLine());
                account.WithDraw(n);

                Console.WriteLine($"New balance: {account.Balance.ToString("F2")}");
            }
            catch (WithdrawException e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }    
}
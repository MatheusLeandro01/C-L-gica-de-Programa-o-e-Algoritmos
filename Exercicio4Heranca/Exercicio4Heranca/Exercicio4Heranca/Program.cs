using Exercicio4Heranca.Entities;
using System;

namespace Exercicio4Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(1001, "Alex", 500.0);

            Account acc2 = new SavingAccount(1002, "Anna", 500.0, 1);//Upcasting //estou trabalhando com o Saving account

            acc1.WithDraw(10.0);
            acc2.WithDraw(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance); //acc2 está ligada ao savingaccount
        }
    }
}
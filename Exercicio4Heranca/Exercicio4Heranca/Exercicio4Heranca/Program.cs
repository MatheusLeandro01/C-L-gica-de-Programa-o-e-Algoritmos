using Exercicio4Heranca.Entities;
using System;

namespace Exercicio4Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex", 0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0, 500);

            //Upcasting
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200);
            Account acc3 = new SavingAccount(1004, "Anna", 0.0, 1.0);
            // acc2.Loan(); -> Não é possível porque acc2 é do tipo account e esse método pertence a classe business account.

            //Downcasting
            BusinessAccount acc4 = (BusinessAccount)acc2;
            
            if (acc3 is SavingAccount)
            {
                //SavingAccount acc5 = (SavingAccount)acc3;
                SavingAccount acc5 = acc3 as SavingAccount;               
                Console.WriteLine("Update");
            }
            
            
        }
    }
}
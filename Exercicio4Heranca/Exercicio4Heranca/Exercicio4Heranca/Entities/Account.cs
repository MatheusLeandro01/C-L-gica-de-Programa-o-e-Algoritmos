namespace Exercicio4Heranca.Entities
{
    class Account
    {
        public int Number { get; protected set; } // no modo private, apenas a própria classe em que está o atributo pode ser modificado.
        public string Holder { get; protected set; }// no modo protected, as subclasses podem fazer modificações;
        public double Balance { get; protected set; }

        public Account() { }
        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }
        public void WithDraw(double amount)
        {
            Balance -= amount;
        }
        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}

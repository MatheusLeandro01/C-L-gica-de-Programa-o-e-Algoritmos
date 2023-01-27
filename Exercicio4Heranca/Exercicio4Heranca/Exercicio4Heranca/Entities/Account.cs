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
        public virtual void WithDraw(double amount)//Adicionando "virtual" estou dizendo que minhas subclasses podem sobrescrever esse método;
        {
            Balance -= amount+5.0;
        }
        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}

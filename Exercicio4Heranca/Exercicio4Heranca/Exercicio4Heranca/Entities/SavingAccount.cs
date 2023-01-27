namespace Exercicio4Heranca.Entities
{
    class SavingAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingAccount() { }
        public SavingAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance(double balance)
        {
            Balance = Balance - (Balance * (balance / 100));
        }

        public override void WithDraw(double amount) //sobreescrevendo um método que está na superclassse(Account);
        {
            base.WithDraw(amount);
            Balance -= 2.0;
        }
    }
}

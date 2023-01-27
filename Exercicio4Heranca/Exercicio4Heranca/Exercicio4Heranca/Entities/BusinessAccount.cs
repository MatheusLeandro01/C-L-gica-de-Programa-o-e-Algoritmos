namespace Exercicio4Heranca.Entities
{
    class BusinessAccount : Account //BusisnessAccount agora tem como herança a classe account; O Simbolo ":" significa "estende".
        //com isso posso usar todos os atributos da classe account.
    {
        public double LoanLimit { get; set; }

        public BusinessAccount() { }
        public BusinessAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance)//fazendo reuso das variáveis de account(superclasse);
        {            
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount; //posso utilizar esse atributo porque esta classe está herdando de account;
            }            
        }
    }
}

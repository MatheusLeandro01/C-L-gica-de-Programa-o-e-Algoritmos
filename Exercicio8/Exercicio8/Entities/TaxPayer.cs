namespace Exercicio8.Entities
{
    abstract class TaxPayer //Classe Abstrata
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        public TaxPayer() { }

        protected TaxPayer(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double Tax(); //Método abstrato
    }
}

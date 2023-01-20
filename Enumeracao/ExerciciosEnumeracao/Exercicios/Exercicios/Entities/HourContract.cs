namespace Exercicios.Entities
{
    class HourContract // Vai possuir informações do contrato.
    {
        public DateTime Date { get; set; } // é um struct que recebe informações de data e hora.
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        public HourContract() { } //Método construtor
        public HourContract(DateTime date, double valuePerHour, int hours) //Método construtor com parâmetros.
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        public double TotalValue() // Método para calcular o valor total(dinheiro) recebido desse contrato
        {
            return ValuePerHour * Hours;
        }
    }
}

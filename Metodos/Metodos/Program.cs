using System;

namespace Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            var pagamento = new Pagamento(DateTime.Now.AddDays(1));

            pagamento.Pagar("10",DateTime.Now); // passagem de parâmetros do método.

            var pagamento2 = new PagamentoCartaoCredito(DateTime.Now.AddDays(1));
            
            pagamento.Pagar2(".");  //Classe Pagamento          
            pagamento2.Pagar2("."); //Classe PagamentoCartaoCredito
        }

        class Pagamento
        {
            public DateTime DataDePagamento { get; set; }

            public Pagamento() { }//construtor sem parâmetro
            public Pagamento(DateTime dataDePagamento) //Método construtor
            {
                DataDePagamento = dataDePagamento;
            }
            
            //sobrecarga de método
            public void Pagar(){ } //Método            
            public void Pagar(string numero){ } //Sobrecarga de Método                        
            public void Pagar(string numero, DateTime vencimento, int valor = 10){ } //sobrecarga com parâmetro opcional

            //sobrescrita
            public virtual void Pagar2(string numero) //para permitir que este médo seja sobrescrito por uma classe filha, preciso utilizar a plavra "virtual"
            {
                Console.WriteLine("Pagar (pagamento)");
            }          
        }
        class PagamentoCartaoCredito : Pagamento
        {
            public PagamentoCartaoCredito(DateTime dataDePagamento)
                :base(dataDePagamento)
            {
                DataDePagamento= dataDePagamento;
            }
            public override void Pagar2(string numero) //herdando e sobrescrevendo o método pagar2
            {
                base.Pagar2(numero); //chamando o método pai
                Console.WriteLine("Pagar Cartão");
            } 
        }
    }
}
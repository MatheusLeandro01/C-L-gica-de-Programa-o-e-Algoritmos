using System;

namespace Praticando
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pessoa pessoa = new PessoaFisica(); //Upcasting

            Pessoa pessoa = new Pessoa();
            PessoaFisica pessoaFisica = new PessoaFisica();
            PessoaJuridica pessoaJuridica = new PessoaJuridica();

            pessoaFisica = (PessoaFisica)pessoa;//casting(conversão explícita) -> downcasting -> propriedades de pessoaFisica poderão ser perdidas           
        }
        class Pessoa
        {
            public string Nome { get; set; }
        }

        class PessoaFisica : Pessoa
        {
            public string Cpf { get; set; }
        }
        class PessoaJuridica : Pessoa
        {
            public string Cnpj { get; set; }
        }
    }
}
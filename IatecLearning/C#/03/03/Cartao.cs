using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    internal class Cartao //classe cartão
    {
        public string NomeProprietario { get; private set; } //propriedades da classe cartão
        public string Numero { get; private set; }
        public int Digito { get; private set; }
        public decimal Saldo { get; private set; }
        public decimal Limite { get; private set; }
        public bool Ativo { get; private set; }
        public DateTime Validade { get; private set; }    

        
        public Cartao() { }

        public Cartao(string nomeProprietario, string numero, int digito, decimal saldo, decimal limite, bool ativo, DateTime validade)
        {
            NomeProprietario = nomeProprietario;
            Numero = numero;
            Digito = digito;
            Saldo = saldo;
            Limite = limite;
            Ativo = ativo;
            Validade = validade;            
        }

        public void AlterarNomeProprietario(string nome)
        {
            NomeProprietario = nome;
        }
        public void Debitar(decimal valor)
        {
            Saldo += valor;
        }
    }
}

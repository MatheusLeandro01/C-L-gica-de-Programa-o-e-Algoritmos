using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    internal class Cartao //classe cartão
    {
        public string NomeProprietario { get; set; } //propriedades da classe cartão
        public string Numero { get; set; } //set não privado. é possível alterar em program.
        public int Digito { get; set; }
        public decimal Saldo { get; set; }
        public decimal Limite { get; set; }
        public bool Ativo { get; set; }
        public DateTime Validade { get; set; }
        public NomeBanco Banco { get; set; }
        public TipoCartao Tipo { get; set; }

        public string ObterNumeroCompleto()
        {
            return $"{Numero}-{Digito}";
        }
    }
}

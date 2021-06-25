using System;

namespace WebApiTrades.Model
{
    public class Trades
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public string Ativo { get; set; }
        public char TipoOperacao { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public int Conta { get; set; }

    }
}

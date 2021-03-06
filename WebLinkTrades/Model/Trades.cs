using System;

namespace WebApiTrades.Model
{
    public class Trades
    {
        public int TradesId { get; set; }

        private DateTime _dtAtivo;

        public DateTime DtAtivo
        {
            get { return _dtAtivo; }
            set { _dtAtivo = value == null ? DateTime.UtcNow : value; }
        }

        public string Ativo { get; set; }
        public char TipoOperacao { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }
        public int Conta { get; set; }

    }
}

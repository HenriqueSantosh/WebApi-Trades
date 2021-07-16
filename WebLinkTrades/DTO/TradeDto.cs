using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebLinkTrades.DTO
{
    public class TradeDto
    {
        public int TradesId { get; set; }

        public DateTime DtAtivo { get; set; }

        public string Ativo { get; set; }
        public char TipoOperacao { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }
        public int Conta { get; set; }
    }
}

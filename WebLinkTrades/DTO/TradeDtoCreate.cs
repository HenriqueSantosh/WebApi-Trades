using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebLinkTrades.DTO
{
    public class TradeDtoCreate
    {
        public DateTime DtAtivo { get ; set ; }

        [Required]
        public string Ativo { get; set; }

        [Required]
        public char TipoOperacao { get; set; }

        [Required]
        public int Quantidade { get; set; }

        [Required]
        public decimal Preco { get; set; }

        [Required]
        public int Conta { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiTrades.Model;
using WebLinkTrades.Dados.Context;
using WebLinkTrades.Dados.Interfaces;
using WebLinkTrades.Dados.Repository;

namespace WebLinkTrades.Dados.ImplemantationTrades
{
    public class TradesRepository : BaseRespository<Trades>, ITradesRepository
    {
        private readonly DbSet<Trades> _dataset;

        public TradesRepository(BaseContext context) : base(context)
        {
            _dataset = context.Set<Trades>();
        }

        public async Task<IEnumerable<Trades>> GetTradesByConta(int account)
        {
            return await _dataset.Where(c => c.Conta == account).ToListAsync();
        }

        public IEnumerable<Trades> GetPrecoMedio()
        {
            var listTrades = _dataset.ToList();
            IEnumerable<Trades> listPrecoMedium = listTrades
                .GroupBy(c => new
                {
                    c.Ativo,
                    c.Conta,
                    c.TipoOperacao
                }).Select(c =>
                       new Trades
                       {
                           TradesId = 0,
                           DtAtivo = new DateTime(),
                           Ativo = c.Key.Ativo,
                           Conta = c.Key.Conta,
                           TipoOperacao = c.Key.TipoOperacao,
                           Quantidade = c.Sum(c => c.Quantidade),
                           Preco = ((c.Sum(c => c.Preco) * c.Sum(c => c.Quantidade)) / c.Sum(c => c.Quantidade))
                       }).Distinct().ToList();
            return listPrecoMedium.ToList();
        }

        public IEnumerable<Trades> GetPrecoMedioByConta(int account)
        {
            var listTrades =  _dataset.Where(c => c.Conta == account).ToList();
            IEnumerable<Trades> listPrecoMedium = listTrades
                .GroupBy(c => new
            { 
                c.Ativo,
                c.Conta, 
                c.TipoOperacao
            }).Select(c => 
                   new Trades
               {
                  TradesId = 0,
                  DtAtivo = new DateTime(),
                  Ativo =  c.Key.Ativo,
                  Conta = c.Key.Conta,
                  TipoOperacao = c.Key.TipoOperacao,
                  Quantidade = c.Sum(c =>c.Quantidade),
                  Preco =  ((c.Sum(c=> c.Preco) * c.Sum(c=> c.Quantidade))/ c.Sum(c => c.Quantidade))
                   }).Distinct().ToList();
            return listPrecoMedium.ToList();

        }
    }
}

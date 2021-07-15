using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApiTrades.Model;
using WebLinkTrades.Dados.Context;
using WebLinkTrades.Dados.Interfaces;
using WebLinkTrades.Dados.Repository;

namespace WebLinkTrades.Dados.ImplemantationTrades
{
    public class TradesRepository : BaseRespository<Trades>, ITradesRepository
    {

        public TradesRepository(BaseContext context) : base(context)
        {
        }

        public Task<IEnumerable<Trades>> GetPrecoMedium()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Trades>> GetPrecoMediumByConta(int account)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiTrades.Model;
using WebLinkTrades.Dados.Interfaces;
using WebLinkTrades.Services.Interfaces;

namespace WebLinkTrades.Services.Implemantation
{
    public class TradesServices : ITradesServices
    {
        private readonly ITradesRepository _trades;

        public TradesServices(ITradesRepository trades)
        {
            _trades = trades;
        }

        public bool Delete(int id)
        {
            return _trades.Delete(id);
        }

        public Trades GetById(int id)
        {
            return _trades.GetById(id);
        }

        public Task<IEnumerable<Trades>> GetPrecoMedium()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Trades>> GetPrecoMediumByConta(int account)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Trades>> GetTodos()
        {
            return await _trades.GetAll();
        }

        public Trades Save(Trades trade)
        {
            return _trades.Save(trade);
        }

        public Trades Update(Trades trade)
        {
            return _trades.Update(trade);
        }
    }
}

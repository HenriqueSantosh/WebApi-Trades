using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiTrades.Model;

namespace WebLinkTrades.Dados.Interfaces
{
    public interface ITradesRepository : IRepository<Trades>
    {
        IEnumerable<Trades> GetPrecoMedio();
        IEnumerable<Trades> GetPrecoMedioByConta(int account);
        Task<IEnumerable<Trades>> GetTradesByConta(int account);
    }
}

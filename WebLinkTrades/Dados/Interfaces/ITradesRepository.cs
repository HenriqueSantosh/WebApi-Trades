using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiTrades.Model;

namespace WebLinkTrades.Dados.Interfaces
{
    public interface ITradesRepository : IRepository<Trades>
    {
        Task<IEnumerable<Trades>> GetPrecoMedium();
        Task<IEnumerable<Trades>> GetPrecoMediumByConta(int account);
    }
}

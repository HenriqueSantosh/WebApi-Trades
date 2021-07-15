using System.Collections.Generic;
using System.Threading.Tasks;
using WebApiTrades.Model;

namespace WebLinkTrades.Services.Interfaces
{
    public interface ITradesServices
    {
        Task<IEnumerable<Trades>> GetPrecoMedium();
        Task<IEnumerable<Trades>> GetPrecoMediumByConta(int account);
        Task<IEnumerable<Trades>> GetTodos();
        Trades GetById(int id);
        Trades Save(Trades trade);
        Trades Update(Trades trade);
        bool Delete(int id);
    }
}

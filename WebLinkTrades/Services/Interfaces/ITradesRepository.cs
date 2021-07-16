using System.Collections.Generic;
using System.Threading.Tasks;
using WebApiTrades.Model;
using WebLinkTrades.DTO;

namespace WebLinkTrades.Services.Interfaces
{
    public interface ITradesServices
    {
        Task<IEnumerable<TradeDto>> GetPrecoMedium();
        Task<IEnumerable<TradeDto>> GetPrecoMediumByConta(int account);
        Task<IEnumerable<TradeDto>> GetTodos();
        TradeDto GetById(int id);
        TradeDto Save(TradeDtoCreate trade);
        TradeDto Update(TradeDto trade);
        bool Delete(int id);
    }
}

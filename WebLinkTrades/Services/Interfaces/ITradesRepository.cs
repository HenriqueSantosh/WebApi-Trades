using System.Collections.Generic;
using System.Threading.Tasks;
using WebApiTrades.Model;
using WebLinkTrades.DTO;

namespace WebLinkTrades.Services.Interfaces
{
    public interface ITradesServices
    {
        IEnumerable<TradeDto> GetPrecoMedio();
        IEnumerable<TradeDto> GetPrecoMedioByConta(int account);
        Task<IEnumerable<TradeDto>> GetTradesByConta(int account);
        Task<IEnumerable<TradeDto>> GetTodos();
        TradeDto GetById(int id);
        TradeDto Save(TradeDtoCreate trade);
        TradeDto Update(TradeDto trade);
        bool Delete(int id);
    }
}

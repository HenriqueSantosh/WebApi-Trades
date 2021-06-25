using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiTrades.Model;

namespace WebLinkTrades.BLL
{
    public interface ITradesBLL
    {
        IList<Trades> GetTrades();

    }
}

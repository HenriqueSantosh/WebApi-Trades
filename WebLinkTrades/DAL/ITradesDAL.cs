using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiTrades.Model;

namespace WebLinkTrades.DAL
{
    public interface ITradesDAL
    {
        IList<Trades> GetTrades();

    }
}

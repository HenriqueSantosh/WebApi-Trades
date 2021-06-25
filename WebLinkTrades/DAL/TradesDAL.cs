using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiTrades.Model;

namespace WebLinkTrades.DAL
{
    public class TradesDAL : ITradesDAL
    {
        public IList<Trades> GetTrades()
        {
            using (var context = new TradesContext())
            {
                return context.Trades.ToList();
            }
        }
    }
}

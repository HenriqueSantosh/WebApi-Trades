﻿using System.Collections.Generic;
using WebApiTrades.Model;
using WebLinkTrades.DAL;

namespace WebLinkTrades.BLL
{
    public class TradesBLL : ITradesBLL
    {
        public ITradesDAL tradesDAL;

        public TradesBLL()
        {
            tradesDAL = new TradesDAL();
        }
        public IList<Trades> GetTrades()
        {
            return tradesDAL.GetTrades();
        }
    }
}

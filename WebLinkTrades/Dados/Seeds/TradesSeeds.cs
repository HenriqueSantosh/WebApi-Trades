using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net;
using WebApiTrades.Model;

namespace WebLinkTrades.Dados.Seeds
{
    public class TradesSeeds
    {
        public static void Trades(ModelBuilder modelBuilder)
        {
            var listTrades = GetTrades();
           
            modelBuilder.Entity<Trades>()
            .HasData(listTrades);            
        }

        private static IList<Trades> GetTrades()
        {
            var json = new WebClient().DownloadString(@"Repository\Trades.json");
            return JsonConvert.DeserializeObject<IList<Trades>>(json);
        }
    }
}

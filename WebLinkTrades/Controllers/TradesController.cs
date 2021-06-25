using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebApiTrades.Model;
using WebLinkTrades.BLL;

namespace WebApiTrades.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TradesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Trades>> Get()
        {
            ITradesBLL tradesBLL = new TradesBLL();
            //IList < Trades >  trades = tradesBLL.GetTrades();
            var webClient = new WebClient();
            var json = webClient.DownloadString(@"Repository\Trades.json");
            var trades = JsonConvert.DeserializeObject<IList<Trades>>(json);
            var tradesOrdenados = trades.OrderBy(x => x.Ativo).ToList();
            return Ok(tradesOrdenados);

        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

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
using WebLinkTrades.Services.Interfaces;

namespace WebApiTrades.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TradesController : ControllerBase
    {
        private readonly ITradesServices _tradesServices;

        public TradesController(ITradesServices tradesServices)
        {
            _tradesServices = tradesServices;
        }

        // GET api/values
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Trades>>> Get()
        {
            try
            {
                var list = await _tradesServices.GetTodos();
                return list.ToList();
            }
            catch (Exception)
            {

                throw;
            }

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

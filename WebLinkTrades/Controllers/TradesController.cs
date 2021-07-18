using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiTrades.Model;
using WebLinkTrades.DTO;
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
        public async Task<ActionResult<IEnumerable<TradeDto>>> Get()
        {
            try
            {

               var list = await _tradesServices.GetTodos();
                return list.ToList();
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError
                    , $"Errro ao tentar obter Trades {ex.ToString()}");
            }

        }

        [HttpGet("getPrecoMedio/")]
        public  ActionResult<IEnumerable<TradeDto>> GetPrecoMedio()
        {
            try
            {

                var list =  _tradesServices.GetPrecoMedio();
                return list.ToList();
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError
                    , $"Errro ao tentar obter Trades {ex.ToString()}");
            }

        }

        [HttpGet("getbyaccount/{account}")]
        public  ActionResult<IEnumerable<TradeDto>> GetByAccount(int account)
        {
            try
            {

                var list =  _tradesServices.GetPrecoMedioByConta(account);
                return list.ToList();
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError
                    , $"Errro ao tentar obter Trades {ex.ToString()}");
            }

        }
        // GET api/values/5
        [HttpGet("{id}", Name ="ObterTradesById")]
        public ActionResult<TradeDto> Get(int id)
        {
            try
            {
                var entity = _tradesServices.GetById(id);
                if (entity == null) return NotFound();

                return entity;
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Errro ao tentar obter categorias");
            }
        }

        // POST api/values
        [HttpPost]
        public ActionResult<Trades> Post([FromBody] TradeDtoCreate trades)
        {
            try
            {
               var entity =  _tradesServices.Save(trades);

                return new CreatedAtRouteResult("ObterTradesById", new { id = entity.TradesId }, entity);
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                "Erro ao tentar Salvar");
            }
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public ActionResult<TradeDto> Put(int id, [FromBody] TradeDto trades)
        {
            try
            {
                if (id != trades.TradesId) return BadRequest();

                return _tradesServices.Update(trades);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                "Erro ao tentar Alterar");
            }
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            try
            {
                return _tradesServices.Delete(id);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                "Erro ao tentar Deletar");
            }
        }
    }
}

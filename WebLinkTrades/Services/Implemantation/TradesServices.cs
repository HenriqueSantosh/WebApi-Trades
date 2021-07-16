﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApiTrades.Model;
using WebLinkTrades.Dados.Interfaces;
using WebLinkTrades.DTO;
using WebLinkTrades.Services.Interfaces;

namespace WebLinkTrades.Services.Implemantation
{
    public class TradesServices : ITradesServices
    {
        private readonly ITradesRepository _trades;
        private readonly IMapper _mapper;


        public TradesServices(ITradesRepository trades, IMapper mapper)
        {
            _trades = trades;
            _mapper = mapper;
        }

        public bool Delete(int id)
        {
            return _trades.Delete(id);
        }

        public TradeDto GetById(int id)
        {
            var entity = _trades.GetById(id);
            return _mapper.Map<TradeDto>(entity);
        }

        public Task<IEnumerable<TradeDto>> GetPrecoMedium()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TradeDto>> GetPrecoMediumByConta(int account)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<TradeDto>> GetTodos()
        {
            var lisTrades = await _trades.GetAll();
            var listTradesDto = _mapper.Map<IEnumerable<TradeDto>>(lisTrades);
            return listTradesDto;
        }

        public TradeDto Save(TradeDtoCreate trade)
        {
            var entity = _mapper.Map<Trades>(trade);
            var entityCreate = _trades.Save(entity);
            return  _mapper.Map<TradeDto>(entityCreate);
        }

        public TradeDto Update(TradeDto trade)
        {
            var entity = _mapper.Map<Trades>(trade);
            var entityCreate = _trades.Update(entity);
            return _mapper.Map<TradeDto>(entityCreate);
        }
    }
}

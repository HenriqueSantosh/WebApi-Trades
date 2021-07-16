using AutoMapper;
using WebApiTrades.Model;

namespace WebLinkTrades.DTO.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<TradeDto, Trades>()
                .ReverseMap();

            CreateMap<TradeDtoCreate, Trades>()
                .ReverseMap();
        }
    }
}

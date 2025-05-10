using AutoMapper;
using Sc.Trade.Application.UseCases.Features.Orders.Commands.CreateOrder;
using Sc.Trade.Application.UseCases.Features.Orders.Commands.UpdateOrder;
using Sc.Trade.Application.UseCases.Features.Orders.Queries.GetAllOrder;
using Sc.Trade.Application.UseCases.Features.Orders.Queries.GetOrder;
using Sc.Trade.Domain.Entities;

namespace Sc.Trade.Application.UseCases.Commons.Mappings
{
    public class MappingsProfile : Profile
    {
        public MappingsProfile()
        {
            CreateMap<CreateOrderCommand, Order>().ReverseMap();
            CreateMap<UpdateOrderCommand, Order>().ReverseMap();            
            CreateMap<GetAllOrderResponseDto, Order>().ReverseMap();
            CreateMap<GetOrderResponseDto, Order>().ReverseMap();
        }
    }
}

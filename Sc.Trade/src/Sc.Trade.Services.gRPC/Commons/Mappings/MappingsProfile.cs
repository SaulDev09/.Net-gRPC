using AutoMapper;
using Google.Protobuf.WellKnownTypes;
using Sc.Trade.Application.UseCases.Features.Orders.Commands.CreateOrder;
using Sc.Trade.Application.UseCases.Features.Orders.Commands.UpdateOrder;
using Sc.Trade.Application.UseCases.Features.Orders.Queries.GetAllOrder;
using Sc.Trade.Application.UseCases.Features.Orders.Queries.GetOrder;
using Sc.Trade.Services.gRPC.Protos;

namespace Sc.Trade.Services.gRPC.Commons.Mappings
{
    public class MappingsProfile : Profile
    {
        public MappingsProfile()
        {
            CreateMap<DateTime, Timestamp>()
                .ConvertUsing(x => Timestamp.FromDateTime(DateTime.SpecifyKind(x, DateTimeKind.Utc)));

            CreateMap<Timestamp, DateTime>()
                .ConvertUsing(x => x.ToDateTime());

            CreateMap<CreateOrderCommand, CreateOrderRequest>().ReverseMap();
            CreateMap<UpdateOrderCommand, UpdateOrderRequest>().ReverseMap();
            CreateMap<OrderResponse, GetOrderResponseDto>().ReverseMap();
            CreateMap<OrderResponse, GetAllOrderResponseDto>().ReverseMap();
        }
    }
}

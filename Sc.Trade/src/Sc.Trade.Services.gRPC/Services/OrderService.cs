using AutoMapper;
using Grpc.Core;
using MediatR;
using Sc.Trade.Application.UseCases.Features.Orders.Commands.CancelOrder;
using Sc.Trade.Application.UseCases.Features.Orders.Commands.CreateOrder;
using Sc.Trade.Application.UseCases.Features.Orders.Commands.UpdateOrder;
using Sc.Trade.Application.UseCases.Features.Orders.Queries.GetAllOrder;
using Sc.Trade.Application.UseCases.Features.Orders.Queries.GetOrder;
using Sc.Trade.Services.gRPC.Protos;

namespace Sc.Trade.Services.gRPC.Services
{
    public class OrderService : Order.OrderBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public OrderService(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        public override async Task<GetAllOrderResponse> GetAllOrder(GetAllOrderRequest request, ServerCallContext context)
        {
            var ordersDto = await _mediator.Send(new GetAllOrderQuery());
            var response = new GetAllOrderResponse();
            var serverResponse = new ServerResponse();

            if (ordersDto.Any())
            {
                serverResponse.IsSuccess = true;
                serverResponse.Message = "Orders found";

                response.Data.AddRange(_mapper.Map<IEnumerable<OrderResponse>>(ordersDto));
            }
            else
                serverResponse.Message = "No orders found";

            response.ServerResponse = serverResponse;
            return response;
        }

        public override async Task<GetOrderResponse> GetOrder(GetOrderRequest request, ServerCallContext context)
        {
            var orderDto = await _mediator.Send(new GetOrderQuery() { Id = request.Id });
            var response = new GetOrderResponse();
            var serverResponse = new ServerResponse();

            if (orderDto is not null)
            {
                serverResponse.IsSuccess = true;
                serverResponse.Message = "Order found";
                response.Data = _mapper.Map<OrderResponse>(orderDto);
            }
            else
            {
                //serverResponse.IsSuccess = false;
                serverResponse.Message = "Order not found";
            }

            response.ServerResponse = serverResponse;
            return response;
        }

        public override async Task<CreateOrderResponse> CreateOrder(CreateOrderRequest request, ServerCallContext context)
        {
            var createOrderCommand = _mapper.Map<CreateOrderCommand>(request);
            var status = await _mediator.Send(createOrderCommand);
            var response = new CreateOrderResponse();
            var serverResponse = new ServerResponse();

            if (status.Equals(true))
            {
                var orderDto = await _mediator.Send(new GetOrderQuery() { Id = request.Id });

                response.Data = _mapper.Map<OrderResponse>(orderDto);
                serverResponse.IsSuccess = true;
                serverResponse.Message = "Order created";
            }
            else
            {
                //serverResponse.IsSuccess = false;
                serverResponse.Message = "Order not created";
            }

            response.ServerResponse = serverResponse;
            return response;
        }

        public override async Task<UpdateOrderResponse> UpdateOrder(UpdateOrderRequest request, ServerCallContext context)
        {
            var updateOrderCommand = _mapper.Map<UpdateOrderCommand>(request);
            var status = await _mediator.Send(updateOrderCommand);
            var response = new UpdateOrderResponse();
            var serverResponse = new ServerResponse();

            if (status.Equals(true))
            {
                var orderDto = await _mediator.Send(new GetOrderQuery() { Id = request.Id });
                response.Data = _mapper.Map<OrderResponse>(orderDto);
                serverResponse.IsSuccess = true;
                serverResponse.Message = "Order updated";
            }
            else
            {
                //serverResponse.IsSuccess = false;
                serverResponse.Message = "Order not updated";
            }
            response.ServerResponse = serverResponse;
            return response;
        }

        public override async Task<CancelOrderResponse> CancelOrder(CancelOrderRequest request, ServerCallContext context)
        {
            var status = await _mediator.Send(new CancelOrderCommand() { Id = request.Id });
            var response = new CancelOrderResponse();
            var serverResponse = new ServerResponse();

            if (status.Equals(true))
            {
                serverResponse.IsSuccess = true;
                serverResponse.Message = "Order deleted";
            }
            else
            {
                serverResponse.IsSuccess = false;
                serverResponse.Message = "Order not deleted";
            }
            response.ServerResponse = serverResponse;
            return response;
        }
    }
}

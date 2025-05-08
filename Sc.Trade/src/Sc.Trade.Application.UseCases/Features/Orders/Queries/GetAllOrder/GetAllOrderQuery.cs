using MediatR;

namespace Sc.Trade.Application.UseCases.Features.Orders.Queries.GetAllOrder
{
    public sealed record GetAllOrderQuery : IRequest<IEnumerable<GetAllOrderResponseDto>>
    {
    }
}

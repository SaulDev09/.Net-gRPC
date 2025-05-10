using AutoMapper;
using MediatR;
using Sc.Trade.Application.Interfaces.Persistence;
using Sc.Trade.Domain.Entities;

namespace Sc.Trade.Application.UseCases.Features.Orders.Commands.CreateOrder
{
    public class CreateOrderHandler : IRequestHandler<CreateOrderCommand, bool>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;


        public CreateOrderHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            var order = _mapper.Map<Order>(request);
            await _context.Orders.AddAsync(order, cancellationToken);
            return await _context.SaveChangesAsync(cancellationToken) > 0 ? true : false;
        }
    }
}

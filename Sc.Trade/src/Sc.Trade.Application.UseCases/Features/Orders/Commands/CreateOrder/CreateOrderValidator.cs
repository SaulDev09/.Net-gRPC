using FluentValidation;

namespace Sc.Trade.Application.UseCases.Features.Orders.Commands.CreateOrder
{
    public class CreateOrderValidator : AbstractValidator<CreateOrderCommand>
    {
        public CreateOrderValidator()
        {
            RuleFor(x => x.Id).NotEmpty().NotNull().GreaterThan(0);
            RuleFor(x => x.Symbol).NotEmpty().NotNull().MinimumLength(3);
            RuleFor(x => x.Side).IsInEnum();
            RuleFor(x => x.Quanty).NotEmpty().NotNull().GreaterThan(0);
            RuleFor(x => x.Type).IsInEnum();
            RuleFor(x => x.Price).NotEmpty().NotNull().GreaterThan(0);
            RuleFor(x => x.Currency).NotEmpty().NotNull().MinimumLength(3);
        }
    }
}

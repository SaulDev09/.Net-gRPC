using Sc.Trade.Domain.Commons;

namespace Sc.Trade.Domain.Events
{
    public class OrderCanceledEvent: BaseEvent
    {
        public int Id { get; set; }
    }
}

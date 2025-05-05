using Sc.Trade.Domain.Commons;
using Sc.Trade.Domain.Enums;

namespace Sc.Trade.Domain.Events
{
    public class OrderUpdatedEvent : BaseEvent
    {
        public string Id { get; set; }
        public int Quantity { get; set; }
        public OrderType Type { get; set; }
        public decimal Price { get; set; }
    }
}

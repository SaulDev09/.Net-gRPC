﻿using Sc.Trade.Domain.Commons;
using Sc.Trade.Domain.Enums;

namespace Sc.Trade.Domain.Entities
{
    public class Order : BaseAuditableEntity
    {
        public string Symbol { get; set; }
        public OrderSide Side { get; set; }
        public DateTime TransactTime { get; set; }
        public int Quanty { get; set; }
        public OrderType Type { get; set; }
        public decimal Price { get; set; }
        public string Currency { get; set; }
        public string? Text { get; set; }
    }
}

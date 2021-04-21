using System;
using ExModulo9.Entities.Enums;

namespace ExModulo9.Entities
{
    public class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
    }
}
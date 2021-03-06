using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using ExModulo9.Entities.Enums;

namespace ExModulo9.Entities
{
    public class Order
    {
        public Order(int id,DateTime moment, OrderStatus status, Client client)
        {
            Id =Id;
            Moment = DateTime.Now;
            Status = status;
            Client = client;
        }
        public Order() { }

        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double sum = 0;
            foreach (OrderItem item in Items)
            {
                sum += item.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            return "Order moment: "
            + Moment 
            + "\nOrder status: "
            + Status;
        }
        
    }
}
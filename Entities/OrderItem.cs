using System;
namespace ExModulo9.Entities
{
    public class OrderItem
    {
        public OrderItem()
        {        
        }
        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public int Id { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }
        public Order Orders { get; set; }

        public double SubTotal()
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            return Product.Description
            +",$"
            + Price
            +", Quantity: "
            + Quantity
            +", Subtotal: "
            + SubTotal();
        }
    }
}
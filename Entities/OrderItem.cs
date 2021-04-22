namespace ExModulo9.Entities
{
    public class OrderItem
    {
        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public double SubTotal()
        {
            return Quantity * Price;
        }
    }
}
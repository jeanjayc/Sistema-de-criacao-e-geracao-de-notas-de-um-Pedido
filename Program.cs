using System;
using ExModulo9.Entities;
using System.Globalization;
using ExModulo9.Entities.Enums;
using System.Linq;

namespace ExModulo9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Client client = new Client(1,name, email, birthDate);

            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Order order = new Order(3,DateTime.Now, status,client);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter {i + 1} item data:");
                Console.Write("Product name: ");
                string ProdName = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                Product product = new Product(ProdName,price);
                order.AddItem(new OrderItem(quantity, price, product));
            }

            Console.WriteLine();

            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order.ToString());
            Console.WriteLine(client.ToString());
            Console.WriteLine("Order items: ");
            foreach(var item in order.Items)
            {
                Console.WriteLine(item.ToString());
                var total = order.Items.Sum(p => p.SubTotal());
                Console.WriteLine("Total: $" + total);
            }
        }
    }
}

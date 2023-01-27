using Exercicio3.Entities.Enum;
using Exercicio3.Entities;
using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Client Data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Birth Date (DD/MM/YYYY): ");
            DateTime birthdate = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, birthdate);

            Console.WriteLine("Enter Order Data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order order = new Order(status, client);

            Console.Write("How many items to this order? ");
            int qts = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= qts; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product Name: ");
                string productName = Console.ReadLine();

                Console.Write("Product Price: ");
                double productPrice = double.Parse(Console.ReadLine());

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                Product products = new Product(productName, productPrice);
                OrderItem orderItem = new OrderItem(quantity, productPrice, products);

                order.AddItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine("Order Summary:");
            Console.WriteLine(order);
            
        }
    }
}
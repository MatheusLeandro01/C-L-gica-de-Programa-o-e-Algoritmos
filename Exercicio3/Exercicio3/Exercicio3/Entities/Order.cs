using Exercicio3.Entities.Enum;
using System.Globalization;
using System.Text;

namespace Exercicio3.Entities
{
    class Order
    {
        public DateTime Moment { get; set; } = DateTime.Now;
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order() { }

        public Order(OrderStatus status, Client client)
        {            
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem items)
        {
            Items.Add(items);
        }
        public void RemoveItem(OrderItem items)
        {
            Items.Remove(items);
        }

        public double Total()
        {
            double sum = 0.0;
            foreach (OrderItem item in Items)
            {
                sum += item.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Order moment: {Moment.ToString("dd/MM/yyyy HH:mm:ss")}");
            sb.AppendLine($"Order Status: {Status}");
            sb.AppendLine($"Client: {Client}");
            sb.AppendLine("Order Items:");
            foreach (OrderItem item in Items)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2"));
            return sb.ToString();
        }
    }
}

using System.Globalization;

namespace Exercicio3.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem() { }

        public OrderItem(int quantity, double price, Product products)
        {
            Quantity = quantity;
            Price = price;
            Product = products;
        }
        public double SubTotal()
        {
            return Price * Quantity;
        }
        public override string ToString()
        {
            return Product.Name
                + ", $"
                + Price
                + ", Quantity: "
                + Quantity
                + ", Subtotal: $"
                + SubTotal();
        }
    }
}

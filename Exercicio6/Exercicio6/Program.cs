using Exercicio6.Entities;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");

                Console.Write("Common, Used or Imported (c/u/i)? ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                if (ch == 'i')
                {
                    Console.Write("Custom Fee: ");
                    double customsFee = double.Parse(Console.ReadLine());

                    list.Add(new ImportedProduct(name, price, customsFee));
                }
                else if (ch == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDare = DateTime.Parse(Console.ReadLine());

                    list.Add(new UsedProduct(name, price, manufactureDare));
                }
                else if (ch == 'c')
                {
                    list.Add(new Product(name, price));
                }
                else
                {
                    Console.WriteLine("Valor nao retornado");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Price Tags:");
            foreach (Product i in list)
            {
                Console.WriteLine(i.PriceTag());
            }
        }
    }
}
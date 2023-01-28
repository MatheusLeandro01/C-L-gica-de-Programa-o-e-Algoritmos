using Exercicio5.Entities;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());            

            for (int i = 1; i<=n; i++)
            {
                Console.WriteLine($"Employee #{i} data:");

                Console.Write("Outsourced (y/n)? ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());

                Console.Write("Value Per Hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());

                if (ch == 'y')
                {
                    Console.Write("Adttional Charge: ");
                    double addtionalCharge = double.Parse(Console.ReadLine());
                    list.Add(new OutSourcedEmployee(name, hours, valuePerHour, addtionalCharge));
                }
                else
                {
                    list.Add(new Employee(name, hours, valuePerHour));
                }
            }

            Console.WriteLine();
            Console.WriteLine("Payments: ");
            foreach (Employee emp in list)
            {
                Console.WriteLine($"{emp.Name} - $ {emp.Payment().ToString("F2")}");
            }
        }
    }
}

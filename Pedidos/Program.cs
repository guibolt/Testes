using System;
using Pedidos.Entitites;
using Pedidos.Entitites.Enums;
namespace Pedidos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Client Data");
            Console.WriteLine("Name:");
            string nome = Console.ReadLine();
            Console.WriteLine("Email");
            string email = Console.ReadLine();
            Console.Write("Birh date (DD/MM/YYY)");
            DateTime birthd = DateTime.Parse(Console.ReadLine());
            Client Cal = new Client(nome, email, birthd);
            Console.WriteLine("Enter the order status");
            OrderStatus orderStatus = Enum.Parse<OrderStatus>(Console.ReadLine().ToUpper());
            Ordem order = new Ordem(DateTime.Now, orderStatus, Cal);
           
            Console.WriteLine("How many items to this order?");
            int n = int.Parse(Console.ReadLine());


            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Enter order#" +i+ " item data" );
                Console.WriteLine("Name of the Product");
                string nam = Console.ReadLine();
                Console.WriteLine("Enter product price");
                double price = double.Parse(Console.ReadLine());
                Console.WriteLine("Quantity:");
                int quant = int.Parse(Console.ReadLine());

                Product p = new Product(nam, price);

                OrderItem orderItem = new OrderItem(quant, price, p);


                order.AddItem(orderItem);
            }

            Console.WriteLine();

            Console.WriteLine("ORDER SUMMARY:");

            Console.WriteLine(order);

            Console.ReadLine();
        }
    }
}

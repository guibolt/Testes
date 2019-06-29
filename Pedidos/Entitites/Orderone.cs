using System;
using System.Collections.Generic;
using System.Text;
using Pedidos.Entitites.Enums;
using Pedidos.Entitites;
using System.Globalization;

namespace Order.Entitites
{
    class Order
    { 
        public DateTime Date { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> products { get; set; } = new List<OrderItem>();
        public Client Cliente { get; set; }
        public Order()
        {

        }
      
        public Order(DateTime date,OrderStatus status,Client client)
        {
            Date = date;
            Status = status;
            Cliente = client;
        }
        public void AddItem(OrderItem product)
        {
            products.Add(product);
        }
        public void RemoveItem(OrderItem product)
        {
            products.Add(product);
        }

        public double Total()
        {
            double sum = 0.0;
            foreach (OrderItem item in products)
            {
                sum += item.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
          StringBuilder sd = new StringBuilder();

            sd.AppendLine("Order moment: " + Date.ToString("dd/MM/yyyy HH:mm:ss"));
            sd.AppendLine("Order status: " + Status);
            sd.AppendLine("Client: " + Cliente);
            sd.AppendLine("Order items: ");
            foreach (OrderItem item in products)
            {
                sd.AppendLine(item.ToString());
            }
            sd.AppendLine("Total Price: R$ " + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sd.ToString();
        }
    }
}

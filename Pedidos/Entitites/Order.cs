using System;
using System.Collections.Generic;
using System.Text;
using Pedidos.Entitites.Enums;

namespace Order.Entitites
{
    class Order
    {
        

        public DateTime Date { get; set; }
        public OrderStatus Status { get; set; }

        public Order()
        {

        }
        public Order(DateTime date,OrderStatus status)
        {
            Date = date;
            Status = status;
        }     
        

    }
}

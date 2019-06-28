using System;
using System.Collections.Generic;
using System.Text;

namespace Pedidos.Entitites
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public  Product Product { get; set; }
       
        public OrderItem()
        {

        }
        
        public OrderItem(int quantity, double price,Product product)
        {
            Quantity = quantity;
            Price = price;
        }

         public double SubTotal(int quantity,double price)
        {
            return quantity * price;
        }
          

        //    public override string ToString()
        //{
        //    return Product.NomeProd
        //        + ", $"
        //        + Price.ToString("F2", CultureInfo.InvariantCulture)
        //        + ", Quantity"
        //        + Quantity
        //        + ", Subtotal: $"
        //        + SuBTotal().ToString("F2", CultureInfo.InvariantCulture);

        //}
    }
}

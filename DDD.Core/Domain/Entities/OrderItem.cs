using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Core.Domain.Entities
{
    public class OrderItem
    {
        public string ProductName { get; private set; }
        public decimal Price { get; private set; }
        public int Quantity { get; private set; }

        public OrderItem(string productName, decimal price, int quantity)
        {
            ProductName = productName;
            Price = price;
            Quantity = quantity;
        }
    }
}

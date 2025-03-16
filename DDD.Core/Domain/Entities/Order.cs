using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Core.Domain.Entities
{
    public class Order
    {
        public Guid Id { get; private set; }
        public DateTime OrderDate { get; private set; }
        public string CustomerName { get; private set; }
        public List<OrderItem> Items { get; private set; } = new();

        public Order(string customerName)
        {
            Id = Guid.NewGuid();
            OrderDate = DateTime.UtcNow;
            CustomerName = customerName;
        }

        public void AddItem(string productName, decimal price, int quantity)
        {
            var item = new OrderItem(productName, price, quantity);
            Items.Add(item);
        }
    }
}

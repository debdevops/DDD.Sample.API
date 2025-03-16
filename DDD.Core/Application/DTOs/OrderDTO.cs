using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Core.Application.DTOs
{
    public class OrderDTO
    {
        public Guid Id { get; set; }
        public string CustomerName { get; set; }
        public List<OrderItemDTO> Items { get; set; } = new();
    }
}

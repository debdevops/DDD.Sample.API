using DDD.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Core.Domain.Interfaces
{
    public interface IOrderRepository
    {
        Task SaveAsync(Order order);
        Task<Order?> GetByIdAsync(Guid id);
    }
}

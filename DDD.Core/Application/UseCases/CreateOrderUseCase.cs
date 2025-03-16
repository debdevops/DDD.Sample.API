using DDD.Core.Application.DTOs;
using DDD.Core.Domain.Entities;
using DDD.Core.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Core.Application.UseCases
{
    public class CreateOrderUseCase
    {
        private readonly IOrderRepository _repository;

        public CreateOrderUseCase(IOrderRepository repository)
        {
            _repository = repository;
        }

        public async Task<OrderDTO> ExecuteAsync(string customerName, List<OrderItemDTO> items)
        {
            var order = new Order(customerName);
            foreach (var item in items)
            {
                order.AddItem(item.ProductName, item.Price, item.Quantity);
            }

            await _repository.SaveAsync(order);

            return new OrderDTO
            {
                Id = order.Id,
                CustomerName = order.CustomerName,
                Items = items
            };
        }
    }
}

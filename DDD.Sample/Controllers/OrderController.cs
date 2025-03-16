using DDD.Core.Application.DTOs;
using DDD.Core.Application.UseCases;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DDD.Sample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly CreateOrderUseCase _createOrderUseCase;

        public OrderController(CreateOrderUseCase createOrderUseCase)
        {
            _createOrderUseCase = createOrderUseCase;
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder([FromBody] OrderDTO orderDto)
        {
            var result = await _createOrderUseCase.ExecuteAsync(orderDto.CustomerName, orderDto.Items);
            return CreatedAtAction(nameof(GetOrder), new { id = result.Id }, result);
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetOrder([FromRoute] Guid id)
        {
            // Mock fetching logic for now
            return Ok(new { Message = $"Fetching order with id {id}" });
        }
    }
}

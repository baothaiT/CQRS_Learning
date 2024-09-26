using MediatR;
using Microsoft.AspNetCore.Mvc;
using CQRS.Application.UserCases.V1.Commands.ProductMediatR;
using CQRS.Application.UserCases.V1.Queries.ProductMediatR;
using CQRS.Contract.Share.DTO;
using Azure.Core;

namespace CQRS.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsMediatRController : Controller
    {
        private readonly ISender _sender;

        public ProductsMediatRController(ISender sender)
        {
            _sender = sender;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var products = await _sender.Send(new GetAllProductsQuery());
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var product = await _sender.Send(new GetProductByIdQuery { Id = id });
            if (product == null)
                return NotFound();

            return Ok(product);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateProductDto createProdutDto)
        {
            var command = new CreateProductCommand
            {
                Name = createProdutDto.Name,
                Price = createProdutDto.Price,
                Stock = createProdutDto.Stock
            };

            var id = await _sender.Send(command);
            return CreatedAtAction(nameof(GetById), new { id }, command);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] UpdateProductDto updateProdutDto)
        {
            var command = new UpdateProductCommand
            {
                Id = id,
                Name = updateProdutDto.Name,
                Price = updateProdutDto.Price,
                Stock = updateProdutDto.Stock
            };
            await _sender.Send(command);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _sender.Send(new DeleteProductCommand { Id = id });
            return NoContent();
        }
    }
}

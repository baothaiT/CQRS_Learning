using MediatR;
using Microsoft.AspNetCore.Mvc;
using CQRS.API.Queries.ProductMediatR;
using CQRS.API.Commands.ProductMediatR;

namespace CQRS.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsMediatRController : Controller
    {
        private readonly IMediator _mediator;

        public ProductsMediatRController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("getAll")]
        public async Task<IActionResult> GetAll()
        {
            var products = await _mediator.Send(new GetAllProductsQuery());
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var product = await _mediator.Send(new GetProductByIdQuery { Id = id });
            if (product == null)
                return NotFound();

            return Ok(product);
        }

        //[HttpPost]
        //public async Task<IActionResult> Create([FromBody] CreateProductCommand command)
        //{
        //    var id = await _mediator.Send(command);
        //    return CreatedAtAction(nameof(GetById), new { id }, command);
        //}

        //[HttpPut("{id}")]
        //public async Task<IActionResult> Update(Guid id, [FromBody] UpdateProductCommand command)
        //{
        //    command.Id = id;
        //    await _mediator.Send(command);
        //    return NoContent();
        //}

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _mediator.Send(new DeleteProductCommand { Id = id });
            return NoContent();
        }
    }
}

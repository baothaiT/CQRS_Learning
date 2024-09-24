using CQRS.API.Commands.Product;
using CQRS.API.Queries.Product;
using Microsoft.AspNetCore.Mvc;

namespace CQRS.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : Controller
    {
        private readonly CreateProductCommandHandler _createHandler;
        private readonly UpdateProductCommandHandler _updateHandler;
        private readonly DeleteProductCommandHandler _deleteHandler;
        private readonly GetAllProductsQueryHandler _getAllHandler;
        private readonly GetProductByIdQueryHandler _getByIdHandler;

        public ProductsController(
            CreateProductCommandHandler createHandler,
            UpdateProductCommandHandler updateHandler,
            DeleteProductCommandHandler deleteHandler,
            GetAllProductsQueryHandler getAllHandler,
            GetProductByIdQueryHandler getByIdHandler)
        {
            _createHandler = createHandler;
            _updateHandler = updateHandler;
            _deleteHandler = deleteHandler;
            _getAllHandler = getAllHandler;
            _getByIdHandler = getByIdHandler;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var products = await _getAllHandler.Handle(new GetAllProductsQuery());
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var product = await _getByIdHandler.Handle(new GetProductByIdQuery { Id = id });
            if (product == null)
                return NotFound();

            return Ok(product);
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody] CreateProductCommand command)
        {
            await _createHandler.Handle(command);
            return CreatedAtAction(nameof(GetById), new { id = command.Id }, command);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] UpdateProductCommand command)
        {
            command.Id = id;
            await _updateHandler.Handle(command);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _deleteHandler.Handle(new DeleteProductCommand { Id = id });
            return NoContent();
        }
    }
}

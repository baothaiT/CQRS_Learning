using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CQRS.API.DTO
{
    public class UpdateProductDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }
}

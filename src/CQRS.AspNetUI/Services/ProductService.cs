using CQRS.AspNetUI.Services.Interfaces;
using CQRS.Contract.Share.DTO;
using System.Text.Json;
using System.Text;

namespace CQRS.AspNetUI.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _httpClient;

        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<GetProductDto>> GetProductsAsync()
        {
            var response = await _httpClient.GetAsync("ProductsMediatR");
            response.EnsureSuccessStatusCode();

            var jsonResponse = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<IEnumerable<GetProductDto>>(jsonResponse, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        public async Task<GetProductDto> GetProductByIdAsync(string id)
        {
            var response = await _httpClient.GetAsync($"ProductsMediatR/{id}");
            response.EnsureSuccessStatusCode();

            var jsonResponse = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<GetProductDto>(jsonResponse, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        public async Task CreateProductAsync(CreateProductDto product)
        {
            var content = new StringContent(JsonSerializer.Serialize(product), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("ProductsMediatR", content);
            response.EnsureSuccessStatusCode();
        }

        public async Task UpdateProductAsync(UpdateProductDto product)
        {
            var content = new StringContent(JsonSerializer.Serialize(product), Encoding.UTF8, "application/json");
            var response = await _httpClient.PutAsync($"ProductsMediatR/{product.Id}", content);
            response.EnsureSuccessStatusCode();
        }

        public async Task DeleteProductAsync(string id)
        {
            var response = await _httpClient.DeleteAsync($"ProductsMediatR/{id}");
            response.EnsureSuccessStatusCode();
        }
    }
}

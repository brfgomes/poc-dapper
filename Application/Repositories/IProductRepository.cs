using Application.DTOs;
using Models.Domain;

namespace Application.Repositories;

public interface IProductRepository
{
    Task<IEnumerable<ProductDTO>> GetProducts();
    Task<ProductDTO> GetProduct(string idProduct);
    Task<string> CreateProduct(ProductModel product);
}
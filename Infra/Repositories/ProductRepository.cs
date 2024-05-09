using Application.DTOs;
using Application.Repositories;
using Models.Domain;

namespace Infra.Repositories;

public class ProductRepository : IProductRepository
{
    public Task<IEnumerable<ProductDTO>> GetProducts()
    {
        throw new NotImplementedException();
    }

    public Task<ProductDTO> GetProduct(string idProduct)
    {
        throw new NotImplementedException();
    }

    public Task<string> CreateProduct(ProductModel product)
    {
        throw new NotImplementedException();
    }
}
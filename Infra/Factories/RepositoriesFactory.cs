using Application.Factories;
using Application.Repositories;

namespace Infra.Factory;

public class RepositoriesFactory : IRepositoriesFactory
{
    public RepositoriesFactory(IPersonRepository personRepository, IProductRepository productRepository)
    {
        _personRepository = personRepository;
        _productRepository = productRepository;
    }

    private readonly IPersonRepository _personRepository;
    private readonly IProductRepository _productRepository;

    public IPersonRepository CreatePersonRepository() => _personRepository;
    public IProductRepository CreateProductRepository() => _productRepository;
}
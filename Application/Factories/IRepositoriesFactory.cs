using Application.Repositories;

namespace Application.Factories;

public interface IRepositoriesFactory
{
    IPersonRepository CreatePersonRepository();
    IProductRepository CreateProductRepository();
}
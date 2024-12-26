using Domain.Entities;
using Infrastructure.ApiResponses;

namespace Infrastructure.Interfaces;

public interface IProductService
{
    Task<Response<List<Product>>> GetProducts();
    Task<Response<Product>> GetProduct(int id);
    Task<Response<string>> CreateProduct(Product request);
    Task<Response<string>> UpdateProduct(Product request);
    Task<Response<string>> DeleteProduct(int id);
}
using Domain.Entities;
using Infrastructure.ApiResponses;
using Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]

public class ProductController(IProductService productService)
{
    [HttpGet]
    public async Task<Response<List<Product>>> GetProducts()
    {
        return await productService.GetProducts();
    }

    [HttpGet("{id}")]
    public async Task<Response<Product>> GetProduct(int id)
    {
        return await productService.GetProduct(id);
    }

    [HttpPost]
    public async Task<Response<string>> CreateProduct(Product request)
    {
        return await productService.CreateProduct(request);
    }

    [HttpPut]
    public async Task<Response<string>> UpdateProduct(Product request)
    {
        return await productService.UpdateProduct(request);
    }

    [HttpDelete]
    public async Task<Response<string>> DeleteProduct(int id)
    {
        return await productService.DeleteProduct(id);
    }
}
using Domain.Data;
using Entity.Model;

namespace Domain.Validation.Impl;

public class ProductValidation : IProductValidation
{
    private IProductRepo _productRepo;
    
    public ProductValidation(IProductRepo productRepo)
    {
        _productRepo = productRepo;
    }

    // all the logic
    public async Task<IList<Product>> GetProductsAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<Product> GetProductAsync(int id)
    {
        throw new NotImplementedException();
    }
}
using Entity.Model;

namespace Domain.Validation;

public interface IProductValidation
{
    public Task<IList<Product>> GetProductsAsync();
    public Task<Product> GetProductAsync(int id);
}
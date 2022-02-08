using Domain.Validation;
using Entity.Model;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    private readonly IProductValidation _productValidation;

    public ProductController(IProductValidation productValidation)
    {
        _productValidation = productValidation;
    }

    [HttpGet]
    public async Task<ActionResult<IList<Product>>> GetAllProducts()
    {
        try
        {
            IList<Product> products = await _productValidation.GetProductsAsync();
            return Ok(products);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return StatusCode(500, e.Message);
        }
    }

    [HttpGet]
    [Route("{id:int}")]
    public async Task<ActionResult<Product>> GetProduct([FromRoute] int id)
    {
        try
        {
            Product product = await _productValidation.GetProductAsync(id);
            return Ok(product);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return StatusCode(500, e.Message);
        }
    }

    // [HttpPost]
    // public async Task<ActionResult<Product>> AddProduct([FromBody] Product product)
    // {
    //     if (!ModelState.IsValid)
    //     {
    //         return BadRequest(ModelState);
    //     }
    //
    //     try
    //     {
    //         Product added = await productValidation.CreateAsync(product);
    //         return Created($"/{added.Id}", added);
    //         // returns newly added product, to get the auto generated id
    //     }
    //     catch (Exception e)
    //     {
    //         Console.WriteLine(e);
    //         return StatusCode(500, e.Message);
    //     }
    // }
    //
    // [HttpDelete]
    // [Route("{id:int}")]
    // public async Task<ActionResult> DeleteProduct([FromRoute] int id)
    // {
    //     try
    //     {
    //         await productValidation.DeleteAsync(id);
    //         return Ok();
    //     }
    //     catch (Exception e)
    //     {
    //         Console.WriteLine(e);
    //         return StatusCode(500, e.Message);
    //     }
    // }
    //
    // [HttpPatch]
    // [Route("{id:int}")]
    // public async Task<ActionResult<Product>> UpdateProduct([FromBody] Product product)
    // {
    //     try
    //     {
    //         Product updated = await productValidation.UpdateAsync(product);
    //         return Ok(updated);
    //     }
    //     catch (Exception e)
    //     {
    //         Console.WriteLine(e);
    //         return StatusCode(500, e.Message);
    //     }
    // }
}
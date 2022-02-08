using System.ComponentModel.DataAnnotations;

namespace Entity.Model;

public class Item
{
    [Required]
    public int OrderId { get; set; }
    
    [Required]
    public int ProductId { get; set; }
    public virtual Product Product { get; set; }
    
    [Required]
    public int Amount { get; set; }
    
    public decimal TotalPrice => Product.Price * Amount;
}
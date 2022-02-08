using System.ComponentModel.DataAnnotations;

namespace Entity.Model;

public class Address
{
    public int Id { get; set; }
    
    [Required]
    public int ZipCode { get; set; }
    
    [Required]
    public string City { get; set; }
    
    [Required]
    public string Street { get; set; }
    
    [Required]
    public string HouseNumber { get; set; }
    
}
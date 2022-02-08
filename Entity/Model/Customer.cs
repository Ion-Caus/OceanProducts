using System.ComponentModel.DataAnnotations;

namespace Entity.Model;

public class Customer
{
    [Required]
    [Phone]
    public string PhoneNo { get; set; }
    [Required]
    public string FirstName { get; set; }
    [Required]
    public string LastName { get; set; }
}
using System.ComponentModel.DataAnnotations;

namespace Entity.Model;

public class Order
{
    public int Id { get; set; }
    [Required]
    public OrderStatus Status { get; set; }
    [Required]
    public decimal TotalPrice { get; set; }
    [Required]
    public Address DeliveryAddress { get; set; }
    [Required]
    public DateTime CreatedAt { get; set; }
    [Required]
    public DateTime DeliveredAt { get; set; }
    public string Note { get; set; } = string.Empty;

    public IList<Item> Items { get; set; } = new List<Item>();
}

public enum OrderStatus
{
    Completed,
    NotCompleted,
    Canceled
}
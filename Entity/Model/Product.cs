using System.ComponentModel.DataAnnotations;

namespace Entity.Model
{
    public class Product
    {

        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public int NetMass { get; set; }
        [Required]
        public string CountryOfOrigin { get; set; }
        public string ImgEncoded { get; set; }
        
    }
}
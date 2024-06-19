using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment1_Api.DTO
{
    public class ProductRequest
    {
        public int ProductId { get; set; }
        [Required]
        public string ProductName { get; set; } = null!;

        [Required]
        [Range(1, Int32.MaxValue)]
        public int UnitPrice { get; set; }
   
        [Required]
        public int CategoryId { get; set; }
  
 
  
  
    }
}


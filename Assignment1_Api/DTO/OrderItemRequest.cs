 using Assignment1_Api.Models;
using System.ComponentModel.DataAnnotations;

namespace Assignment1_Api.DTO
{
    public class OrderItemRequest
    {
        [Required]
        public Product Product { get; set; }
        [Required]
        public int Quantity { get; set; }
        public int Price { get; set; }

    }
}
